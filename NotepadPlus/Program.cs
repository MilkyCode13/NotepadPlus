using System;
using System.Windows.Forms;

namespace NotepadPlus
{
    /// <summary>
    /// The program, contains entry point.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The theme applied to the app.
        /// </summary>
        public static Theme CurrentTheme = new LightTheme();
        
        /// <summary>
        /// The syntax color scheme applied to the app.
        /// </summary>
        public static SyntaxColorScheme CurrentSyntaxColorScheme = SyntaxColorScheme.GetFromSettings();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                CurrentTheme = new DarkTheme();
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(Properties.Settings.Default.OpenedFiles));
        }
    }
}