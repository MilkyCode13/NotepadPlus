using System;
using System.Windows.Forms;
using NotepadPlus.Properties;

namespace NotepadPlus
{
    /// <summary>
    /// Represents an error wrapper.
    /// </summary>
    internal static class ErrorWrapper
    {
        /// <summary>
        /// Shows a message box with an error.
        /// </summary>
        /// <param name="exception">An exception to handle.</param>
        public static void ShowErrorMessage(Exception exception)
        {
            MessageBox.Show(exception.Message, Resources.MessageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}