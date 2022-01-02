
namespace NotepadPlus
{
    partial class TextFileTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFileTypeForm));
            this.richTextButton = new System.Windows.Forms.Button();
            this.plainTextButton = new System.Windows.Forms.Button();
            this.sourceCodeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextButton
            // 
            resources.ApplyResources(this.richTextButton, "richTextButton");
            this.richTextButton.Image = global::NotepadPlus.Properties.Resources.RichTextBox_128x;
            this.richTextButton.Name = "richTextButton";
            this.richTextButton.UseVisualStyleBackColor = true;
            this.richTextButton.Click += new System.EventHandler(this.richTextButton_Click);
            // 
            // plainTextButton
            // 
            this.plainTextButton.Image = global::NotepadPlus.Properties.Resources.Text_128x;
            resources.ApplyResources(this.plainTextButton, "plainTextButton");
            this.plainTextButton.Name = "plainTextButton";
            this.plainTextButton.UseVisualStyleBackColor = true;
            this.plainTextButton.Click += new System.EventHandler(this.plainTextButton_Click);
            // 
            // sourceCodeButton
            // 
            this.sourceCodeButton.Image = global::NotepadPlus.Properties.Resources.CodeEdit_128x;
            resources.ApplyResources(this.sourceCodeButton, "sourceCodeButton");
            this.sourceCodeButton.Name = "sourceCodeButton";
            this.sourceCodeButton.UseVisualStyleBackColor = true;
            this.sourceCodeButton.Click += new System.EventHandler(this.sourceCodeButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // TextFileTypeForm
            // 
            this.AcceptButton = this.richTextButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sourceCodeButton);
            this.Controls.Add(this.plainTextButton);
            this.Controls.Add(this.richTextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TextFileTypeForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TextFileTypeForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button richTextButton;
        private System.Windows.Forms.Button plainTextButton;
        private System.Windows.Forms.Button sourceCodeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}