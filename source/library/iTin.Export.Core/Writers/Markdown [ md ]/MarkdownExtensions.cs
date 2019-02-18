
namespace iTin.Export.Writers
{
    using System.Drawing;

    using Model;

    /// <summary>
    /// Contains common extensions for data model objects.
    /// </summary>
    static class MarkdownExtensions
    {
        #region [public] {static} (string) ToMarkdownTextAlignment(this KnownHorizontalAlignment): Returns appropiate Markdown syntax for specfied alignment
        /// <summary>
        /// Returns appropiate <c>Markdown</c> syntax for specfied alignment.
        /// </summary>
        /// <param name="alignment">Model alignment.</param>
        /// <returns>
        /// Returns a <see cref="T:System.String"/> that contains <c>Markdown</c> syntax for specfied alignment.
        /// </returns>
        public static string ToMarkdownTextAlignment(this KnownHorizontalAlignment alignment)
        {
            string result =" :---- ";

            switch (alignment)
            {
                case KnownHorizontalAlignment.Center:
                    result = " :----: ";
                    break;

                case KnownHorizontalAlignment.Right:
                    result = " ----: ";
                    break;
            }

            return result;
        }
        #endregion

        #region [public] {static} (string) ToMarkdownStylePattern(this FontStyle): Returns appropiate Markdown syntax for specfied style(s)
        /// <summary>
        /// Returns appropiate <c>Markdown</c> syntax for specfied style(s).
        /// </summary>
        /// <param name="fontStyle">Font style to transform.</param>
        /// <returns>
        /// Returns a <see cref="T:System.String"/> that contains <c>Markdown</c> syntax for specfied style(s).
        /// </returns>
        public static string ToMarkdownStylePattern(this FontStyle fontStyle)
        {
            // B I U S

            // 0 0 0 0
            string pattern = "{0}";

            // 0 0 0 1
            if (fontStyle == FontStyle.Strikeout)
            {
                pattern = "~~{0}~~";
            }
            // 0 0 1 0
            else if (fontStyle == FontStyle.Underline)
            {
                pattern = "<u>{0}</u>";
            }
            // 0 0 1 1
            else if ((fontStyle & FontStyle.Underline) == FontStyle.Underline &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "<u>~~{0}~~</u>";
            }
            // 0 1 0 0
            else if (fontStyle == FontStyle.Italic)
            {
                pattern = "*{0}*";
            }
            // 0 1 0 1
            else if ((fontStyle & FontStyle.Italic) == FontStyle.Italic &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "*<u>{0}</u>*";
            }
            // 0 1 1 0
            else if ((fontStyle & FontStyle.Italic) == FontStyle.Italic &&
                     (fontStyle & FontStyle.Underline) == FontStyle.Underline)
            {
                pattern = "*<u>{0}</u>*";
            }
            // 0 1 1 1
            else if ((fontStyle & FontStyle.Italic) == FontStyle.Italic &&
                     (fontStyle & FontStyle.Underline) == FontStyle.Underline &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "*<u>~~{0}~~</u>*";
            }
            // 1 0 0 0
            else if (fontStyle == FontStyle.Bold)
            {
                pattern = "**{0}**";
            }
            // 1 0 0 1
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "**~~{values[idx]}~~**";
            }
            // 1 0 1 0
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Underline) == FontStyle.Underline)
            {
                pattern = "**<u>{0}</u>**";
            }
            // 1 0 1 1
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Underline) == FontStyle.Underline &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "**<u>~~{0}~~</u>**";
            }
            // 1 1 0 0
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Italic) == FontStyle.Italic)
            {
                pattern = "***{0}***";
            }
            // 1 1 0 1
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Italic) == FontStyle.Italic &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "***~~{0}~~***";
            }
            // 1 1 1 0
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Italic) == FontStyle.Italic &&
                     (fontStyle & FontStyle.Underline) == FontStyle.Underline)
            {
                pattern = "***<u>{0}</u>***";
            }
            // 1 1 1 1
            else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold &&
                     (fontStyle & FontStyle.Italic) == FontStyle.Italic &&
                     (fontStyle & FontStyle.Underline) == FontStyle.Underline &&
                     (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
            {
                pattern = "~~***<u>{0}</u>***~~";
            }

            return pattern;
        }
        #endregion
    }
}
