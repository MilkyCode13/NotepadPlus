
namespace NotepadPlus
{
    internal partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.closeTabToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newTabToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.buildToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.codeFormatToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTextFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.formatToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.textFontDialog = new System.Windows.Forms.FontDialog();
            this.journalingTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.textBoxContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.NewFile_16x;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.NewWindow_16x;
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            resources.ApplyResources(this.newWindowToolStripMenuItem, "newWindowToolStripMenuItem");
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.OpenFile_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Save_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.SaveAs_16x;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.SaveAll_16x;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            resources.ApplyResources(this.saveAllToolStripMenuItem, "saveAllToolStripMenuItem");
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Close_red_16x;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Undo_16x;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Redo_16x;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Cut_16x;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Copy_16x;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Paste_16x;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Close_red_16x;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.SelectAll_16x;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikethroughToolStripMenuItem,
            this.toolStripSeparator6,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            resources.ApplyResources(this.formatToolStripMenuItem, "formatToolStripMenuItem");
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.CheckOnClick = true;
            this.italicToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Italic_16x;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            resources.ApplyResources(this.italicToolStripMenuItem, "italicToolStripMenuItem");
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.CheckOnClick = true;
            this.boldToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Bold_16x;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            resources.ApplyResources(this.boldToolStripMenuItem, "boldToolStripMenuItem");
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.CheckOnClick = true;
            this.underlineToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Underline_16x;
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            resources.ApplyResources(this.underlineToolStripMenuItem, "underlineToolStripMenuItem");
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikethroughToolStripMenuItem
            // 
            this.strikethroughToolStripMenuItem.CheckOnClick = true;
            this.strikethroughToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.StrikeThrough_16x;
            this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            resources.ApplyResources(this.strikethroughToolStripMenuItem, "strikethroughToolStripMenuItem");
            this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.strikethroughToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::NotepadPlus.Properties.Resources.Font_16x;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            resources.ApplyResources(this.fontToolStripMenuItem, "fontToolStripMenuItem");
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripButton,
            this.newTabToolStripButton,
            this.toolStripSeparator10,
            this.buildToolStripButton,
            this.codeFormatToolStripButton});
            resources.ApplyResources(this.mainToolStrip, "mainToolStrip");
            this.mainToolStrip.Name = "mainToolStrip";
            // 
            // closeTabToolStripButton
            // 
            this.closeTabToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabToolStripButton.Image = global::NotepadPlus.Properties.Resources.Close_red_16x;
            resources.ApplyResources(this.closeTabToolStripButton, "closeTabToolStripButton");
            this.closeTabToolStripButton.Name = "closeTabToolStripButton";
            this.closeTabToolStripButton.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // newTabToolStripButton
            // 
            this.newTabToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTabToolStripButton.Image = global::NotepadPlus.Properties.Resources.NewFile_16x;
            resources.ApplyResources(this.newTabToolStripButton, "newTabToolStripButton");
            this.newTabToolStripButton.Name = "newTabToolStripButton";
            this.newTabToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // buildToolStripButton
            // 
            resources.ApplyResources(this.buildToolStripButton, "buildToolStripButton");
            this.buildToolStripButton.Image = global::NotepadPlus.Properties.Resources.Run_16x;
            this.buildToolStripButton.Name = "buildToolStripButton";
            this.buildToolStripButton.Click += new System.EventHandler(this.buildToolStripButton_Click);
            // 
            // codeFormatToolStripButton
            // 
            resources.ApplyResources(this.codeFormatToolStripButton, "codeFormatToolStripButton");
            this.codeFormatToolStripButton.Image = global::NotepadPlus.Properties.Resources.FormatDocument_16x;
            this.codeFormatToolStripButton.Name = "codeFormatToolStripButton";
            this.codeFormatToolStripButton.Click += new System.EventHandler(this.codeFormatToolStripButton_Click);
            // 
            // mainTabControl
            // 
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // openTextFileDialog
            // 
            resources.ApplyResources(this.openTextFileDialog, "openTextFileDialog");
            // 
            // saveTextFileDialog
            // 
            resources.ApplyResources(this.saveTextFileDialog, "saveTextFileDialog");
            // 
            // textBoxContextMenuStrip
            // 
            this.textBoxContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.textBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripContextMenuItem,
            this.copyToolStripContextMenuItem,
            this.pasteToolStripContextMenuItem,
            this.deleteToolStripContextMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripContextMenuItem,
            this.toolStripSeparator8,
            this.formatToolStripContextMenuItem});
            this.textBoxContextMenuStrip.Name = "textBoxContextMenuStrip";
            resources.ApplyResources(this.textBoxContextMenuStrip, "textBoxContextMenuStrip");
            this.textBoxContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.textBoxContextMenuStrip_Opening);
            // 
            // cutToolStripContextMenuItem
            // 
            this.cutToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Cut_16x;
            this.cutToolStripContextMenuItem.Name = "cutToolStripContextMenuItem";
            resources.ApplyResources(this.cutToolStripContextMenuItem, "cutToolStripContextMenuItem");
            this.cutToolStripContextMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripContextMenuItem
            // 
            this.copyToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Copy_16x;
            this.copyToolStripContextMenuItem.Name = "copyToolStripContextMenuItem";
            resources.ApplyResources(this.copyToolStripContextMenuItem, "copyToolStripContextMenuItem");
            this.copyToolStripContextMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripContextMenuItem
            // 
            this.pasteToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Paste_16x;
            this.pasteToolStripContextMenuItem.Name = "pasteToolStripContextMenuItem";
            resources.ApplyResources(this.pasteToolStripContextMenuItem, "pasteToolStripContextMenuItem");
            this.pasteToolStripContextMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripContextMenuItem
            // 
            this.deleteToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Close_red_16x;
            this.deleteToolStripContextMenuItem.Name = "deleteToolStripContextMenuItem";
            resources.ApplyResources(this.deleteToolStripContextMenuItem, "deleteToolStripContextMenuItem");
            this.deleteToolStripContextMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // selectAllToolStripContextMenuItem
            // 
            this.selectAllToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.SelectAll_16x;
            this.selectAllToolStripContextMenuItem.Name = "selectAllToolStripContextMenuItem";
            resources.ApplyResources(this.selectAllToolStripContextMenuItem, "selectAllToolStripContextMenuItem");
            this.selectAllToolStripContextMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // formatToolStripContextMenuItem
            // 
            this.formatToolStripContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicToolStripContextMenuItem,
            this.boldToolStripContextMenuItem,
            this.underlineToolStripContextMenuItem,
            this.strikethroughToolStripContextMenuItem,
            this.toolStripSeparator9,
            this.fontToolStripMenuItem1});
            this.formatToolStripContextMenuItem.Name = "formatToolStripContextMenuItem";
            resources.ApplyResources(this.formatToolStripContextMenuItem, "formatToolStripContextMenuItem");
            // 
            // italicToolStripContextMenuItem
            // 
            this.italicToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Italic_16x;
            this.italicToolStripContextMenuItem.Name = "italicToolStripContextMenuItem";
            resources.ApplyResources(this.italicToolStripContextMenuItem, "italicToolStripContextMenuItem");
            this.italicToolStripContextMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // boldToolStripContextMenuItem
            // 
            this.boldToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Bold_16x;
            this.boldToolStripContextMenuItem.Name = "boldToolStripContextMenuItem";
            resources.ApplyResources(this.boldToolStripContextMenuItem, "boldToolStripContextMenuItem");
            this.boldToolStripContextMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // underlineToolStripContextMenuItem
            // 
            this.underlineToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.Underline_16x;
            this.underlineToolStripContextMenuItem.Name = "underlineToolStripContextMenuItem";
            resources.ApplyResources(this.underlineToolStripContextMenuItem, "underlineToolStripContextMenuItem");
            this.underlineToolStripContextMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikethroughToolStripContextMenuItem
            // 
            this.strikethroughToolStripContextMenuItem.Image = global::NotepadPlus.Properties.Resources.StrikeThrough_16x;
            this.strikethroughToolStripContextMenuItem.Name = "strikethroughToolStripContextMenuItem";
            resources.ApplyResources(this.strikethroughToolStripContextMenuItem, "strikethroughToolStripContextMenuItem");
            this.strikethroughToolStripContextMenuItem.Click += new System.EventHandler(this.strikethroughToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Image = global::NotepadPlus.Properties.Resources.Font_16x;
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            resources.ApplyResources(this.fontToolStripMenuItem1, "fontToolStripMenuItem1");
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // autoSaveTimer
            // 
            this.autoSaveTimer.Tick += new System.EventHandler(this.autoSaveTimer_Tick);
            // 
            // textFontDialog
            // 
            this.textFontDialog.ShowColor = true;
            // 
            // journalingTimer
            // 
            this.journalingTimer.Tick += new System.EventHandler(this.journalingTimer_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.textBoxContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveTextFileDialog;
        private System.Windows.Forms.ContextMenuStrip textBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripContextMenuItem;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripButton closeTabToolStripButton;
        private System.Windows.Forms.ToolStripButton newTabToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FontDialog textFontDialog;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Timer journalingTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton buildToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton codeFormatToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

