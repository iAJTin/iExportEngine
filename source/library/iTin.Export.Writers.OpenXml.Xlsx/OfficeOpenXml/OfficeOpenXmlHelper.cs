
namespace OfficeOpenXml
{
    /// <summary>
    /// Static class than contains helper methods.
    /// </summary>
    static class OfficeOpenXmlHelper
    {
        /// <summary>
        /// Returns header/footer parsed text 
        /// </summary>
        /// <param name="text">Text to parse.</param>
        /// <returns>
        /// Parsed header/footer text.
        /// </returns>
        public static string GetHeaderFooterParsedText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return text
                .Replace(KnownHeaderFooterConstants.PageNumber, ExcelHeaderFooter.PageNumber)
                .Replace(KnownHeaderFooterConstants.NumberOfPages, ExcelHeaderFooter.NumberOfPages)
                .Replace(KnownHeaderFooterConstants.FontColor, ExcelHeaderFooter.FontColor)
                .Replace(KnownHeaderFooterConstants.SheetName, ExcelHeaderFooter.SheetName)
                .Replace(KnownHeaderFooterConstants.FilePath, ExcelHeaderFooter.FilePath)
                .Replace(KnownHeaderFooterConstants.FileName, ExcelHeaderFooter.FileName)
                .Replace(KnownHeaderFooterConstants.CurrentDate, ExcelHeaderFooter.CurrentDate)
                .Replace(KnownHeaderFooterConstants.CurrentTime, ExcelHeaderFooter.CurrentTime)
                .Replace(KnownHeaderFooterConstants.Image, ExcelHeaderFooter.Image)
                .Replace(KnownHeaderFooterConstants.OutlineStyle, ExcelHeaderFooter.OutlineStyle)
                .Replace(KnownHeaderFooterConstants.ShadowStyle, ExcelHeaderFooter.ShadowStyle);
        }
    }
}
