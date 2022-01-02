using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace NotepadPlus
{
    /// <summary>
    /// Represents a tab with source code.
    /// </summary>
    internal sealed class TextFileTabCode : TextFileTabPlain
    {
        /// <summary>
        /// The style for keywords.
        /// </summary>
        private static readonly TextStyle KeywordStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.KeywordColor), null, FontStyle.Regular);

        /// <summary>
        /// The style for classes.
        /// </summary>
        private static readonly TextStyle ClassStyle = new(new SolidBrush(Program.CurrentSyntaxColorScheme.ClassColor),
            null, FontStyle.Regular);

        /// <summary>
        /// The style for namespaces.
        /// </summary>
        private static readonly TextStyle NamespaceStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.NamespaceColor), null, FontStyle.Regular);

        /// <summary>
        /// The style for methods.
        /// </summary>
        private static readonly TextStyle MethodStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.MethodColor), null, FontStyle.Regular);

        /// <summary>
        /// The style for properties.
        /// </summary>
        private static readonly TextStyle PropertyStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.PropertyColor), null, FontStyle.Regular);

        /// <summary>
        /// The style for strings.
        /// </summary>
        private static readonly TextStyle StringStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.StringColor), null, FontStyle.Regular);

        /// <summary>
        /// The style for comments.
        /// </summary>
        private static readonly TextStyle CommentStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.CommentColor), null, FontStyle.Italic);

        /// <summary>
        /// The style for numbers.
        /// </summary>
        private static readonly TextStyle NumberStyle =
            new(new SolidBrush(Program.CurrentSyntaxColorScheme.NumberColor), null, FontStyle.Regular);

        /// <summary>
        /// The syntax highlighter.
        /// </summary>
        private readonly SyntaxHighlighter highlighter;

        /// <summary>
        /// The code analyzer.
        /// </summary>
        private readonly CodeAnalyzer codeAnalyzer = new();

        /// <summary>
        /// The code analysis background worker.
        /// </summary>
        private readonly CodeAnalysisBackgroundWorker worker;

        /// <summary>
        /// Constructs a tab.
        /// </summary>
        /// <param name="contextMenuStrip">The <see cref="ContextMenuStrip"/> instance.</param>
        public TextFileTabCode(ContextMenuStrip contextMenuStrip) : base(contextMenuStrip)
        {
            highlighter = new SyntaxHighlighter(TextBox);
            highlighter.StringStyle = StringStyle;
            highlighter.CommentStyle = CommentStyle;
            highlighter.CommentTagStyle = CommentStyle;
            highlighter.NumberStyle = NumberStyle;
            highlighter.ClassNameStyle = ClassStyle;
            highlighter.KeywordStyle = KeywordStyle;
            worker = new CodeAnalysisBackgroundWorker(codeAnalyzer);
            worker.RunWorkerCompleted += CodeAnalysisFinished;
            TextBox.TextChangedDelayed += RunCodeAnalysis;
            TextBox.VisibleRangeChanged += TextBox_VisibleRangeChanged;
        }

        /// <summary>
        /// Gets the default file extension.
        /// </summary>
        protected override string DefaultFileExtension => "cs";

        /// <summary>
        /// Builds the code.
        /// </summary>
        public void Build()
        {
            if (!Save() || LoadedFile == null)
            {
                return;
            }

            codeAnalyzer.Text = TextBox.Text;
            codeAnalyzer.Compile(LoadedFile.FullName);
        }

        /// <summary>
        /// Formats the code.
        /// </summary>
        public void Format()
        {
            codeAnalyzer.Text = TextBox.Text;
            codeAnalyzer.GetFormattedText();
            if (codeAnalyzer.FormattedCode != null)
            {
                TextBox.Text = codeAnalyzer.FormattedCode;
            }
        }

        /// <summary>
        /// Updates syntax highlighting.
        /// </summary>
        private void UpdateSyntax()
        {
            TextBox.VisibleRange.ClearStyle(ClassStyle, PropertyStyle);
            highlighter.CSharpSyntaxHighlight(TextBox.VisibleRange);

            if (codeAnalyzer.Collector == null)
            {
                return;
            }

            foreach (string word in codeAnalyzer.Collector.Classes.ToArray())
            {
                TextBox.VisibleRange.SetStyle(ClassStyle, $@"\b{Regex.Escape(word)}\b");
            }

            foreach (string word in codeAnalyzer.Collector.Properties.ToArray())
            {
                TextBox.VisibleRange.SetStyle(PropertyStyle, $@"\b{Regex.Escape(word)}\b");
            }

            foreach (string word in codeAnalyzer.Collector.Methods.ToArray())
            {
                TextBox.VisibleRange.SetStyle(MethodStyle, $@"\b{Regex.Escape(word)}\b");
            }

            foreach (string word in codeAnalyzer.Collector.Namespaces.ToArray())
            {
                TextBox.VisibleRange.SetStyle(NamespaceStyle, $@"\b{Regex.Escape(word)}\b");
            }
        }

        /// <summary>
        /// Handles the text box TextChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void RunCodeAnalysis(object? sender, TextChangedEventArgs e)
        {
            codeAnalyzer.Text = TextBox.Text;
            worker.ScheduleRun();
            highlighter.CSharpSyntaxHighlight(TextBox.VisibleRange);
        }

        /// <summary>
        /// Runs when the code analysis changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void CodeAnalysisFinished(object? sender, RunWorkerCompletedEventArgs e)
        {
            UpdateSyntax();
        }

        /// <summary>
        /// Handles the text box VisibleRangeChanged event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void TextBox_VisibleRangeChanged(object? sender, EventArgs e)
        {
            UpdateSyntax();
        }
    }
}