using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using NotepadPlus.Properties;

namespace NotepadPlus
{
    /// <summary>
    /// This class contains methods for compilation.
    /// </summary>
    internal static class Compiler
    {
        /// <summary>
        /// Initializes the Compiler class.
        /// </summary>
        static Compiler()
        {
            if (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") is not string referencesString)
            {
                References = new List<MetadataReference>();
            }
            else
            {
                References = referencesString.Split(Path.PathSeparator)
                    .Select(path => MetadataReference.CreateFromFile(path) as MetadataReference)
                    .ToList();
            }
        }
        
        /// <summary>
        /// Gets the references to include in compilation.
        /// </summary>
        private static List<MetadataReference> References { get; }

        /// <summary>
        /// Gets the compilation object.
        /// </summary>
        /// <param name="syntaxTree">The syntax tree to build compilation from.</param>
        /// <returns>The <see cref="CSharpCompilation"/> object.</returns>
        public static CSharpCompilation GetCSharpCompilation(SyntaxTree syntaxTree)
        {
            return CSharpCompilation.Create("Program")
                .WithOptions(new CSharpCompilationOptions(OutputKind.ConsoleApplication))
                .AddReferences(References)
                .AddSyntaxTrees(syntaxTree);
        }
        
        /// <summary>
        /// Compiles the compilation to file.
        /// </summary>
        /// <param name="compilation">The compilation object.</param>
        /// <param name="sourceFilePath">The path to source code.</param>
        public static void Compile(CSharpCompilation compilation, string sourceFilePath)
        {
            string assemblyName = Path.ChangeExtension(sourceFilePath, ".dll");
            
            EmitResult result = compilation.Emit(assemblyName);
            
            WriteRuntimeConfig(Path.ChangeExtension(sourceFilePath, ".runtimeconfig.json"));

            if (result.Success)
            {
                Process.Start("dotnet", assemblyName);
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Diagnostics),
                    Resources.MessageCompilation, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Writes the runtime config JSON file.
        /// </summary>
        /// <param name="filePath">The path to runtime config.</param>
        private static void WriteRuntimeConfig(string filePath)
        {
            try
            {
                using FileStream stream = File.Create(filePath);
                using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions {Indented = true});
                
                writer.WriteStartObject();
                writer.WriteStartObject("runtimeOptions");
                writer.WriteString("tfm", "net5.0");
                writer.WriteStartObject("framework");
                writer.WriteString("name", "Microsoft.NETCore.App");
                writer.WriteString("version", "5.0.0");
                writer.WriteEndObject();
                writer.WriteEndObject();
                writer.WriteEndObject();
            }
            catch (Exception e)
            {
                ErrorWrapper.ShowErrorMessage(e);
            }
        }
    }
}