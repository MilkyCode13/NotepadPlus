
namespace NotepadPlus
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.autoSaveFrequencyLabel = new System.Windows.Forms.Label();
            this.autoSaveFrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.enableAutoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.autoSaveSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.themeSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.darkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.lightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.journalingSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.journalingFrequencyLabel = new System.Windows.Forms.Label();
            this.journalingFrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.enableJournalingCheckBox = new System.Windows.Forms.CheckBox();
            this.selectCompilerPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.syntaxColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.resetSyntaxColorsButton = new System.Windows.Forms.Button();
            this.selectedSyntaxColorLabel = new System.Windows.Forms.Label();
            this.selectSyntaxColorButton = new System.Windows.Forms.Button();
            this.syntaxColorPanel = new System.Windows.Forms.Panel();
            this.syntaxItemListBox = new System.Windows.Forms.ListBox();
            this.syntaxHighlighingColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.autoSaveFrequencyTrackBar)).BeginInit();
            this.autoSaveSettingsGroupBox.SuspendLayout();
            this.themeSettingsGroupBox.SuspendLayout();
            this.journalingSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalingFrequencyTrackBar)).BeginInit();
            this.syntaxColorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoSaveFrequencyLabel
            // 
            resources.ApplyResources(this.autoSaveFrequencyLabel, "autoSaveFrequencyLabel");
            this.autoSaveFrequencyLabel.Name = "autoSaveFrequencyLabel";
            // 
            // autoSaveFrequencyTrackBar
            // 
            this.autoSaveFrequencyTrackBar.LargeChange = 2;
            resources.ApplyResources(this.autoSaveFrequencyTrackBar, "autoSaveFrequencyTrackBar");
            this.autoSaveFrequencyTrackBar.Minimum = 1;
            this.autoSaveFrequencyTrackBar.Name = "autoSaveFrequencyTrackBar";
            this.autoSaveFrequencyTrackBar.Value = 1;
            this.autoSaveFrequencyTrackBar.Scroll += new System.EventHandler(this.autoSaveFrequencyTrackBar_Scroll);
            // 
            // enableAutoSaveCheckBox
            // 
            resources.ApplyResources(this.enableAutoSaveCheckBox, "enableAutoSaveCheckBox");
            this.enableAutoSaveCheckBox.Name = "enableAutoSaveCheckBox";
            this.enableAutoSaveCheckBox.UseVisualStyleBackColor = true;
            this.enableAutoSaveCheckBox.CheckedChanged += new System.EventHandler(this.enableAutoSaveCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // autoSaveSettingsGroupBox
            // 
            this.autoSaveSettingsGroupBox.Controls.Add(this.autoSaveFrequencyLabel);
            this.autoSaveSettingsGroupBox.Controls.Add(this.autoSaveFrequencyTrackBar);
            this.autoSaveSettingsGroupBox.Controls.Add(this.enableAutoSaveCheckBox);
            resources.ApplyResources(this.autoSaveSettingsGroupBox, "autoSaveSettingsGroupBox");
            this.autoSaveSettingsGroupBox.Name = "autoSaveSettingsGroupBox";
            this.autoSaveSettingsGroupBox.TabStop = false;
            // 
            // themeSettingsGroupBox
            // 
            this.themeSettingsGroupBox.Controls.Add(this.darkThemeRadioButton);
            this.themeSettingsGroupBox.Controls.Add(this.lightThemeRadioButton);
            resources.ApplyResources(this.themeSettingsGroupBox, "themeSettingsGroupBox");
            this.themeSettingsGroupBox.Name = "themeSettingsGroupBox";
            this.themeSettingsGroupBox.TabStop = false;
            // 
            // darkThemeRadioButton
            // 
            resources.ApplyResources(this.darkThemeRadioButton, "darkThemeRadioButton");
            this.darkThemeRadioButton.Name = "darkThemeRadioButton";
            this.darkThemeRadioButton.TabStop = true;
            this.darkThemeRadioButton.UseVisualStyleBackColor = true;
            this.darkThemeRadioButton.CheckedChanged += new System.EventHandler(this.themeRadioButton_CheckedChanged);
            // 
            // lightThemeRadioButton
            // 
            resources.ApplyResources(this.lightThemeRadioButton, "lightThemeRadioButton");
            this.lightThemeRadioButton.Name = "lightThemeRadioButton";
            this.lightThemeRadioButton.TabStop = true;
            this.lightThemeRadioButton.UseVisualStyleBackColor = true;
            this.lightThemeRadioButton.CheckedChanged += new System.EventHandler(this.themeRadioButton_CheckedChanged);
            // 
            // journalingSettingsGroupBox
            // 
            this.journalingSettingsGroupBox.Controls.Add(this.journalingFrequencyLabel);
            this.journalingSettingsGroupBox.Controls.Add(this.journalingFrequencyTrackBar);
            this.journalingSettingsGroupBox.Controls.Add(this.enableJournalingCheckBox);
            resources.ApplyResources(this.journalingSettingsGroupBox, "journalingSettingsGroupBox");
            this.journalingSettingsGroupBox.Name = "journalingSettingsGroupBox";
            this.journalingSettingsGroupBox.TabStop = false;
            // 
            // journalingFrequencyLabel
            // 
            resources.ApplyResources(this.journalingFrequencyLabel, "journalingFrequencyLabel");
            this.journalingFrequencyLabel.Name = "journalingFrequencyLabel";
            // 
            // journalingFrequencyTrackBar
            // 
            this.journalingFrequencyTrackBar.LargeChange = 2;
            resources.ApplyResources(this.journalingFrequencyTrackBar, "journalingFrequencyTrackBar");
            this.journalingFrequencyTrackBar.Maximum = 6;
            this.journalingFrequencyTrackBar.Minimum = 1;
            this.journalingFrequencyTrackBar.Name = "journalingFrequencyTrackBar";
            this.journalingFrequencyTrackBar.Value = 5;
            this.journalingFrequencyTrackBar.Scroll += new System.EventHandler(this.journalingFrequencyTrackBar_Scroll);
            // 
            // enableJournalingCheckBox
            // 
            resources.ApplyResources(this.enableJournalingCheckBox, "enableJournalingCheckBox");
            this.enableJournalingCheckBox.Name = "enableJournalingCheckBox";
            this.enableJournalingCheckBox.UseVisualStyleBackColor = true;
            this.enableJournalingCheckBox.CheckedChanged += new System.EventHandler(this.enableJournalingCheckBox_CheckedChanged);
            // 
            // syntaxColorsGroupBox
            // 
            this.syntaxColorsGroupBox.Controls.Add(this.resetSyntaxColorsButton);
            this.syntaxColorsGroupBox.Controls.Add(this.selectedSyntaxColorLabel);
            this.syntaxColorsGroupBox.Controls.Add(this.selectSyntaxColorButton);
            this.syntaxColorsGroupBox.Controls.Add(this.syntaxColorPanel);
            this.syntaxColorsGroupBox.Controls.Add(this.syntaxItemListBox);
            resources.ApplyResources(this.syntaxColorsGroupBox, "syntaxColorsGroupBox");
            this.syntaxColorsGroupBox.Name = "syntaxColorsGroupBox";
            this.syntaxColorsGroupBox.TabStop = false;
            // 
            // resetSyntaxColorsButton
            // 
            resources.ApplyResources(this.resetSyntaxColorsButton, "resetSyntaxColorsButton");
            this.resetSyntaxColorsButton.Name = "resetSyntaxColorsButton";
            this.resetSyntaxColorsButton.UseVisualStyleBackColor = true;
            this.resetSyntaxColorsButton.Click += new System.EventHandler(this.resetSyntaxColorsButton_Click);
            // 
            // selectedSyntaxColorLabel
            // 
            resources.ApplyResources(this.selectedSyntaxColorLabel, "selectedSyntaxColorLabel");
            this.selectedSyntaxColorLabel.Name = "selectedSyntaxColorLabel";
            // 
            // selectSyntaxColorButton
            // 
            resources.ApplyResources(this.selectSyntaxColorButton, "selectSyntaxColorButton");
            this.selectSyntaxColorButton.Name = "selectSyntaxColorButton";
            this.selectSyntaxColorButton.UseVisualStyleBackColor = true;
            this.selectSyntaxColorButton.Click += new System.EventHandler(this.selectSyntaxColorButton_Click);
            // 
            // syntaxColorPanel
            // 
            resources.ApplyResources(this.syntaxColorPanel, "syntaxColorPanel");
            this.syntaxColorPanel.Name = "syntaxColorPanel";
            // 
            // syntaxItemListBox
            // 
            this.syntaxItemListBox.FormattingEnabled = true;
            resources.ApplyResources(this.syntaxItemListBox, "syntaxItemListBox");
            this.syntaxItemListBox.Items.AddRange(new object[] {
            resources.GetString("syntaxItemListBox.Items"),
            resources.GetString("syntaxItemListBox.Items1"),
            resources.GetString("syntaxItemListBox.Items2"),
            resources.GetString("syntaxItemListBox.Items3"),
            resources.GetString("syntaxItemListBox.Items4"),
            resources.GetString("syntaxItemListBox.Items5"),
            resources.GetString("syntaxItemListBox.Items6"),
            resources.GetString("syntaxItemListBox.Items7")});
            this.syntaxItemListBox.Name = "syntaxItemListBox";
            this.syntaxItemListBox.SelectedIndexChanged += new System.EventHandler(this.syntaxItemListBox_SelectedIndexChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.syntaxColorsGroupBox);
            this.Controls.Add(this.journalingSettingsGroupBox);
            this.Controls.Add(this.themeSettingsGroupBox);
            this.Controls.Add(this.autoSaveSettingsGroupBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.autoSaveFrequencyTrackBar)).EndInit();
            this.autoSaveSettingsGroupBox.ResumeLayout(false);
            this.autoSaveSettingsGroupBox.PerformLayout();
            this.themeSettingsGroupBox.ResumeLayout(false);
            this.themeSettingsGroupBox.PerformLayout();
            this.journalingSettingsGroupBox.ResumeLayout(false);
            this.journalingSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalingFrequencyTrackBar)).EndInit();
            this.syntaxColorsGroupBox.ResumeLayout(false);
            this.syntaxColorsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar autoSaveFrequencyTrackBar;
        private System.Windows.Forms.CheckBox enableAutoSaveCheckBox;
        private System.Windows.Forms.Label autoSaveFrequencyLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox autoSaveSettingsGroupBox;
        private System.Windows.Forms.GroupBox themeSettingsGroupBox;
        private System.Windows.Forms.RadioButton darkThemeRadioButton;
        private System.Windows.Forms.RadioButton lightThemeRadioButton;
        private System.Windows.Forms.GroupBox journalingSettingsGroupBox;
        private System.Windows.Forms.Label journalingFrequencyLabel;
        private System.Windows.Forms.TrackBar journalingFrequencyTrackBar;
        private System.Windows.Forms.CheckBox enableJournalingCheckBox;
        private System.Windows.Forms.OpenFileDialog selectCompilerPathDialog;
        private System.Windows.Forms.GroupBox syntaxColorsGroupBox;
        private System.Windows.Forms.Label selectedSyntaxColorLabel;
        private System.Windows.Forms.Button selectSyntaxColorButton;
        private System.Windows.Forms.Panel syntaxColorPanel;
        private System.Windows.Forms.ListBox syntaxItemListBox;
        private System.Windows.Forms.ColorDialog syntaxHighlighingColorDialog;
        private System.Windows.Forms.Button resetSyntaxColorsButton;
    }
}