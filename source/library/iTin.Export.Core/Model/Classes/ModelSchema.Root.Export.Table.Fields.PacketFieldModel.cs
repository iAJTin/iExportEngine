
namespace iTin.Export.Model
{
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    public partial class PacketFieldModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;
        #endregion

        #region public properties

        #region [public] (string) InputFormat: Gets or sets input packet data format
        [XmlAttribute]
        public string InputFormat { get; set; }
        #endregion

        #region [public] (string) Name: Gets or sets the name of the field
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>
        /// The name of the field.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Field Name="string" ...&gt;
        /// ...
        /// &lt;/Field&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidFieldIdentifierNameException">If <paramref name="value" /> not is a valid field identifier name.</exception>
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage("Field", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (KnownFieldType) FieldType: Gets a value indicating packet data field type
        /// <summary>
        /// Gets a value indicating packet data field type.
        /// </summary>
        /// <value>
        /// Always returns <see cref="iTin.Export.Model.KnownFieldType.Packet" />.
        /// </value>
        public override KnownFieldType FieldType => KnownFieldType.Packet;
        #endregion

        #endregion

        #region public static methods

        #region [private] {static} (string) GetInputFormat(string): Returns input packet data format
        /// <summary>
        /// Returns input packet data format.
        /// </summary>
        /// <param name="format">Input format.</param>
        /// <returns>
        /// A value than represents input packet data format.
        /// </returns>
        public static string GetInputFormat(string format)
        {
            var result = format;

            switch (format)
            {
                case "ShortDateFormat":
                    result = KnownInputPacketFormat.ShortDateFormat;
                    break;

                case "LongDateFormat":
                    result = KnownInputPacketFormat.LongDateFormat;
                    break;

                case "FullDateFormat":
                    result = KnownInputPacketFormat.FullDateFormat;
                    break;
            }

            return result;
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="DataFieldModel.ToString()"/> returns a string that includes field name and field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"Name=\"{Name}\", {base.ToString()}";
        }
        #endregion

        #endregion
    }
}
