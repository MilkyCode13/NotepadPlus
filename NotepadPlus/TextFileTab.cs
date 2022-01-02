using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NotepadPlus.Properties;

namespace NotepadPlus
{
    /// <summary>
    /// Represents a tab with text.
    /// </summary>
    internal abstract class TextFileTab : TabPage
    {
        /// <summary>
        /// The maximum file size supported.
        /// </summary>
        private const long MaxFileSize = 15 * 1024 * 1024;
        
        /// <summary>
        /// The <see cref="FileInfo"/> object corresponding to file loaded in the tab.
        /// </summary>
        private FileInfo? loadedFile;
        
        /// <summary>
        /// Whether the text has been changed.
        /// </summary>
        private bool isChanged;
        
        /// <summary>
        /// The tab title.
        /// </summary>
        private string title = "Untitled";

        /// <summary>
        /// Constructs the tab.
        /// </summary>
        protected TextFileTab()
        {
            Text = isChanged ? title + '*' : title;
        }
        
        /// <summary>
        /// Invoked when the selection of text changed.
        /// </summary>
        public event EventHandler? SelectionChanged;

        /// <summary>
        /// Gets or sets the text to display on the tab.
        /// </summary>
        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="FileInfo"/> object corresponding to file loaded in the tab.
        /// </summary>
        public FileInfo? LoadedFile
        {
            get => loadedFile;
            private set
            {
                loadedFile = value;
                Title = value == null ? "Untitled" : Path.GetFileName(value.Name);
                IsChanged = false;
            }
        }

        /// <summary>
        /// Gets or sets whether the text has been changed.
        /// </summary>
        public bool IsChanged
        {
            get => isChanged;
            private set
            {
                if (isChanged != value)
                {
                    isChanged = value;
                    Text = isChanged ? title + '*' : title;
                }
            }
        }
        
        /// <summary>
        /// Gets whether the tab can undo an operation.
        /// </summary>
        public abstract bool CanUndo { get; }
        
        /// <summary>
        /// Gets whether the tab can redo an operation.
        /// </summary>
        public abstract bool CanRedo { get; }
        
        /// <summary>
        /// Gets whether the tab can copy selected text.
        /// </summary>
        public abstract bool CanCopy { get; }
        
        /// <summary>
        /// Gets the default file extension.
        /// </summary>
        protected abstract string DefaultFileExtension { get; }

        /// <summary>
        /// Sets the title of the tab.
        /// </summary>
        [Localizable(true)]
        private string Title
        {
            set
            {
                if (title != value)
                {
                    title = value;
                    Text = isChanged ? title + '*' : title;
                }
            }
        }

        /// <summary>
        /// Creates a new <see cref="TextFileTab"/> using file name and a <see cref="ContextMenuStrip"/> instance.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="contextMenuStrip">The <see cref="ContextMenuStrip"/> instance.</param>
        /// <returns>The <see cref="TextFileTab"/> object on success, <c>null</c> otherwise.</returns>
        public static TextFileTab? CreateFileTab(string fileName, ContextMenuStrip contextMenuStrip)
        {
            TextFileType fileType = Path.GetExtension(fileName) switch
            {
                ".rtf" => TextFileType.RichTextFile,
                ".cs" => TextFileType.SourceCodeFile,
                _ => TextFileType.PlainTextFile
            };
            TextFileTab? tab = CreateFileTab(fileType, contextMenuStrip);
            if (tab == null)
            {
                return null;
            }
            return tab.LoadFile(fileName) ? tab : null;
        }

        /// <summary>
        /// Creates a new <see cref="TextFileTab"/> using file type and a <see cref="ContextMenuStrip"/> instance.
        /// </summary>
        /// <param name="fileType">The file type.</param>
        /// <param name="contextMenuStrip">The <see cref="ContextMenuStrip"/> instance.</param>
        /// <returns>The <see cref="TextFileTab"/> object on success, <c>null</c> otherwise.</returns>
        public static TextFileTab? CreateFileTab(TextFileType fileType, ContextMenuStrip contextMenuStrip)
        {
            return fileType switch
            {
                TextFileType.RichTextFile => new TextFileTabRich(contextMenuStrip),
                TextFileType.PlainTextFile => new TextFileTabPlain(contextMenuStrip),
                TextFileType.SourceCodeFile => new TextFileTabCode(contextMenuStrip),
                _ => null
            };
        }
        
        /// <summary>
        /// Saves the text, asking the file path if not specified in the tab.
        /// </summary>
        /// <param name="requestSaving">Whether to ask the file path.</param>
        /// <returns>Whether the save was successful.</returns>
        public bool Save(bool requestSaving = true)
        {
            if (LoadedFile == null)
            {
                return requestSaving && SaveAs();
            }

            try
            {
                SaveToFile(LoadedFile.FullName);
                IsChanged = false;
                return true;
            }
            catch (Exception e)
            {
                ErrorWrapper.ShowErrorMessage(e);
                return false;
            }
        }

        /// <summary>
        /// Saves the text, asking the file path.
        /// </summary>
        /// <returns>Whether the save was successful.</returns>
        public bool SaveAs()
        {
            var dialog = new SaveFileDialog();
            dialog.DefaultExt = DefaultFileExtension;
            dialog.Filter = string.Format(Resources.FilterExtensions, DefaultFileExtension, DefaultFileExtension);
            return dialog.ShowDialog() == DialogResult.OK && SaveAs(dialog.FileName);
        }
        
        /// <summary>
        /// Journal the text file by saving the text in separate file in hidden directory.
        /// </summary>
        public void Journal()
        {
            try
            {
                DirectoryInfo? dir = LoadedFile?.Directory;
                if (dir == null || LoadedFile == null)
                {
                    return;
                }
                
                DirectoryInfo subDir = dir.CreateSubdirectory("~NotepadPlus");
                subDir.Attributes |= FileAttributes.Hidden;
                SaveToFile(Path.Combine(subDir.FullName,
                    $"{Path.GetFileNameWithoutExtension(LoadedFile.Name)}-" +
                    $"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}{LoadedFile.Extension}"));
            }
            catch (Exception)
            {
                // Ignore.
            }
        }
        
        /// <summary>
        /// Undoes the last operation.
        /// </summary>
        public abstract void Undo();
        
        /// <summary>
        /// Redoes the last operation undone.
        /// </summary>
        public abstract void Redo();
        
        /// <summary>
        /// Cuts the selected text to the Clipboard.
        /// </summary>
        public abstract void Cut();
        
        /// <summary>
        /// Copies the selected text to the Clipboard.
        /// </summary>
        public abstract void Copy();
        
        /// <summary>
        /// Pastes the text from the Clipboard.
        /// </summary>
        public abstract void Paste();
        
        /// <summary>
        /// Deletes the selected text.
        /// </summary>
        public abstract void Delete();
        
        /// <summary>
        /// Selects all text.
        /// </summary>
        public abstract void SelectAll();

        /// <summary>
        /// Applies the theme to the tab.
        /// </summary>
        /// <param name="backColor">Background color.</param>
        /// <param name="textBoxBackColor">Text box background color.</param>
        /// <param name="foreColor">Foreground color.</param>
        public virtual void ApplyTheme(Color backColor, Color textBoxBackColor, Color foreColor) {}
        
        /// <summary>
        /// Handles the text box TextChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        protected void TextBox_TextChanged(object? sender, EventArgs e)
        {
            IsChanged = true;
        }

        /// <summary>
        /// Handles the text box SelectionChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        protected void TextBox_SelectionChanged(object? sender, EventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Loads file to box.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        protected abstract void LoadFileToBox(string fileName);
        
        /// <summary>
        /// Saves text to file.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        protected abstract void SaveToFile(string fileName);

        /// <summary>
        /// Loads file.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>Whether the load was successful.</returns>
        private bool LoadFile(string fileName)
        {
            try
            {
                var fileInfo = new FileInfo(fileName);
                if (fileInfo.Length > MaxFileSize)
                {
                    return false;
                }
                LoadFileToBox(fileName);
                LoadedFile = fileInfo;
                IsChanged = false;
                return true;
            }
            catch (Exception e)
            {
                ErrorWrapper.ShowErrorMessage(e);
                return false;
            }
        }

        /// <summary>
        /// Saves the text to file.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>Whether the save was successful.</returns>
        private bool SaveAs(string fileName)
        {
            try
            {
                SaveToFile(fileName);
                LoadedFile = new FileInfo(fileName);
                return true;
            }
            catch (Exception e)
            {
                ErrorWrapper.ShowErrorMessage(e);
                return false;
            }
        }
    }
}