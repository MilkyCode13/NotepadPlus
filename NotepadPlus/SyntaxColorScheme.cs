using System.Drawing;
using NotepadPlus.Properties;

namespace NotepadPlus
{
    internal sealed class SyntaxColorScheme
    {
        /// <summary>
        /// Constructs default syntax color scheme.
        /// </summary>
        public SyntaxColorScheme()
        {
        }

        /// <summary>
        /// Copies a syntax color scheme.
        /// </summary>
        /// <param name="colorScheme">An instance to copy.</param>
        public SyntaxColorScheme(SyntaxColorScheme colorScheme)
        {
            KeywordColor = colorScheme.KeywordColor;
            ClassColor = colorScheme.ClassColor;
            NamespaceColor = colorScheme.NamespaceColor;
            MethodColor = colorScheme.MethodColor;
            PropertyColor = colorScheme.PropertyColor;
            StringColor = colorScheme.StringColor;
            NumberColor = colorScheme.NumberColor;
            CommentColor = colorScheme.CommentColor;
        }

        /// <summary>
        /// The color for keywords.
        /// </summary>
        public Color KeywordColor { get; set; } = Color.RoyalBlue;

        /// <summary>
        /// The color for classes.
        /// </summary>
        public Color ClassColor { get; set; } = Color.BlueViolet;

        /// <summary>
        /// The color for namespaces.
        /// </summary>
        public Color NamespaceColor { get; set; } = Color.BlueViolet;

        /// <summary>
        /// The color for methods.
        /// </summary>
        public Color MethodColor { get; set; } = Color.YellowGreen;

        /// <summary>
        /// The color for properties.
        /// </summary>
        public Color PropertyColor { get; set; } = Color.Aqua;

        /// <summary>
        /// The color for strings.
        /// </summary>
        public Color StringColor { get; set; } = Color.SandyBrown;

        /// <summary>
        /// The color for numbers.
        /// </summary>
        public Color NumberColor { get; set; } = Color.Magenta;

        /// <summary>
        /// The color for comments.
        /// </summary>
        public Color CommentColor { get; set; } = Color.Green;

        /// <summary>
        /// Gets or sets a color by its index.
        /// </summary>
        /// <param name="index"></param>
        public Color this[int index]
        {
            get
            {
                return index switch
                {
                    0 => KeywordColor,
                    1 => ClassColor,
                    2 => NamespaceColor,
                    3 => MethodColor,
                    4 => PropertyColor,
                    5 => StringColor,
                    6 => NumberColor,
                    _ => CommentColor
                };
            }
            set
            {
                switch (index)
                {
                    case 0:
                        KeywordColor = value;
                        break;
                    case 1:
                        ClassColor = value;
                        break;
                    case 2:
                        NamespaceColor = value;
                        break;
                    case 3:
                        MethodColor = value;
                        break;
                    case 4:
                        PropertyColor = value;
                        break;
                    case 5:
                        StringColor = value;
                        break;
                    case 6:
                        NumberColor = value;
                        break;
                    default:
                        CommentColor = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Get a syntax color scheme from settings.
        /// </summary>
        /// <returns>A <see cref="SyntaxColorScheme"/> object.</returns>
        public static SyntaxColorScheme GetFromSettings()
        {
            return new SyntaxColorScheme
            {
                KeywordColor = Settings.Default.SyntaxColorKeyword,
                ClassColor = Settings.Default.SyntaxColorClass,
                NamespaceColor = Settings.Default.SyntaxColorNamespace,
                MethodColor = Settings.Default.SyntaxColorMethod,
                PropertyColor = Settings.Default.SyntaxColorProperty,
                StringColor = Settings.Default.SyntaxColorString,
                NumberColor = Settings.Default.SyntaxColorNumber,
                CommentColor = Settings.Default.SyntaxColorComment
            };
        }

        /// <summary>
        /// Saves the color scheme to settings.
        /// </summary>
        public void SaveToSettings()
        {
            Settings.Default.SyntaxColorKeyword = KeywordColor;
            Settings.Default.SyntaxColorClass = ClassColor;
            Settings.Default.SyntaxColorNamespace = NamespaceColor;
            Settings.Default.SyntaxColorMethod = MethodColor;
            Settings.Default.SyntaxColorProperty = PropertyColor;
            Settings.Default.SyntaxColorString = StringColor;
            Settings.Default.SyntaxColorNumber = NumberColor;
            Settings.Default.SyntaxColorComment = CommentColor;
            Settings.Default.Save();
        }
    }
}