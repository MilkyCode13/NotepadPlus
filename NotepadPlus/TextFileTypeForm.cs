using System;
using System.Windows.Forms;

namespace NotepadPlus
{
    /// <summary>
    /// The text file type selection form.
    /// </summary>
    internal sealed partial class TextFileTypeForm : Form
    {
        /// <summary>
        /// Constructs the form.
        /// </summary>
        public TextFileTypeForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// The text file type selected.
        /// </summary>
        public TextFileType? TextFileType { get; private set; }

        /// <summary>
        /// Handles a form Paint event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void TextFileTypeForm_Paint(object sender, PaintEventArgs e)
        {
            Theme.ApplyCurrentTheme(this);
        }

        /// <summary>
        /// Handles a Rich text button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void richTextButton_Click(object sender, EventArgs e)
        {
            TextFileType = NotepadPlus.TextFileType.RichTextFile;
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles a Plain text button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void plainTextButton_Click(object sender, EventArgs e)
        {
            TextFileType = NotepadPlus.TextFileType.PlainTextFile;
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles a Source code button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void sourceCodeButton_Click(object sender, EventArgs e)
        {
            TextFileType = NotepadPlus.TextFileType.SourceCodeFile;
            DialogResult = DialogResult.OK;
        }
    }
}
