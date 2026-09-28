using System.ComponentModel;

namespace LangProcessor;

[DesignerCategory("Code")]
public class LineNumberPanel : Control
{
    private readonly CodeEditor _editor;

    public LineNumberPanel(CodeEditor editor)
    {
        _editor = editor;
        DoubleBuffered = true;
        BackColor = Color.FromArgb(245, 245, 245);
        ForeColor = Color.FromArgb(140, 140, 140);
        Dock = DockStyle.Left;

        _editor.TextChanged += (_, _) => UpdateWidthAndRedraw();
        _editor.VScroll += (_, _) => Invalidate();
        _editor.Resize += (_, _) => Invalidate();
        _editor.FontChanged += (_, _) => UpdateWidthAndRedraw();
        UpdateWidthAndRedraw();
    }

    private void UpdateWidthAndRedraw()
    {
        Font = _editor.Font;
        var lines = CountLines(_editor.CurrentText);
        var digits = Math.Max(3, lines.ToString().Length);
        var width = TextRenderer.MeasureText(new string('9', digits), Font).Width + 8;
        if (Width != width) Width = width;
        Invalidate();
    }

    private static int CountLines(string text)
    {
        var count = 1;
        foreach (var ch in text)
            if (ch == '\n') count++;
        return count;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var text = _editor.CurrentText;

        var first = _editor.GetCharIndexFromPosition(new Point(1, 1));
        first = Math.Clamp(first, 0, text.Length);
        var lineStart = first == 0 ? 0 : text.LastIndexOf('\n', Math.Max(0, first - 1)) + 1;
        var lineNumber = 1;
        for (var i = 0; i < lineStart; i++)
            if (text[i] == '\n') lineNumber++;

        var lineHeight = Font.Height;
        using var pen = new Pen(Color.FromArgb(220, 220, 220));
        e.Graphics.DrawLine(pen, Width - 1, 0, Width - 1, Height);

        while (lineStart <= text.Length)
        {
            var y = lineStart < text.Length || text.Length == 0
                ? _editor.GetPositionFromCharIndex(lineStart).Y
                : _editor.GetPositionFromCharIndex(text.Length - 1).Y + lineHeight;
            if (y > Height) break;
            if (y > -lineHeight)
            {
                var rect = new Rectangle(0, y, Width - 5, lineHeight);
                TextRenderer.DrawText(e.Graphics, lineNumber.ToString(), Font, rect, ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.NoPadding);
            }

            var next = text.IndexOf('\n', lineStart);
            if (next < 0) break;
            lineStart = next + 1;
            lineNumber++;
        }
    }
}
