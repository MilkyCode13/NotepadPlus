using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using NotepadPlus.Properties;

namespace NotepadPlus
{
    /// <summary>
    /// The main form.
    /// </summary>
    internal sealed partial class MainForm : Form
    {
        /// <summary>
        /// The current tab selected.
        /// </summary>
        private TextFileTab? currentTab;

        /// <summary>
        /// Constructs a form from a collection of file paths.
        /// </summary>
        /// <param name="filePaths">Collection of file paths.</param>
        public MainForm(StringCollection? filePaths) : this()
        {
            filePaths ??= new StringCollection();

            foreach (string? filePath in filePaths)
            {
                if (filePath != null)
                {
                    var tab = TextFileTab.CreateFileTab(filePath, textBoxContextMenuStrip);

                    if (tab != null)
                    {
                        mainTabControl.Controls.Add(tab);
                    }
                }
            }

            TextFileTab newTab;

            try
            {
                newTab = mainTabControl.TabPages.OfType<TextFileTab>().First();
            }
            catch (Exception)
            {
                return;
            }

            currentTab = newTab;
            mainTabControl.SelectTab(newTab);
            if (currentTab != null)
            {
                buildToolStripButton.Enabled = codeFormatToolStripButton.Enabled = currentTab is TextFileTabCode;
                formatToolStripMenuItem.Enabled =
                    formatToolStripContextMenuItem.Enabled = currentTab is TextFileTabRich;
                currentTab.SelectionChanged += currentTab_SelectionChanged;
            }
        }

        /// <summary>
        /// Constructs an empty main form.
        /// </summary>
        private MainForm()
        {
            InitializeComponent();

            ApplySettings();
        }

        /// <summary>
        /// Opens new window.
        /// </summary>
        private static void ShowNewWindow()
        {
            var newForm = new MainForm();

            Application.Run(newForm);
        }

        /// <summary>
        /// Applies settings configured.
        /// </summary>
        private void ApplySettings()
        {
            if (Settings.Default.AutoSaveFrequency > 0)
            {
                autoSaveTimer.Interval = Settings.Default.AutoSaveFrequency;
            }
            else
            {
                autoSaveTimer.Interval = Settings.Default.AutoSaveFrequency = 60000;
                Settings.Default.Save();
            }

            autoSaveTimer.Enabled = Settings.Default.AutoSaveEnabled;

            if (Settings.Default.JournalingFrequency > 0)
            {
                journalingTimer.Interval = Settings.Default.JournalingFrequency;
            }
            else
            {
                journalingTimer.Interval = Settings.Default.JournalingFrequency = 600000;
                Settings.Default.Save();
            }

            journalingTimer.Enabled = Settings.Default.JournalingEnabled;
        }
        
        /// <summary>
        /// Adds a new tab and activates it.
        /// </summary>
        /// <param name="newTab">The new tab.</param>
        private void AddTabAndActivate(TextFileTab newTab)
        {
            mainTabControl.Controls.Add(newTab);
            mainTabControl.SelectTab(newTab);
            currentTab = newTab;

            if (currentTab != null)
            {
                buildToolStripButton.Enabled = codeFormatToolStripButton.Enabled = currentTab is TextFileTabCode;
                formatToolStripMenuItem.Enabled = currentTab is TextFileTabRich;
                formatToolStripContextMenuItem.Enabled = currentTab is TextFileTabRich;
                currentTab.SelectionChanged += currentTab_SelectionChanged;
            }
        }
        
        /// <summary>
        /// Ask user if they want to save open tabs.
        /// </summary>
        /// <param name="tabs"></param>
        /// <returns><c>false</c> if user cancelled operation or file save failed, <c>false</c> otherwise.</returns>
        private bool AskSaveTabs(params TextFileTab[] tabs)
        {
            if (tabs.Any(tab => tab.IsChanged))
            {
                DialogResult result = MessageBox.Show(Resources.MessageUnsavedChanges,
                    Resources.MessageUnsavedChangesHeading, MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        if (tabs.Any(tab => !tab.Save()))
                        {
                            return false;
                        }

                        break;
                    case DialogResult.Cancel:
                        return false;
                }
            }

            return true;
        }
        
        /// <summary>
        /// Handles a form Paint event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Theme.ApplyCurrentTheme(this);
        }
        
        /// <summary>
        /// Handles a form Closing event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AskSaveTabs(mainTabControl.TabPages.OfType<TextFileTab>().ToArray());

            var filePaths = new StringCollection();
            filePaths.AddRange(mainTabControl.TabPages.OfType<TextFileTab>()
                .Select(tab => tab.LoadedFile?.FullName ?? "")
                .Where(s => !string.IsNullOrWhiteSpace(s)).ToArray());
            Settings.Default.OpenedFiles = filePaths;
            Settings.Default.Save();
        }

        /// <summary>
        /// Handles a New menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var textFileTypeForm = new TextFileTypeForm();
            if (textFileTypeForm.ShowDialog() == DialogResult.OK && textFileTypeForm.TextFileType != null)
            {
                var newTab = TextFileTab.CreateFileTab(textFileTypeForm.TextFileType.Value, textBoxContextMenuStrip);

                if (newTab != null)
                {
                    AddTabAndActivate(newTab);
                }
            }
        }
        
        /// <summary>
        /// Handles a New Window menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newThread = new Thread(ShowNewWindow) {IsBackground = true};
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        /// <summary>
        /// Handles a Open menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openTextFileDialog.ShowDialog() == DialogResult.OK)
            {
                var newTab = TextFileTab.CreateFileTab(openTextFileDialog.FileName, textBoxContextMenuStrip);

                if (newTab != null)
                {
                    AddTabAndActivate(newTab);
                }
            }
        }

        /// <summary>
        /// Handles a Save menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Save();
        }

        /// <summary>
        /// Handles a Save As menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.SaveAs();
        }
        
        /// <summary>
        /// Handles a Save All menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TextFileTab tab in mainTabControl.TabPages)
            {
                tab.Save();
            }
        }
        
        /// <summary>
        /// Handles a Close menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTabControl.TabCount > 0)
            {
                if (currentTab == null)
                {
                    return;
                }

                AskSaveTabs(currentTab);

                mainTabControl.TabPages.Remove(currentTab);
            }

            if (mainTabControl.TabCount == 0)
            {
                currentTab = null;
            }
        }
        
        /// <summary>
        /// Handles an Exit menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Handles a Edit menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (currentTab == null)
            {
                return;
            }

            undoToolStripMenuItem.Enabled = currentTab.CanUndo;
            redoToolStripMenuItem.Enabled = currentTab.CanRedo;
            cutToolStripMenuItem.Enabled = currentTab.CanCopy;
            copyToolStripMenuItem.Enabled = currentTab.CanCopy;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            deleteToolStripMenuItem.Enabled = currentTab.CanCopy;
        }

        /// <summary>
        /// Handles a Undo menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Undo();
        }

        /// <summary>
        /// Handles a Redo menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Redo();
        }

        /// <summary>
        /// Handles a Cut menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Cut();
        }

        /// <summary>
        /// Handles a Copy menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Copy();
        }

        /// <summary>
        /// Handles a Paste menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Paste();
        }

        /// <summary>
        /// Handles a Delete menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.Delete();
        }

        /// <summary>
        /// Handles a Select All menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTab?.SelectAll();
        }
        
        /// <summary>
        /// Handles an Italic menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                (currentTab as TextFileTabRich)?.SetTextStyle(FontStyle.Italic, menuItem.CheckState);
            }
        }

        /// <summary>
        /// Handles a Bold menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                (currentTab as TextFileTabRich)?.SetTextStyle(FontStyle.Bold, menuItem.CheckState);
            }
        }

        /// <summary>
        /// Handles a Underline menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                (currentTab as TextFileTabRich)?.SetTextStyle(FontStyle.Underline, menuItem.CheckState);
            }
        }

        /// <summary>
        /// Handles a Strikethrough menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (currentTab as TextFileTabRich)?.SetTextStyle(FontStyle.Strikeout,
                strikethroughToolStripMenuItem.CheckState);
        }
        
        /// <summary>
        /// Handles a Font menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTab is not TextFileTabRich tab)
            {
                return;
            }

            textFontDialog.Font = tab.SelectionFont;
            textFontDialog.Color = tab.SelectionColor;

            DialogResult result = textFontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tab.SelectionFont = textFontDialog.Font;
                tab.SelectionColor = textFontDialog.Color;
            }
        }
        
        /// <summary>
        /// Handles a Settings menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            ApplySettings();
            Invalidate();
        }
        
        /// <summary>
        /// Handles a Build menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void buildToolStripButton_Click(object sender, EventArgs e)
        {
            (currentTab as TextFileTabCode)?.Build();
        }

        /// <summary>
        /// Handles a Format Code menu item Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void codeFormatToolStripButton_Click(object sender, EventArgs e)
        {
            (currentTab as TextFileTabCode)?.Format();
        }
        
        /// <summary>
        /// Handles a tab control Selected event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            currentTab = mainTabControl.SelectedTab as TextFileTab;
            if (currentTab != null)
            {
                buildToolStripButton.Enabled = codeFormatToolStripButton.Enabled = currentTab is TextFileTabCode;
                formatToolStripMenuItem.Enabled = currentTab is TextFileTabRich;
                formatToolStripContextMenuItem.Enabled = currentTab is TextFileTabRich;
            }
        }
        
        /// <summary>
        /// Handles a current tab SelectionChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void currentTab_SelectionChanged(object? sender, EventArgs e)
        {
            if (currentTab is not TextFileTabRich tab)
            {
                return;
            }

            if (tab.SelectionFont == null)
            {
                italicToolStripMenuItem.CheckState = italicToolStripContextMenuItem.CheckState =
                    CheckState.Indeterminate;
                boldToolStripMenuItem.CheckState = boldToolStripContextMenuItem.CheckState =
                    CheckState.Indeterminate;
                underlineToolStripMenuItem.CheckState = underlineToolStripContextMenuItem.CheckState =
                    CheckState.Indeterminate;
                strikethroughToolStripMenuItem.CheckState = strikethroughToolStripContextMenuItem.CheckState =
                    CheckState.Indeterminate;
            }
            else
            {
                italicToolStripMenuItem.CheckState = italicToolStripContextMenuItem.CheckState =
                    tab.SelectionFont.Italic ? CheckState.Checked : CheckState.Unchecked;
                boldToolStripMenuItem.CheckState = boldToolStripContextMenuItem.CheckState =
                    tab.SelectionFont.Bold ? CheckState.Checked : CheckState.Unchecked;
                underlineToolStripMenuItem.CheckState = underlineToolStripContextMenuItem.CheckState =
                    tab.SelectionFont.Underline ? CheckState.Checked : CheckState.Unchecked;
                strikethroughToolStripMenuItem.CheckState = strikethroughToolStripContextMenuItem.CheckState =
                    tab.SelectionFont.Strikeout ? CheckState.Checked : CheckState.Unchecked;
            }
        }
        
        /// <summary>
        /// Handles a text box context menu Open event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void textBoxContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (currentTab == null)
            {
                return;
            }

            cutToolStripContextMenuItem.Enabled = currentTab.CanCopy;
            copyToolStripContextMenuItem.Enabled = currentTab.CanCopy;
            pasteToolStripContextMenuItem.Enabled = Clipboard.ContainsText();
            deleteToolStripContextMenuItem.Enabled = currentTab.CanCopy;
        }
        

        /// <summary>
        /// Handles an auto save timer Tick event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void autoSaveTimer_Tick(object sender, EventArgs e)
        {
            foreach (TextFileTab tab in mainTabControl.TabPages)
            {
                tab.Save(false);
            }
        }

        /// <summary>
        /// Handles a journaling timer Tick event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void journalingTimer_Tick(object sender, EventArgs e)
        {
            foreach (TextFileTab tab in mainTabControl.TabPages)
            {
                tab.Journal();
            }
        }
    }
}