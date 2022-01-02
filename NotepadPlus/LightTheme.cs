using System.Drawing;

namespace NotepadPlus
{
    /// <summary>
    /// Represents the light color theme.
    /// </summary>
    internal sealed class LightTheme : Theme
    {
        /// <summary>
        /// Gets the background color.
        /// </summary>
        protected override Color BackgroundColor => SystemColors.Control;

        /// <summary>
        /// Gets the text box background color.
        /// </summary>
        protected override Color TextBoxBackgroundColor => Color.White;

        /// <summary>
        /// Gets the button background color.
        /// </summary>
        protected override Color ButtonBackgroundColor => SystemColors.ButtonFace;

        /// <summary>
        /// Gets the foreground color.
        /// </summary>
        protected override Color ForegroundColor => SystemColors.ControlText;
    }
}