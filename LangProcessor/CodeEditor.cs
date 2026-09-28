using System.ComponentModel;
using System.Runtime.InteropServices;

namespace LangProcessor;

[DesignerCategory("Code")]
public class CodeEditor : RichTextBox
{
    private readonly record struct State(string Text, int Caret);

    private const int MaxUndo = 500;
    private const int WM_MOUSEWHEEL = 0x020A;
    private const int EM_SETUNDOLIMIT = 0x0400 + 82;

    [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr h, int msg, IntPtr w, IntPtr l);

    private readonly List<State> _undo = new();
    private readonly Stack<State> _redo = new();
    private State _current = new("", 0);
    private DateTime _lastEdit = DateTime.MinValue;
    private bool _canMerge;
    private bool _restoring;

    public event EventHandler<int>? ZoomRequested;

    public CodeEditor()
    {
        AcceptsTab = true;
        WordWrap = false;
        DetectUrls = false;
        HideSelection = false;
        EnableAutoDragDrop = false;
        BorderStyle = BorderStyle.None;
        ScrollBars = RichTextBoxScrollBars.ForcedBoth;
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string CurrentText => _current.Text;

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool CanUndoEdit => _undo.Count > 0;

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool CanRedoEdit => _redo.Count > 0;

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        SendMessage(Handle, EM_SETUNDOLIMIT, IntPtr.Zero, IntPtr.Zero);
        Select(Math.Min(_current.Caret, TextLength), 0);
    }

    public void LoadText(string text)
    {
        _restoring = true;
        Text = text.Replace("\r\n", "\n");
        _restoring = false;
        _undo.Clear();
        _redo.Clear();
        _current = new State(Text, 0);
        _canMerge = false;
        Select(0, 0);
    }

    protected override void OnTextChanged(EventArgs e)
    {
        var text = Text;
        if (!_restoring && text != _current.Text)
        {
            var now = DateTime.Now;
            var typedOneChar = Math.Abs(text.Length - _current.Text.Length) == 1;
            var newLine = text.Length > _current.Text.Length && SelectionStart > 0 && text[SelectionStart - 1] == '\n';
            var merge = _canMerge && typedOneChar && !newLine && (now - _lastEdit).TotalMilliseconds < 1000;

            if (!merge)
            {
                _undo.Add(_current);
                if (_undo.Count > MaxUndo) _undo.RemoveAt(0);
            }
            _redo.Clear();
            _lastEdit = now;
            _canMerge = typedOneChar;
        }

        _current = new State(text, SelectionStart);
        base.OnTextChanged(e);
    }

    public void UndoEdit()
    {
        if (_undo.Count == 0) return;
        _redo.Push(_current);
        var state = _undo[^1];
        _undo.RemoveAt(_undo.Count - 1);
        Restore(state);
    }

    public void RedoEdit()
    {
        if (_redo.Count == 0) return;
        _undo.Add(_current);
        Restore(_redo.Pop());
    }

    private void Restore(State state)
    {
        var caret = ChangedPosition(_current.Text, state.Text);
        _restoring = true;
        Text = state.Text;
        _current = state with { Caret = caret };
        Select(Math.Min(caret, TextLength), 0);
        _restoring = false;
        _canMerge = false;
        ScrollToCaret();
        base.OnTextChanged(EventArgs.Empty);
    }

    private static int ChangedPosition(string oldText, string newText)
    {
        var prefix = 0;
        var max = Math.Min(oldText.Length, newText.Length);
        while (prefix < max && oldText[prefix] == newText[prefix]) prefix++;

        var suffix = 0;
        while (suffix < max - prefix &&
               oldText[oldText.Length - 1 - suffix] == newText[newText.Length - 1 - suffix]) suffix++;

        return newText.Length - suffix;
    }

    public void PastePlain()
    {
        if (!Clipboard.ContainsText()) return;
        _canMerge = false;
        SelectedText = Clipboard.GetText().Replace("\r\n", "\n");
    }

    public void CutSelection()
    {
        if (SelectionLength == 0) return;
        _canMerge = false;
        Cut();
    }

    public void DeleteSelection()
    {
        _canMerge = false;
        if (SelectionLength == 0)
        {
            if (SelectionStart >= TextLength) return;
            SelectionLength = 1;
        }
        SelectedText = "";
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        switch (keyData)
        {
            case Keys.Control | Keys.Z:
                UndoEdit();
                return true;
            case Keys.Control | Keys.Y:
            case Keys.Control | Keys.Shift | Keys.Z:
                RedoEdit();
                return true;
            case Keys.Control | Keys.V:
            case Keys.Shift | Keys.Insert:
                PastePlain();
                return true;
            case Keys.Control | Keys.X:
            case Keys.Shift | Keys.Delete:
                CutSelection();
                return true;
            case Keys.Control | Keys.B:
            case Keys.Control | Keys.I:
            case Keys.Control | Keys.U:
            case Keys.Control | Keys.E:
            case Keys.Control | Keys.L:
            case Keys.Control | Keys.R:
            case Keys.Control | Keys.J:
            case Keys.Control | Keys.D1:
            case Keys.Control | Keys.D2:
            case Keys.Control | Keys.D5:
            case Keys.Control | Keys.Shift | Keys.Oemcomma:
            case Keys.Control | Keys.Shift | Keys.OemPeriod:
            case Keys.Control | Keys.Shift | Keys.A:
                return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_MOUSEWHEEL && (ModifierKeys & Keys.Control) != 0)
        {
            var delta = (short)((long)m.WParam >> 16);
            ZoomRequested?.Invoke(this, delta > 0 ? 1 : -1);
            return;
        }
        base.WndProc(ref m);
    }
}
