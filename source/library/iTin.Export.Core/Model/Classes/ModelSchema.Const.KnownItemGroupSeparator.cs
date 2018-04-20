
namespace iTin.Export.Model
{
    /// <summary>
    /// Defines of the field separators available.
    /// </summary>
    public static class KnownItemGroupSeparator
    {
        /// <summary>
        /// Represents the comma character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string CommaSeparator = ",";

        /// <summary>
        /// Represents the backslash character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string BackslashSeparator = "\\";

        /// <summary>
        /// Represents the colon character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string ColonSeparator = ":";

        /// <summary>
        /// Represents the dash character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string DashSeparator = "-";

        /// <summary>
        /// Represents the dot character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string DotSeparator = ".";

        /// <summary>
        /// Represents the new line value. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string NewLineSeparator = "\n";

        /// <summary>
        /// Represents the new line value for XML format. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string NewLineSeparatorForXmlFormat = "&#10;"; //"&#x0D;&#x0A;";  

        /// <summary>
        /// Represents the semicolon character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string SemiColonSeparator = ";";

        /// <summary>
        /// Represents the slash character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string SlashSeparator = "/";

        /// <summary>
        /// Represents the space character. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public const string SpaceSeparator = " ";

        /// <summary>
        /// Represents a empty string. For more information please see <see cref="P:iTin.Export.Model.GroupItemModel.Separator"/>.
        /// </summary>
        public static readonly string EmptySeparator = string.Empty;
    }
}
