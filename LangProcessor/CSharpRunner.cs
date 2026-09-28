using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.Loader;
using Basic.Reference.Assemblies;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;

namespace LangProcessor;

public sealed record Diagnostic(int Line, int Column, int Length, string Code, string Message);

public sealed record RunResult(List<Diagnostic> Errors, string Output, bool Executed, bool TimedOut);

public static class CSharpRunner
{
    private const string FileName = "program.cs";
    private static readonly CultureInfo Russian = new("ru-RU");
    private static readonly TimeSpan Timeout = TimeSpan.FromSeconds(5);

    private const string Usings =
        "using System;\n" +
        "using System.Collections.Generic;\n" +
        "using System.Linq;\n" +
        "using System.Text;\n";

    public static RunResult CompileAndRun(string userCode)
    {
        var userLines = userCode.Split('\n').Length;
        var source = Wrap(userCode);

        var tree = CSharpSyntaxTree.ParseText(
            SourceText.From(source, System.Text.Encoding.UTF8),
            new CSharpParseOptions(LanguageVersion.Latest), FileName);
        var compilation = CSharpCompilation.Create(
            "UserProgram",
            new[] { tree },
            Net70.References.All,
            new CSharpCompilationOptions(OutputKind.ConsoleApplication, optimizationLevel: OptimizationLevel.Debug));

        using var peStream = new MemoryStream();
        using var pdbStream = new MemoryStream();
        var emit = compilation.Emit(peStream, pdbStream, options: new EmitOptions(debugInformationFormat: DebugInformationFormat.PortablePdb));

        var compilerErrors = emit.Diagnostics
            .Where(d => d.Severity == DiagnosticSeverity.Error)
            .Select(d => ToDiagnostic(d, userLines))
            .Distinct()
            .ToList();

        var errors = CleanUp(compilerErrors, BracketChecker.Check(userCode))
            .OrderBy(d => d.Line).ThenBy(d => d.Column)
            .ToList();

        if (!emit.Success || errors.Count > 0)
            return new RunResult(errors, "", false, false);

        return Execute(peStream.ToArray(), pdbStream.ToArray(), userLines);
    }

    private static bool IsSyntaxError(Diagnostic d) =>
        d.Code.StartsWith("CS1", StringComparison.Ordinal) || d.Code == "CS0443";

    private static IEnumerable<Diagnostic> CleanUp(List<Diagnostic> compiler, List<Diagnostic> brackets)
    {
        var bracketLines = brackets.Select(b => b.Line).ToHashSet();
        var hasBraceError = brackets.Any(b => b.Message.Contains('{') || b.Message.Contains('}'));

        foreach (var d in compiler)
        {
            if (!IsSyntaxError(d))
            {
                yield return d;
                continue;
            }
            if (bracketLines.Contains(d.Line)) continue;
            if (hasBraceError && d.Code is "CS1513" or "CS1022") continue;
            if (d.Code == "CS1002" && compiler.Any(o => o != d && IsSyntaxError(o)
                                                         && o.Line == d.Line && o.Column == d.Column))
                continue;
            yield return d;
        }

        foreach (var b in brackets) yield return b;
    }

    private static string Wrap(string code)
    {
        var isFullProgram = code.Contains("static void Main") || code.Contains("static int Main")
                            || code.Contains("static async");
        if (isFullProgram)
            return Usings + $"#line 1 \"{FileName}\"\n" + code;

        return Usings +
               "class Program\n{\n    static void Main()\n    {\n" +
               $"#line 1 \"{FileName}\"\n" +
               code + "\n" +
               "#line hidden\n" +
               "    }\n}\n";
    }

    private static Diagnostic ToDiagnostic(Microsoft.CodeAnalysis.Diagnostic d, int userLines)
    {
        var span = d.Location.GetMappedLineSpan();
        int line = 1, column = 1, length = 0;
        if (span.IsValid && d.Location.IsInSource)
        {
            line = span.StartLinePosition.Line + 1;
            column = span.StartLinePosition.Character + 1;
            length = span.StartLinePosition.Line == span.EndLinePosition.Line
                ? Math.Max(0, span.EndLinePosition.Character - span.StartLinePosition.Character)
                : 0;
        }

        if (line > userLines || line < 1)
        {
            line = userLines;
            column = 1;
            length = 0;
        }

        return new Diagnostic(line, column, length, d.Id, d.GetMessage(Russian));
    }

    private static RunResult Execute(byte[] pe, byte[] pdb, int userLines)
    {
        var context = new AssemblyLoadContext("UserProgram", isCollectible: true);
        var output = new StringWriter();
        var errors = new List<Diagnostic>();
        var oldOut = Console.Out;
        var oldIn = Console.In;

        var thread = new Thread(() =>
        {
            try
            {
                var assembly = context.LoadFromStream(new MemoryStream(pe), new MemoryStream(pdb));
                var entry = assembly.EntryPoint!;
                var args = entry.GetParameters().Length == 0 ? null : new object[] { Array.Empty<string>() };
                var result = entry.Invoke(null, args);
                if (result is Task task) task.GetAwaiter().GetResult();
            }
            catch (TargetInvocationException ex) when (ex.InnerException is not null)
            {
                errors.Add(RuntimeError(ex.InnerException, userLines));
            }
            catch (Exception ex)
            {
                errors.Add(RuntimeError(ex, userLines));
            }
        })
        {
            IsBackground = true,
        };

        Console.SetOut(output);
        Console.SetIn(new StringReader(""));
        try
        {
            thread.Start();
            var finished = thread.Join(Timeout);
            if (!finished)
                errors.Add(new Diagnostic(1, 1, 0, "",
                    $"Выполнение программы остановлено: превышено время ожидания ({Timeout.TotalSeconds:0} с). Возможно, в программе бесконечный цикл."));
            return new RunResult(errors, output.ToString(), true, !finished);
        }
        finally
        {
            Console.SetOut(oldOut);
            Console.SetIn(oldIn);
            context.Unload();
        }
    }

    private static Diagnostic RuntimeError(Exception ex, int userLines)
    {
        var frame = new StackTrace(ex, true).GetFrames()
            .FirstOrDefault(f => f.GetFileLineNumber() > 0 && f.GetFileName() == FileName);
        var line = frame?.GetFileLineNumber() ?? 1;
        var column = frame?.GetFileColumnNumber() ?? 1;
        if (line > userLines) line = userLines;

        return new Diagnostic(line, Math.Max(1, column), 0, ex.GetType().Name,
            $"Ошибка при выполнении программы: {ex.Message}");
    }
}
