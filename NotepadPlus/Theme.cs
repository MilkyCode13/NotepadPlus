using System.Drawing;
using System.Windows.Forms;

namespace NotepadPlus
{
    /// <summary>
    /// Represents the UI color theme.
    /// </summary>
    internal abstract class Theme
    {
        /// <summary>
        /// Gets the background color.
        /// </summary>
        protected abstract Color BackgroundColor { get; }

        /// <summary>
        /// Gets the text box background color.
        /// </summary>
        protected abstract Color TextBoxBackgroundColor { get; }

        /// <summary>
        /// Gets the button background color.
        /// </summary>
        protected abstract Color ButtonBackgroundColor { get; }

        /// <summary>
        /// Gets the foreground color.
        /// </summary>
        protected abstract Color ForegroundColor { get; }

        /// <summary>
        /// Applies the current theme to the control recursively.
        /// </summary>
        /// <param name="control">The control to apply theme to.</param>
        public static void ApplyCurrentTheme(Control control)
        {
            Program.CurrentTheme.ApplyTheme(control);
        }

        /// <summary>
        /// Applies the theme to the control recursively.
        /// </summary>
        /// <param name="control">The control to apply theme to.</param>
        private void ApplyTheme(Control control)
        {
            switch (control)
            {
                case TextFileTab tab:
                    tab.ApplyTheme(BackgroundColor, TextBoxBackgroundColor, ForegroundColor);
                    return;
                case Button:
                    control.BackColor = ButtonBackgroundColor;
                    control.ForeColor = ForegroundColor;
                    break;
                default:
                    control.BackColor = BackgroundColor;
                    control.ForeColor = ForegroundColor;
                    break;
            }

            foreach (Control child in control.Controls)
            {
                ApplyTheme(child);
            }
        }
    }
}