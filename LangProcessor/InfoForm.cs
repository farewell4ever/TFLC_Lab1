using System.ComponentModel;

namespace LangProcessor;

[DesignerCategory("Code")]
public sealed class InfoForm : Form
{
    public InfoForm(string title, IEnumerable<(string Header, string Body)> sections, Size size)
    {
        Text = title;
        ClientSize = size;
        MinimumSize = new Size(360, 240);
        StartPosition = FormStartPosition.CenterParent;
        ShowInTaskbar = false;
        MinimizeBox = false;
        Font = SystemFonts.MessageBoxFont ?? Font;

        var text = new RichTextBox
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            BorderStyle = BorderStyle.None,
            BackColor = SystemColors.Window,
            DetectUrls = false,
            ScrollBars = RichTextBoxScrollBars.Vertical,
            TabStop = false,
        };

        using (var header = new Font(Font.FontFamily, 12.5f, FontStyle.Bold))
        using (var body = new Font(Font.FontFamily, 10.5f))
        {
            foreach (var (h, b) in sections)
            {
                if (!string.IsNullOrEmpty(h))
                {
                    text.SelectionFont = header;
                    text.AppendText((text.TextLength > 0 ? "\n" : "") + h + "\n");
                }
                if (!string.IsNullOrEmpty(b))
                {
                    text.SelectionFont = body;
                    text.AppendText(b + "\n");
                }
            }
        }
        text.Select(0, 0);

        var close = new Button
        {
            Text = "Закрыть",
            DialogResult = DialogResult.Cancel,
            AutoSize = true,
            MinimumSize = new Size(90, 30),
            Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
        };
        var bottom = new Panel { Dock = DockStyle.Bottom, Height = 48 };
        close.Location = new Point(bottom.Width - close.Width - 12, 9);
        bottom.Controls.Add(close);
        bottom.Resize += (_, _) => close.Location = new Point(bottom.ClientSize.Width - close.Width - 12, 9);

        var content = new Panel { Dock = DockStyle.Fill, Padding = new Padding(18, 12, 6, 0), BackColor = SystemColors.Window };
        content.Controls.Add(text);

        Controls.Add(content);
        Controls.Add(bottom);
        AcceptButton = close;
        CancelButton = close;
        close.Click += (_, _) => Close();
        Shown += (_, _) => close.Focus();
    }

    public static void Show(IWin32Window owner, string title, IEnumerable<(string, string)> sections, Size size)
    {
        var form = new InfoForm(title, sections, size);
        if (owner is Form parent)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                parent.Left + (parent.Width - form.Width) / 2,
                parent.Top + (parent.Height - form.Height) / 2);
        }
        form.FormClosed += (_, _) => form.Dispose();
        form.Show(owner);
    }
}
