using System.Drawing;
using System.Windows.Forms;

namespace NotepadPlus
{
    /// <summary>
    /// Represents a tab with rich text.
    /// </summary>
    internal sealed class TextFileTabRich : TextFileTab
    {
        /// <summary>
        /// Constructs a tab.
        /// </summary>
        /// <param name="contextMenuStrip">The <see cref="ContextMenuStrip"/> instance.</param>
        public TextFileTabRich(ContextMenuStrip contextMenuStrip)
        {
            TextBox = new RichTextBox();
            TextBox.Dock = DockStyle.Fill;
            TextBox.ContextMenuStrip = contextMenuStrip;
            TextBox.TextChanged += TextBox_TextChanged;
            TextBox.SelectionChanged += TextBox_SelectionChanged;
            Controls.Add(TextBox);
        }
        
        /// <summary>
        /// Text box selection font style.
        /// </summary>
        public Font? SelectionFont
        {
            get => TextBox.SelectionFont;
            set => TextBox.SelectionFont = value;
        }

        /// <summary>
        /// Text box selection font color.
        /// </summary>
        public Color SelectionColor
        {
            get => TextBox.SelectionColor;
            set => TextBox.SelectionColor = value;
        }
        
        /// <summary>
        /// Gets whether the tab can undo an operation.
        /// </summary>
        public override bool CanUndo => TextBox.CanUndo;
        
        /// <summary>
        /// Gets whether the tab can redo an operation.
        /// </summary>
        public override bool CanRedo => TextBox.CanRedo;

        /// <summary>
        /// Gets whether the tab can copy selected text.
        /// </summary>
        public override bool CanCopy => TextBox.SelectionLength > 0;
        
        /// <summary>
        /// Gets the default file extension.
        /// </summary>
        protected override string DefaultFileExtension => "rtf";
        
        /// <summary>
        /// Gets the text box.
        /// </summary>
        private RichTextBox TextBox { get; }
        
        /// <summary>
        /// Sets the text style.
        /// </summary>
        /// <param name="addStyle">The style to add or remove.</param>
        /// <param name="checkState">The state whether to add or remove style.</param>
        public void SetTextStyle(FontStyle addStyle, CheckState checkState)
        {
            FontStyle style = checkState switch
            {
                CheckState.Checked => TextBox.SelectionFont.Style | addStyle,
                CheckState.Unchecked => TextBox.SelectionFont.Style & ~addStyle,
                _ => TextBox.SelectionFont.Style
            };
            TextBox.SelectionFont = new Font(TextBox.SelectionFont, style);
        }

        /// <summary>
        /// Undoes the last operation.
        /// </summary>
        public override void Undo() => TextBox.Undo();

        /// <summary>
        /// Redoes the last operation undone.
        /// </summary>
        public override void Redo() => TextBox.Redo();

        /// <summary>
        /// Cuts the selected text to the Clipboard.
        /// </summary>
        public override void Cut() => TextBox.Cut();

        /// <summary>
        /// Copies the selected text to the Clipboard.
        /// </summary>
        public override void Copy() => TextBox.Copy();

        /// <summary>
        /// Pastes the text from the Clipboard.
        /// </summary>
        public override void Paste() => TextBox.Paste();

        /// <summary>
        /// Deletes the selected text.
        /// </summary>
        public override void Delete()
        {
            TextBox.SelectedText = string.Empty;
        }

        /// <summary>
        /// Selects all text.
        /// </summary>
        public override void SelectAll() => TextBox.SelectAll();

        /// <summary>
        /// Loads file to box.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        protected override void LoadFileToBox(string fileName)
        {
            TextBox.LoadFile(fileName, RichTextBoxStreamType.RichText);
        }

        /// <summary>
        /// Saves text to file.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        protected override void SaveToFile(string fileName)
        {
            TextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
        }
    }
}