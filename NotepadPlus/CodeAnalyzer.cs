using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace NotepadPlus
{
    /// <summary>
    /// Represents a code analyzer.
    /// </summary>
    internal sealed class CodeAnalyzer
    {
        /// <summary>
        /// The source code text to analyze.
        /// </summary>
        private string? text;

        /// <summary>
        /// The syntax tree of the source code.
        /// </summary>
        private SyntaxTree? syntaxTree;

        /// <summary>
        /// Gets or sets the source code text to analyze.
        /// </summary>
        public string? Text
        {
            get => text;
            set
            {
                if (value != text)
                {
                    text = value;
                    SyntaxTree = null;
                }
            }
        }

        /// <summary>
        /// Gets or sets the syntax collector.
        /// </summary>
        public SyntaxColoringCollector? Collector { get; private set; }

        /// <summary>
        /// Gets or sets the formatted code text.
        /// </summary>
        public string? FormattedCode { get; private set; }

        /// <summary>
        /// Gets or set the syntax tree of the source code.
        /// </summary>
        private SyntaxTree? SyntaxTree
        {
            get => syntaxTree;
            set
            {
                if (value != syntaxTree)
                {
                    syntaxTree = value;
                    Compilation = null;
                }
            }
        }

        /// <summary>
        /// Gets or sets the compilation object.
        /// </summary>
        private CSharpCompilation? Compilation { get; set; }

        /// <summary>
        /// Gets or sets the semantic model of the source code.
        /// </summary>
        private SemanticModel? Model { get; set; }

        /// <summary>
        /// Compiles and runs the source code.
        /// </summary>
        /// <param name="filePath">The file path to source code file.</param>
        public void Compile(string filePath)
        {
            UpdateCompilation();
            if (Compilation == null)
            {
                return;
            }

            Compiler.Compile(Compilation, filePath);
        }

        /// <summary>
        /// Gets the formatted source code..
        /// </summary>
        public void GetFormattedText()
        {
            UpdateSyntaxTree();
            FormattedCode = syntaxTree?.GetRoot().NormalizeWhitespace().SyntaxTree.ToString();
        }

        /// <summary>
        /// Analyzes the code.
        /// </summary>
        public void Analyze()
        {
            UpdateCompilation();
            if (SyntaxTree == null)
            {
                return;
            }

            Model = Compilation?.GetSemanticModel(SyntaxTree);

            if (Model == null)
            {
                return;
            }

            Collector = new SyntaxColoringCollector(Model);
            Collector.Visit(syntaxTree?.GetRoot());
        }

        /// <summary>
        /// Updates the syntax tree.
        /// </summary>
        private void UpdateSyntaxTree()
        {
            if (Text == null)
            {
                return;
            }

            SyntaxTree ??= CSharpSyntaxTree.ParseText(Text);
        }

        /// <summary>
        /// Updates the compilation.
        /// </summary>
        private void UpdateCompilation()
        {
            if (Text == null)
            {
                return;
            }

            SyntaxTree ??= CSharpSyntaxTree.ParseText(Text);
            Compilation ??= Compiler.GetCSharpCompilation(SyntaxTree);
        }
    }
}