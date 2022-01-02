using System;
using System.Windows.Forms;
using NotepadPlus.Properties;

namespace NotepadPlus
{
    /// <summary>
    /// The settings form.
    /// </summary>
    internal sealed partial class SettingsForm : Form
    {
        /// <summary>
        /// The syntax color scheme selected.
        /// </summary>
        private SyntaxColorScheme syntaxColorScheme = new(Program.CurrentSyntaxColorScheme);

        /// <summary>
        /// Constructs the settings form.
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();

            enableAutoSaveCheckBox.Checked = Settings.Default.AutoSaveEnabled;
            autoSaveFrequencyTrackBar.Value = Settings.Default.AutoSaveFrequency / 60000;

            enableJournalingCheckBox.Checked = Settings.Default.JournalingEnabled;
            journalingFrequencyTrackBar.Value = Settings.Default.JournalingFrequency / 300000;

            autoSaveFrequencyLabel.Text =
                string.Format(Resources.MessageAutoSaveInterval, autoSaveFrequencyTrackBar.Value);
            autoSaveFrequencyTrackBar.Enabled = enableAutoSaveCheckBox.Checked;

            journalingFrequencyLabel.Text =
                string.Format(Resources.MessageJournalingInterval, journalingFrequencyTrackBar.Value * 5);
            journalingFrequencyTrackBar.Enabled = enableJournalingCheckBox.Checked;

            if (Settings.Default.Theme == "dark")
            {
                darkThemeRadioButton.Checked = true;
            }
            else
            {
                lightThemeRadioButton.Checked = true;
            }

            syntaxItemListBox.Select();

            applyButton.Enabled = false;
        }

        /// <summary>
        /// Applies the settings selected in the form.
        /// </summary>
        private void ApplySettings()
        {
            Settings.Default.AutoSaveEnabled = enableAutoSaveCheckBox.Checked;
            Settings.Default.AutoSaveFrequency = autoSaveFrequencyTrackBar.Value * 60000;

            Settings.Default.JournalingEnabled = enableJournalingCheckBox.Checked;
            Settings.Default.JournalingFrequency = journalingFrequencyTrackBar.Value * 300000;

            Settings.Default.Theme = darkThemeRadioButton.Checked ? "dark" : "light";
            Program.CurrentTheme = darkThemeRadioButton.Checked ? new DarkTheme() : new LightTheme();

            syntaxColorScheme.SaveToSettings();
            Program.CurrentSyntaxColorScheme = new SyntaxColorScheme(syntaxColorScheme);

            Settings.Default.Save();
        }

        /// <summary>
        /// Handles a form Paint event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            Theme.ApplyCurrentTheme(this);

            syntaxColorPanel.BackColor = syntaxHighlighingColorDialog.Color;
        }

        /// <summary>
        /// Handles an Ok button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles an Apply button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
            applyButton.Enabled = false;
        }

        /// <summary>
        /// Handles an auto save frequency track bar Scroll event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void autoSaveFrequencyTrackBar_Scroll(object sender, EventArgs e)
        {
            autoSaveFrequencyLabel.Text =
                string.Format(Resources.MessageAutoSaveInterval, autoSaveFrequencyTrackBar.Value);

            applyButton.Enabled = true;
        }

        /// <summary>
        /// Handles an enable auto save checkbox CheckedChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void enableAutoSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            autoSaveFrequencyTrackBar.Enabled = enableAutoSaveCheckBox.Checked;

            applyButton.Enabled = true;
        }

        /// <summary>
        /// Handles a theme radio button CheckedChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void themeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        /// <summary>
        /// Handles an enable journaling checkbox CheckedChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void enableJournalingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            journalingFrequencyTrackBar.Enabled = enableJournalingCheckBox.Checked;

            applyButton.Enabled = true;
        }

        /// <summary>
        /// Handles an journaling frequency track bar Scroll event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void journalingFrequencyTrackBar_Scroll(object sender, EventArgs e)
        {
            journalingFrequencyLabel.Text =
                string.Format(Resources.MessageJournalingInterval, journalingFrequencyTrackBar.Value * 5);

            applyButton.Enabled = true;
        }

        /// <summary>
        /// Handles a syntax item list box SelectedIndexChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void syntaxItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (syntaxItemListBox.SelectedIndex != -1)
            {
                syntaxHighlighingColorDialog.Color = syntaxColorPanel.BackColor =
                    syntaxColorScheme[syntaxItemListBox.SelectedIndex];
            }
        }

        /// <summary>
        /// Handles a Select syntax color button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void selectSyntaxColorButton_Click(object sender, EventArgs e)
        {
            if (syntaxHighlighingColorDialog.ShowDialog() == DialogResult.OK)
            {
                syntaxColorScheme[syntaxItemListBox.SelectedIndex] =
                    syntaxColorPanel.BackColor = syntaxHighlighingColorDialog.Color;

                applyButton.Enabled = true;
            }
        }

        /// <summary>
        /// Handles a Reset syntax color button Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void resetSyntaxColorsButton_Click(object sender, EventArgs e)
        {
            syntaxColorScheme = new SyntaxColorScheme();
            if (syntaxItemListBox.SelectedIndex != -1)
            {
                syntaxHighlighingColorDialog.Color = syntaxColorPanel.BackColor =
                    syntaxColorScheme[syntaxItemListBox.SelectedIndex];
            }

            applyButton.Enabled = true;
        }
    }
}