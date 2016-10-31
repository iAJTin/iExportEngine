using iTextSharp.text;
using iTextSharp.text.pdf;

using iTin.Export.ComponentModel;
using iTin.Export.Model;

namespace iTin.Export.Writers.Adobe
{
    /// <summary>
    /// Contains common helper methods for Portable Document Format (pdf format).
    /// </summary>
    static class PdfHelper
    {
        /// <summary>
        /// Creates a new cell with the visual style defined in the model.
        /// </summary>
        /// <param name="fieldValue">Value to write.</param>
        /// <returns>
        /// A new <see cref="T:iTextSharp.text.pdf.PdfPCell" /> with visual style defined in the model.
        /// </returns>
        public static PdfPCell CreateCell(FieldValueInformation fieldValue)
        {
            var style = fieldValue.Style;
            var value = fieldValue.FormattedValue;
            var phrase = new Phrase { Font = CreateFont(style.Font) };
            phrase.Add(value);

            var isNumeric = fieldValue.IsNumeric;
            if (!isNumeric)
            {
                return new PdfPCell(phrase).SetVisualStyle(style);
            }

            var isNegative = fieldValue.IsNegative;
            if (isNegative)
            {
                phrase.Font.Color = new BaseColor(fieldValue.NegativeColor);
            }

            return new PdfPCell(phrase).SetVisualStyle(style);
        }

        /// <summary>
        /// Creates a new cell with the visual style defined in the model.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="style">The style.</param>
        /// <returns>
        /// A new <see cref="T:iTextSharp.text.pdf.PdfPCell" /> with visual style defined in the model.
        /// </returns>
        public static PdfPCell CreateCell(string text, StyleModel style)
        {
            var phrase = new Phrase { Font = CreateFont(style.Font) };
            phrase.Add(text);

            return new PdfPCell(phrase).SetVisualStyle(style);
        }

        /// <summary>
        /// Creates a new font from model.
        /// </summary>
        /// <param name="font">Font to create.</param>
        /// <returns>
        /// A new <see cref="T:iTextSharp.text.Font" /> that contains specified font from model.
        /// </returns>
        public static Font CreateFont(FontModel font)
        {
            if (font == null)
            {
                font = FontModel.Default;
            }

            var registeredFonts = FontFactory.RegisteredFonts.Count;
            if (registeredFonts <= 14)
            {
                FontFactory.RegisterDirectories();
            }

            var style = Font.NORMAL;
            if (font.Italic == YesNo.Yes)
            {
                style = Font.ITALIC;
            }

            if (font.Bold == YesNo.Yes)
            {
                style = style | Font.BOLD;
            }

            if (font.Underline == YesNo.Yes)
            {
                style = style | Font.UNDERLINE;
            }

            return FontFactory.GetFont(font.Name, font.Size, style, new BaseColor(font.GetColor()));
        }

        /// <summary>
        /// Creates a new font which is default font from model.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:iTextSharp.text.Font" /> that contains default font from model.
        /// </returns>
        public static Font DefaultFont()
        {
            return CreateFont(FontModel.Default);
        }
    }
}
