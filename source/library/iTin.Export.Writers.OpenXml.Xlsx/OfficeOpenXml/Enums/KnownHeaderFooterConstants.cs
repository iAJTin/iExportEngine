
namespace OfficeOpenXml
{
    /// <summary>
    /// Contains common extensions for data model objects.
    /// </summary>
    static class KnownHeaderFooterConstants
    {
        /// <summary>
        /// The code for "current page #"
        /// </summary>
        public const string PageNumber = "@PageNumber";

        /// <summary>
        /// The code for "total pages"
        /// </summary>
        public const string NumberOfPages = "@NumberOfPages";

        /// <summary>
        /// The code for "text font color"
        /// RGB Color is specified as RRGGBB
        /// Theme Color is specified as TTSNN where TT is the theme color Id, S is either "+" or "-" of the tint/shade value, NN is the tint/shade value.
        /// </summary>
        public const string FontColor = "@FontColor";

        /// <summary>
        /// The code for "sheet tab name"
        /// </summary>
        public const string SheetName = "@SheetName";

        /// <summary>
        /// The code for "this workbook's file path"
        /// </summary>
        public const string FilePath = "@FilePath";

        /// <summary>
        /// The code for "this workbook's file name"
        /// </summary>
        public const string FileName = "@FileName";

        /// <summary>
        /// The code for "date"
        /// </summary>
        public const string CurrentDate = "@CurrentDate";

        /// <summary>
        /// The code for "time"
        /// </summary>
        public const string CurrentTime = "@CurrentTime";

        /// <summary>
        /// The code for "picture as background"
        /// </summary>
        public const string Image = "@Image";

        /// <summary>
        /// The code for "outline style"
        /// </summary>
        public const string OutlineStyle = "@OutlineStyle";

        /// <summary>
        /// The code for "shadow style"
        /// </summary>
        public const string ShadowStyle = "@ShadowStyle";
    }
}
