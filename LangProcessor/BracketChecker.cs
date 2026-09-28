namespace LangProcessor;

public static class BracketChecker
{
    public static List<Diagnostic> Check(string code)
    {
        var errors = new List<Diagnostic>();
        var stack = new Stack<(char Ch, int Line, int Col)>();
        int line = 1, col = 0, i = 0;

        char Peek(int k) => i + k < code.Length ? code[i + k] : '\0';

        void Advance()
        {
            if (code[i] == '\n') { line++; col = 0; }
            else col++;
            i++;
        }

        while (i < code.Length)
        {
            var c = code[i];

            if (c == '/' && Peek(1) == '/')
            {
                while (i < code.Length && code[i] != '\n') Advance();
                continue;
            }
            if (c == '/' && Peek(1) == '*')
            {
                Advance(); Advance();
                while (i < code.Length && !(code[i] == '*' && Peek(1) == '/')) Advance();
                if (i < code.Length) { Advance(); Advance(); }
                continue;
            }
            if (c == '@' && Peek(1) == '"' || c == '$' && Peek(1) == '@' && Peek(2) == '"'
                || c == '@' && Peek(1) == '$' && Peek(2) == '"')
            {
                while (code[i] != '"') Advance();
                Advance();
                while (i < code.Length)
                {
                    if (code[i] == '"' && Peek(1) == '"') { Advance(); Advance(); continue; }
                    if (code[i] == '"') { Advance(); break; }
                    Advance();
                }
                continue;
            }
            if (c == '"' || c == '\'' || c == '$' && Peek(1) == '"')
            {
                if (c == '$') Advance();
                var quote = code[i];
                Advance();
                while (i < code.Length && code[i] != quote && code[i] != '\n')
                {
                    if (code[i] == '\\' && i + 1 < code.Length) Advance();
                    Advance();
                }
                if (i < code.Length && code[i] == quote) Advance();
                continue;
            }

            Advance();
            var column = col;
            switch (c)
            {
                case '(' or '[' or '{':
                    stack.Push((c, line, column));
                    break;

                case ')' or ']' or '}':
                    var open = c switch { ')' => '(', ']' => '[', _ => '{' };
                    if (stack.Count > 0 && stack.Peek().Ch == open)
                        stack.Pop();
                    else if (stack.Count > 0 && stack.Skip(1).Any(s => s.Ch == open))
                    {
                        while (stack.Peek().Ch != open)
                        {
                            var (ch, l, cc) = stack.Pop();
                            errors.Add(Unclosed(ch, l, cc));
                        }
                        stack.Pop();
                    }
                    else
                        errors.Add(new Diagnostic(line, column, 1, "—",
                            $"Лишняя закрывающая скобка «{c}»: нет соответствующей открывающей «{open}»"));
                    break;
            }
        }

        foreach (var (ch, l, cc) in stack)
            errors.Add(Unclosed(ch, l, cc));

        return errors;
    }

    private static Diagnostic Unclosed(char ch, int line, int col)
    {
        var close = ch switch { '(' => ')', '[' => ']', _ => '}' };
        return new Diagnostic(line, col, 1, "—", $"Не закрыта скобка «{ch}»: требуется «{close}»");
    }
}
