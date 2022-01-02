using System.Drawing;

namespace NotepadPlus
{
    /// <summary>
    /// Represents the dark color theme.
    /// </summary>
    internal sealed class DarkTheme : Theme
    {
        /// <summary>
        /// Gets the background color.
        /// </summary>
        protected override Color BackgroundColor => Color.FromArgb(75, 75, 75);

        /// <summary>
        /// Gets the text box background color.
        /// </summary>
        protected override Color TextBoxBackgroundColor => Color.FromArgb(45, 45, 45);

        /// <summary>
        /// Gets the button background color.
        /// </summary>
        protected override Color ButtonBackgroundColor => Color.FromArgb(45, 45, 45);

        /// <summary>
        /// Gets the foreground color.
        /// </summary>
        protected override Color ForegroundColor => Color.Azure;
    }
}