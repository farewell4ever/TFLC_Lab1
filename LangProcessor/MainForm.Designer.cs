namespace LangProcessor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            menuStrip = new System.Windows.Forms.MenuStrip();
            menuFile = new System.Windows.Forms.ToolStripMenuItem();
            menuNew = new System.Windows.Forms.ToolStripMenuItem();
            menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            menuSave = new System.Windows.Forms.ToolStripMenuItem();
            menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            menuFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            menuExit = new System.Windows.Forms.ToolStripMenuItem();
            menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            menuEditSep1 = new System.Windows.Forms.ToolStripSeparator();
            menuCut = new System.Windows.Forms.ToolStripMenuItem();
            menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            menuEditSep2 = new System.Windows.Forms.ToolStripSeparator();
            menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            menuText = new System.Windows.Forms.ToolStripMenuItem();
            menuTextTask = new System.Windows.Forms.ToolStripMenuItem();
            menuTextGrammar = new System.Windows.Forms.ToolStripMenuItem();
            menuTextClassification = new System.Windows.Forms.ToolStripMenuItem();
            menuTextMethod = new System.Windows.Forms.ToolStripMenuItem();
            menuTextExample = new System.Windows.Forms.ToolStripMenuItem();
            menuTextLiterature = new System.Windows.Forms.ToolStripMenuItem();
            menuTextSource = new System.Windows.Forms.ToolStripMenuItem();
            menuRun = new System.Windows.Forms.ToolStripMenuItem();
            menuView = new System.Windows.Forms.ToolStripMenuItem();
            menuZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            menuZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            menuZoomReset = new System.Windows.Forms.ToolStripMenuItem();
            menuViewSep1 = new System.Windows.Forms.ToolStripSeparator();
            menuWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            menuLineNumbers = new System.Windows.Forms.ToolStripMenuItem();
            menuViewSep2 = new System.Windows.Forms.ToolStripSeparator();
            menuClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            menuHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip = new System.Windows.Forms.ToolStrip();
            btnNew = new System.Windows.Forms.ToolStripButton();
            btnOpen = new System.Windows.Forms.ToolStripButton();
            btnSave = new System.Windows.Forms.ToolStripButton();
            btnSaveAs = new System.Windows.Forms.ToolStripButton();
            toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            btnUndo = new System.Windows.Forms.ToolStripButton();
            btnRedo = new System.Windows.Forms.ToolStripButton();
            toolSep2 = new System.Windows.Forms.ToolStripSeparator();
            btnCopy = new System.Windows.Forms.ToolStripButton();
            btnCut = new System.Windows.Forms.ToolStripButton();
            btnPaste = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            btnSelectAll = new System.Windows.Forms.ToolStripButton();
            toolSep3 = new System.Windows.Forms.ToolStripSeparator();
            btnRun = new System.Windows.Forms.ToolStripButton();
            toolSep4 = new System.Windows.Forms.ToolStripSeparator();
            btnHelp = new System.Windows.Forms.ToolStripButton();
            btnAbout = new System.Windows.Forms.ToolStripButton();
            toolSep5 = new System.Windows.Forms.ToolStripSeparator();
            btnExit = new System.Windows.Forms.ToolStripButton();
            toolSep6 = new System.Windows.Forms.ToolStripSeparator();
            lblFontSize = new System.Windows.Forms.ToolStripLabel();
            cmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusText = new System.Windows.Forms.ToolStripStatusLabel();
            statusPosition = new System.Windows.Forms.ToolStripStatusLabel();
            statusLength = new System.Windows.Forms.ToolStripStatusLabel();
            statusEncoding = new System.Windows.Forms.ToolStripStatusLabel();
            splitContainer = new System.Windows.Forms.SplitContainer();
            codeEditor = new LangProcessor.CodeEditor();
            outputGrid = new System.Windows.Forms.DataGridView();
            colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            outputTabs = new System.Windows.Forms.TabControl();
            tabErrors = new System.Windows.Forms.TabPage();
            tabOutput = new System.Windows.Forms.TabPage();
            outputText = new System.Windows.Forms.RichTextBox();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outputGrid).BeginInit();
            SuspendLayout();
            //
            // menuStrip
            //
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFile, menuEdit, menuText, menuRun, menuView, menuHelp });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            menuStrip.Size = new System.Drawing.Size(1100, 30);
            menuStrip.TabIndex = 0;
            //
            // menuFile
            //
            menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuNew, menuOpen, menuSave, menuSaveAs, menuFileSep1, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Text = "&Файл";
            //
            // menuNew
            //
            menuNew.Image = global::LangProcessor.Properties.Resources.icon_new;
            menuNew.Name = "menuNew";
            menuNew.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            menuNew.Text = "&Создать";
            menuNew.Click += OnNew;
            //
            // menuOpen
            //
            menuOpen.Image = global::LangProcessor.Properties.Resources.icon_open;
            menuOpen.Name = "menuOpen";
            menuOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            menuOpen.Text = "&Открыть...";
            menuOpen.Click += OnOpen;
            //
            // menuSave
            //
            menuSave.Image = global::LangProcessor.Properties.Resources.icon_save;
            menuSave.Name = "menuSave";
            menuSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            menuSave.Text = "Со&хранить";
            menuSave.Click += OnSave;
            //
            // menuSaveAs
            //
            menuSaveAs.Image = global::LangProcessor.Properties.Resources.icon_save_as;
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            menuSaveAs.Text = "Сохранить &как...";
            menuSaveAs.Click += OnSaveAs;
            //
            // menuExit
            //
            menuExit.Image = global::LangProcessor.Properties.Resources.icon_exit;
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeyDisplayString = "Alt+F4";
            menuExit.Text = "&Выход";
            menuExit.Click += OnExit;
            //
            // menuEdit
            //
            menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuUndo, menuRedo, menuEditSep1, menuCut, menuCopy, menuPaste, menuDelete, menuEditSep2, menuSelectAll });
            menuEdit.Name = "menuEdit";
            menuEdit.Text = "&Правка";
            //
            // menuUndo
            //
            menuUndo.Image = global::LangProcessor.Properties.Resources.icon_undo;
            menuUndo.Name = "menuUndo";
            menuUndo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            menuUndo.Text = "&Отменить";
            menuUndo.Click += OnUndo;
            //
            // menuRedo
            //
            menuRedo.Image = global::LangProcessor.Properties.Resources.icon_redo;
            menuRedo.Name = "menuRedo";
            menuRedo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            menuRedo.Text = "&Повторить";
            menuRedo.Click += OnRedo;
            //
            // menuCut
            //
            menuCut.Image = global::LangProcessor.Properties.Resources.icon_cut;
            menuCut.Name = "menuCut";
            menuCut.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            menuCut.Text = "&Вырезать";
            menuCut.Click += OnCut;
            //
            // menuCopy
            //
            menuCopy.Image = global::LangProcessor.Properties.Resources.icon_copy;
            menuCopy.Name = "menuCopy";
            menuCopy.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            menuCopy.Text = "&Копировать";
            menuCopy.Click += OnCopy;
            //
            // menuPaste
            //
            menuPaste.Image = global::LangProcessor.Properties.Resources.icon_paste;
            menuPaste.Name = "menuPaste";
            menuPaste.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            menuPaste.Text = "Вст&авить";
            menuPaste.Click += OnPaste;
            //
            // menuDelete
            //
            menuDelete.Image = global::LangProcessor.Properties.Resources.icon_delete;
            menuDelete.Name = "menuDelete";
            menuDelete.ShortcutKeyDisplayString = "Del";
            menuDelete.Text = "&Удалить";
            menuDelete.Click += OnDelete;
            //
            // menuSelectAll
            //
            menuSelectAll.Image = global::LangProcessor.Properties.Resources.icon_select_all;
            menuSelectAll.Name = "menuSelectAll";
            menuSelectAll.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            menuSelectAll.Text = "Выделить &все";
            menuSelectAll.Click += OnSelectAll;
            //
            // menuText
            //
            menuText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuTextTask, menuTextGrammar, menuTextClassification, menuTextMethod, menuTextExample, menuTextLiterature, menuTextSource });
            menuText.Name = "menuText";
            menuText.Text = "&Текст";
            //
            // menuTextTask
            //
            menuTextTask.Name = "menuTextTask";
            menuTextTask.Tag = "task";
            menuTextTask.Text = "Постановка задачи";
            menuTextTask.Click += OnTextSection;
            //
            // menuTextGrammar
            //
            menuTextGrammar.Name = "menuTextGrammar";
            menuTextGrammar.Tag = "grammar";
            menuTextGrammar.Text = "Грамматика";
            menuTextGrammar.Click += OnTextSection;
            //
            // menuTextClassification
            //
            menuTextClassification.Name = "menuTextClassification";
            menuTextClassification.Tag = "classification";
            menuTextClassification.Text = "Классификация грамматики";
            menuTextClassification.Click += OnTextSection;
            //
            // menuTextMethod
            //
            menuTextMethod.Name = "menuTextMethod";
            menuTextMethod.Tag = "method";
            menuTextMethod.Text = "Метод анализа";
            menuTextMethod.Click += OnTextSection;
            //
            // menuTextExample
            //
            menuTextExample.Name = "menuTextExample";
            menuTextExample.Tag = "example";
            menuTextExample.Text = "Тестовый пример";
            menuTextExample.Click += OnTextSection;
            //
            // menuTextLiterature
            //
            menuTextLiterature.Name = "menuTextLiterature";
            menuTextLiterature.Tag = "literature";
            menuTextLiterature.Text = "Список литературы";
            menuTextLiterature.Click += OnTextSection;
            //
            // menuTextSource
            //
            menuTextSource.Name = "menuTextSource";
            menuTextSource.Tag = "source";
            menuTextSource.Text = "Исходный код программы";
            menuTextSource.Click += OnTextSection;
            //
            // menuRun
            //
            menuRun.Name = "menuRun";
            menuRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
            menuRun.Text = "П&уск";
            menuRun.Click += OnRun;
            //
            // menuView
            //
            menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuZoomIn, menuZoomOut, menuZoomReset, menuViewSep1, menuWordWrap, menuLineNumbers, menuViewSep2, menuClearOutput });
            menuView.Name = "menuView";
            menuView.Text = "&Вид";
            //
            // menuZoomIn
            //
            menuZoomIn.Name = "menuZoomIn";
            menuZoomIn.ShortcutKeyDisplayString = "Ctrl++";
            menuZoomIn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus;
            menuZoomIn.Text = "Увеличить шрифт";
            menuZoomIn.Click += OnZoomIn;
            //
            // menuZoomOut
            //
            menuZoomOut.Name = "menuZoomOut";
            menuZoomOut.ShortcutKeyDisplayString = "Ctrl+-";
            menuZoomOut.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus;
            menuZoomOut.Text = "Уменьшить шрифт";
            menuZoomOut.Click += OnZoomOut;
            //
            // menuZoomReset
            //
            menuZoomReset.Name = "menuZoomReset";
            menuZoomReset.ShortcutKeyDisplayString = "Ctrl+0";
            menuZoomReset.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0;
            menuZoomReset.Text = "Исходный размер шрифта";
            menuZoomReset.Click += OnZoomReset;
            //
            // menuWordWrap
            //
            menuWordWrap.CheckOnClick = true;
            menuWordWrap.Name = "menuWordWrap";
            menuWordWrap.Text = "Перенос строк";
            menuWordWrap.Click += OnToggleWordWrap;
            //
            // menuLineNumbers
            //
            menuLineNumbers.Checked = true;
            menuLineNumbers.CheckOnClick = true;
            menuLineNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            menuLineNumbers.Name = "menuLineNumbers";
            menuLineNumbers.Text = "Номера строк";
            menuLineNumbers.Click += OnToggleLineNumbers;
            //
            // menuClearOutput
            //
            menuClearOutput.Name = "menuClearOutput";
            menuClearOutput.Text = "Очистить результаты";
            menuClearOutput.Click += OnClearOutput;
            //
            // menuHelp
            //
            menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuHelpContents, menuAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Text = "&Справка";
            //
            // menuHelpContents
            //
            menuHelpContents.Image = global::LangProcessor.Properties.Resources.icon_help;
            menuHelpContents.Name = "menuHelpContents";
            menuHelpContents.ShortcutKeys = System.Windows.Forms.Keys.F1;
            menuHelpContents.Text = "&Вызов справки";
            menuHelpContents.Click += OnHelp;
            //
            // menuAbout
            //
            menuAbout.Image = global::LangProcessor.Properties.Resources.icon_about;
            menuAbout.Name = "menuAbout";
            menuAbout.Text = "&О программе";
            menuAbout.Click += OnAbout;
            //
            // toolStrip
            //
            toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnNew, btnOpen, btnSave, btnSaveAs, toolSep1, btnUndo, btnRedo, toolSep2, btnCopy, btnCut, btnPaste, btnDelete, btnSelectAll, toolSep3, btnRun, toolSep4, btnHelp, btnAbout, toolSep5, btnExit, toolSep6, lblFontSize, cmbFontSize });
            toolStrip.Location = new System.Drawing.Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            toolStrip.Size = new System.Drawing.Size(1100, 35);
            toolStrip.TabIndex = 1;
            //
            // btnNew
            //
            btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnNew.Image = global::LangProcessor.Properties.Resources.icon_new;
            btnNew.Name = "btnNew";
            btnNew.Text = "Создать";
            btnNew.ToolTipText = "Создать (Ctrl+N)";
            btnNew.Click += OnNew;
            //
            // btnOpen
            //
            btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnOpen.Image = global::LangProcessor.Properties.Resources.icon_open;
            btnOpen.Name = "btnOpen";
            btnOpen.Text = "Открыть";
            btnOpen.ToolTipText = "Открыть (Ctrl+O)";
            btnOpen.Click += OnOpen;
            //
            // btnSave
            //
            btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSave.Image = global::LangProcessor.Properties.Resources.icon_save;
            btnSave.Name = "btnSave";
            btnSave.Text = "Сохранить";
            btnSave.ToolTipText = "Сохранить (Ctrl+S)";
            btnSave.Click += OnSave;
            //
            // btnSaveAs
            //
            btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSaveAs.Image = global::LangProcessor.Properties.Resources.icon_save_as;
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Text = "Сохранить как";
            btnSaveAs.ToolTipText = "Сохранить как (Ctrl+Shift+S)";
            btnSaveAs.Click += OnSaveAs;
            //
            // btnUndo
            //
            btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnUndo.Image = global::LangProcessor.Properties.Resources.icon_undo;
            btnUndo.Name = "btnUndo";
            btnUndo.Text = "Отменить";
            btnUndo.ToolTipText = "Отменить (Ctrl+Z)";
            btnUndo.Click += OnUndo;
            //
            // btnRedo
            //
            btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRedo.Image = global::LangProcessor.Properties.Resources.icon_redo;
            btnRedo.Name = "btnRedo";
            btnRedo.Text = "Повторить";
            btnRedo.ToolTipText = "Повторить (Ctrl+Y)";
            btnRedo.Click += OnRedo;
            //
            // btnCopy
            //
            btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnCopy.Image = global::LangProcessor.Properties.Resources.icon_copy;
            btnCopy.Name = "btnCopy";
            btnCopy.Text = "Копировать";
            btnCopy.ToolTipText = "Копировать (Ctrl+C)";
            btnCopy.Click += OnCopy;
            //
            // btnCut
            //
            btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnCut.Image = global::LangProcessor.Properties.Resources.icon_cut;
            btnCut.Name = "btnCut";
            btnCut.Text = "Вырезать";
            btnCut.ToolTipText = "Вырезать (Ctrl+X)";
            btnCut.Click += OnCut;
            //
            // btnPaste
            //
            btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnPaste.Image = global::LangProcessor.Properties.Resources.icon_paste;
            btnPaste.Name = "btnPaste";
            btnPaste.Text = "Вставить";
            btnPaste.ToolTipText = "Вставить (Ctrl+V)";
            btnPaste.Click += OnPaste;
            //
            // btnDelete
            //
            btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnDelete.Image = global::LangProcessor.Properties.Resources.icon_delete;
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Удалить";
            btnDelete.ToolTipText = "Удалить (Del)";
            btnDelete.Click += OnDelete;
            //
            // btnSelectAll
            //
            btnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSelectAll.Image = global::LangProcessor.Properties.Resources.icon_select_all;
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Text = "Выделить всё";
            btnSelectAll.ToolTipText = "Выделить всё (Ctrl+A)";
            btnSelectAll.Click += OnSelectAll;
            //
            // btnRun
            //
            btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRun.Image = global::LangProcessor.Properties.Resources.icon_run;
            btnRun.Name = "btnRun";
            btnRun.Text = "Пуск";
            btnRun.ToolTipText = "Пуск — запуск анализатора (F5)";
            btnRun.Click += OnRun;
            //
            // btnHelp
            //
            btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnHelp.Image = global::LangProcessor.Properties.Resources.icon_help;
            btnHelp.Name = "btnHelp";
            btnHelp.Text = "Справка";
            btnHelp.ToolTipText = "Вызов справки (F1)";
            btnHelp.Click += OnHelp;
            //
            // btnAbout
            //
            btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnAbout.Image = global::LangProcessor.Properties.Resources.icon_about;
            btnAbout.Name = "btnAbout";
            btnAbout.Text = "О программе";
            btnAbout.ToolTipText = "О программе";
            btnAbout.Click += OnAbout;
            //
            // btnExit
            //
            btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnExit.Image = global::LangProcessor.Properties.Resources.icon_exit;
            btnExit.Name = "btnExit";
            btnExit.Text = "Выход";
            btnExit.ToolTipText = "Выход (Alt+F4)";
            btnExit.Click += OnExit;
            //
            // lblFontSize
            //
            lblFontSize.Name = "lblFontSize";
            lblFontSize.Text = "Размер шрифта:";
            //
            // cmbFontSize
            //
            cmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFontSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "24", "28" });
            cmbFontSize.Name = "cmbFontSize";
            cmbFontSize.Size = new System.Drawing.Size(60, 28);
            cmbFontSize.ToolTipText = "Размер шрифта редактора и области вывода";
            cmbFontSize.SelectedIndexChanged += OnFontSizeSelected;
            //
            // statusStrip
            //
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusText, statusPosition, statusLength, statusEncoding });
            statusStrip.Location = new System.Drawing.Point(0, 698);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(1100, 26);
            statusStrip.TabIndex = 3;
            //
            // statusText
            //
            statusText.Name = "statusText";
            statusText.Spring = true;
            statusText.Text = "Готово";
            statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // statusPosition
            //
            statusPosition.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            statusPosition.Name = "statusPosition";
            statusPosition.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            statusPosition.Text = "Стр 1, Стлб 1";
            //
            // statusLength
            //
            statusLength.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            statusLength.Name = "statusLength";
            statusLength.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            statusLength.Text = "Строк: 1   Символов: 0";
            //
            // statusEncoding
            //
            statusEncoding.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            statusEncoding.Name = "statusEncoding";
            statusEncoding.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            statusEncoding.Text = "UTF-8";
            //
            // splitContainer
            //
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 65);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer.Panel1
            //
            splitContainer.Panel1.Controls.Add(codeEditor);
            splitContainer.Panel1MinSize = 100;
            //
            // splitContainer.Panel2
            //
            splitContainer.Panel2.Controls.Add(outputTabs);
            splitContainer.Panel2MinSize = 80;
            splitContainer.Size = new System.Drawing.Size(1100, 633);
            splitContainer.SplitterDistance = 420;
            splitContainer.SplitterWidth = 6;
            splitContainer.TabIndex = 2;
            //
            // codeEditor
            //
            codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            codeEditor.Font = new System.Drawing.Font("Consolas", 11F);
            codeEditor.Location = new System.Drawing.Point(0, 0);
            codeEditor.Name = "codeEditor";
            codeEditor.Size = new System.Drawing.Size(1100, 420);
            codeEditor.TabIndex = 0;
            codeEditor.Text = "";
            codeEditor.SelectionChanged += OnEditorSelectionChanged;
            codeEditor.TextChanged += OnEditorTextChanged;
            //
            // outputGrid
            //
            outputGrid.AllowUserToAddRows = false;
            outputGrid.AllowUserToDeleteRows = false;
            outputGrid.AllowUserToResizeRows = false;
            outputGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            outputGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            outputGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.SystemColors.Control;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            outputGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            outputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outputGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colNumber, colLine, colColumn, colCode, colMessage });
            outputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            outputGrid.EnableHeadersVisualStyles = false;
            outputGrid.Location = new System.Drawing.Point(0, 0);
            outputGrid.MultiSelect = false;
            outputGrid.Name = "outputGrid";
            outputGrid.ReadOnly = true;
            outputGrid.RowHeadersVisible = false;
            outputGrid.RowTemplate.Height = 24;
            outputGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            outputGrid.ShowCellToolTips = false;
            outputGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            outputGrid.Size = new System.Drawing.Size(1100, 183);
            outputGrid.TabIndex = 1;
            outputGrid.CellClick += OnOutputCellClick;
            outputGrid.KeyDown += OnOutputKeyDown;
            //
            // colNumber
            //
            colNumber.HeaderText = "№";
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colNumber.Width = 50;
            //
            // colLine
            //
            colLine.HeaderText = "Строка";
            colLine.Name = "colLine";
            colLine.ReadOnly = true;
            colLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colLine.Width = 70;
            //
            // colColumn
            //
            colColumn.HeaderText = "Столбец";
            colColumn.Name = "colColumn";
            colColumn.ReadOnly = true;
            colColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colColumn.Width = 75;
            //
            // colCode
            //
            colCode.HeaderText = "Код";
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            colCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colCode.Width = 80;
            //
            // colMessage
            //
            colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colMessage.HeaderText = "Сообщение";
            colMessage.MinimumWidth = 400;
            colMessage.Name = "colMessage";
            colMessage.ReadOnly = true;
            colMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // outputTabs
            //
            outputTabs.Controls.Add(tabErrors);
            outputTabs.Controls.Add(tabOutput);
            outputTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            outputTabs.Location = new System.Drawing.Point(0, 0);
            outputTabs.Name = "outputTabs";
            outputTabs.SelectedIndex = 0;
            outputTabs.Size = new System.Drawing.Size(1100, 207);
            outputTabs.TabIndex = 0;
            //
            // tabErrors
            //
            tabErrors.Controls.Add(outputGrid);
            tabErrors.Location = new System.Drawing.Point(4, 24);
            tabErrors.Name = "tabErrors";
            tabErrors.Size = new System.Drawing.Size(1092, 179);
            tabErrors.TabIndex = 0;
            tabErrors.Text = "Ошибки";
            tabErrors.UseVisualStyleBackColor = true;
            //
            // tabOutput
            //
            tabOutput.Controls.Add(outputText);
            tabOutput.Location = new System.Drawing.Point(4, 24);
            tabOutput.Name = "tabOutput";
            tabOutput.Size = new System.Drawing.Size(1092, 179);
            tabOutput.TabIndex = 1;
            tabOutput.Text = "Вывод программы";
            tabOutput.UseVisualStyleBackColor = true;
            //
            // outputText
            //
            outputText.BackColor = System.Drawing.SystemColors.Window;
            outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            outputText.Font = new System.Drawing.Font("Consolas", 10.5F);
            outputText.Location = new System.Drawing.Point(0, 0);
            outputText.Name = "outputText";
            outputText.ReadOnly = true;
            outputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            outputText.Size = new System.Drawing.Size(1092, 179);
            outputText.TabIndex = 0;
            outputText.Text = "";
            outputText.WordWrap = false;
            //
            // MainForm
            //
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1100, 724);
            Controls.Add(splitContainer);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Controls.Add(statusStrip);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            MinimumSize = new System.Drawing.Size(640, 420);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Языковой процессор";
            FormClosing += OnFormClosing;
            DragDrop += OnDragDrop;
            DragEnter += OnDragEnter;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)outputGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator menuFileSep1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripSeparator menuEditSep1;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripSeparator menuEditSep2;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuText;
        private System.Windows.Forms.ToolStripMenuItem menuTextTask;
        private System.Windows.Forms.ToolStripMenuItem menuTextGrammar;
        private System.Windows.Forms.ToolStripMenuItem menuTextClassification;
        private System.Windows.Forms.ToolStripMenuItem menuTextMethod;
        private System.Windows.Forms.ToolStripMenuItem menuTextExample;
        private System.Windows.Forms.ToolStripMenuItem menuTextLiterature;
        private System.Windows.Forms.ToolStripMenuItem menuTextSource;
        private System.Windows.Forms.ToolStripMenuItem menuRun;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuZoomIn;
        private System.Windows.Forms.ToolStripMenuItem menuZoomOut;
        private System.Windows.Forms.ToolStripMenuItem menuZoomReset;
        private System.Windows.Forms.ToolStripSeparator menuViewSep1;
        private System.Windows.Forms.ToolStripMenuItem menuWordWrap;
        private System.Windows.Forms.ToolStripMenuItem menuLineNumbers;
        private System.Windows.Forms.ToolStripSeparator menuViewSep2;
        private System.Windows.Forms.ToolStripMenuItem menuClearOutput;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpContents;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolSep1;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolSep2;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolSep3;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripSeparator toolSep4;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolSep5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolSep6;
        private System.Windows.Forms.ToolStripLabel lblFontSize;
        private System.Windows.Forms.ToolStripComboBox cmbFontSize;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusPosition;
        private System.Windows.Forms.ToolStripStatusLabel statusLength;
        private System.Windows.Forms.ToolStripStatusLabel statusEncoding;
        private System.Windows.Forms.SplitContainer splitContainer;
        private LangProcessor.CodeEditor codeEditor;
        private System.Windows.Forms.DataGridView outputGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.TabControl outputTabs;
        private System.Windows.Forms.TabPage tabErrors;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.RichTextBox outputText;
    }
}
