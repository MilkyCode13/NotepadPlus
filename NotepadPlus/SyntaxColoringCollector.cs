using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NotepadPlus
{
    /// <summary>
    /// Represents a syntax collector that collect all syntax elements relevant for syntax highlighting.
    /// </summary>
    internal sealed class SyntaxColoringCollector : CSharpSyntaxWalker
    {
        /// <summary>
        /// The semantic model used in analysis.
        /// </summary>
        private readonly SemanticModel semanticModel;
        
        /// <summary>
        /// Constructs an instance.
        /// </summary>
        /// <param name="semanticModel">The semantic model used in analysis.</param>
        public SyntaxColoringCollector(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
        }

        /// <summary>
        /// Gets the classes collected.
        /// </summary>
        public ICollection<string> Classes { get; } = new HashSet<string>();
        
        /// <summary>
        /// Gets the properties collected.
        /// </summary>
        public ICollection<string> Properties { get; } = new HashSet<string>();
        
        /// <summary>
        /// Gets the methods collected.
        /// </summary>
        public ICollection<string> Methods { get; } = new HashSet<string>();
        
        /// <summary>
        /// Gets the namespaces collected.
        /// </summary>
        public ICollection<string> Namespaces { get; } = new HashSet<string>();

        /// <summary>
        /// Called when the visitor visits a IdentifierNameSyntax node.
        /// </summary>
        /// <param name="node">The node visiting.</param>
        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            SymbolInfo nodeInfo = semanticModel.GetSymbolInfo(node);
            
            switch (nodeInfo.Symbol?.Kind)
            {
                case SymbolKind.NamedType:
                    Classes.Add(node.Identifier.ValueText);
                    break;
                case SymbolKind.Property:
                    Properties.Add(node.Identifier.ValueText);
                    break;
                case SymbolKind.Method:
                    Methods.Add(node.Identifier.ValueText);
                    break;
                case SymbolKind.Namespace:
                    Namespaces.Add(node.Identifier.ValueText);
                    break;
            }
            
            base.VisitIdentifierName(node);
        }
    }
}