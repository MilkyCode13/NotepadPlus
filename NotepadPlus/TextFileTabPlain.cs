using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace NotepadPlus
{
    /// <summary>
    /// Represents a tab with plain text.
    /// </summary>
    internal class TextFileTabPlain : TextFileTab
    {
        /// <summary>
        /// Constructs a tab.
        /// </summary>
        /// <param name="contextMenuStrip">The <see cref="ContextMenuStrip"/> instance.</param>
        public TextFileTabPlain(ContextMenuStrip contextMenuStrip)
        {
            TextBox = new FastColoredTextBox();
            TextBox.Dock = DockStyle.Fill;
            TextBox.Font = new Font("Consolas", 11);
            TextBox.ContextMenuStrip = contextMenuStrip;
            TextBox.TextChanged += TextBox_TextChanged;
            TextBox.SelectionChanged += TextBox_SelectionChanged;
            Controls.Add(TextBox);
        }
        
        /// <summary>
        /// Gets whether the tab can undo an operation.
        /// </summary>
        public override bool CanUndo => TextBox.UndoEnabled;
        
        /// <summary>
        /// Gets whether the tab can redo an operation.
        /// </summary>
        public override bool CanRedo => TextBox.RedoEnabled;

        /// <summary>
        /// Gets whether the tab can copy selected text.
        /// </summary>
        public override bool CanCopy => TextBox.SelectionLength > 0;
        
        /// <summary>
        /// Gets the text box.
        /// </summary>
        protected FastColoredTextBox TextBox { get; }

        /// <summary>
        /// Gets the default file extension.
        /// </summary>
        protected override string DefaultFileExtension => "txt";

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
        public override void Delete() => TextBox.ClearSelected();

        /// <summary>
        /// Selects all text.
        /// </summary>
        public override void SelectAll() => TextBox.SelectAll();

        /// <summary>
        /// Applies the theme to the tab.
        /// </summary>
        /// <param name="backColor">Background color.</param>
        /// <param name="textBoxBackColor">Text box background color.</param>
        /// <param name="foreColor">Foreground color.</param>
        public override void ApplyTheme(Color backColor, Color textBoxBackColor, Color foreColor)
        {
            TextBox.BackColor = textBoxBackColor;
            TextBox.ForeColor = foreColor;
            TextBox.IndentBackColor = backColor;
            TextBox.LineNumberColor = foreColor;
            TextBox.CaretColor = foreColor;
        }
        
        /// <summary>
        /// Loads file to box.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        protected override void LoadFileToBox(string fileName)
        {
            TextBox.OpenFile(fileName);
        }

        /// <summary>
        /// Saves text to file.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        protected override void SaveToFile(string fileName)
        {
            TextBox.SaveToFile(fileName, Encoding.Default);
        }
    }
}