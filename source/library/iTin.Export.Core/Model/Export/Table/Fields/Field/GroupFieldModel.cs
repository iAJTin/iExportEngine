
namespace iTin.Export.Model
{
    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.DataFieldModel" /> class.<br />
    /// Represents a field as union of several data field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Fields</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.FieldsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Group ...&gt;
    ///   &lt;Header/&gt;
    ///   &lt;Value/&gt;
    ///   &lt;Aggregate/&gt;
    /// &lt;/Group&gt;
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Attribute</th>
    ///       <th>Optional</th>
    ///       <th>Description</th>
    ///       </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.DataFieldModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the group field.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.BaseDataFieldModel.Alias" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>The alias of group data field. This value is used as the column header.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.BaseDataFieldModel.Header" /></term> 
    ///     <description>Reference to visual setting of header of the data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.BaseDataFieldModel.Value" /></term> 
    ///     <description>Reference to visual setting of value of the data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.BaseDataFieldModel.Aggregate" /></term> 
    ///     <description>Reference to visual setting of aggregate function of the data field.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
    ///       <th>SQL Script<br /><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
    public partial class GroupFieldModel
    {
        #region public override properties
        
        #region [public] {override} (KnownFieldType) FieldType: Gets a value indicating data field type
        /// <summary>
        /// Gets a value indicating data field type.
        /// </summary>
        /// <value>
        /// Always returns <see cref="iTin.Export.Model.KnownFieldType.Group" />.
        /// </value>
        public override KnownFieldType FieldType => KnownFieldType.Group;
        #endregion

        #endregion

        #region public static methods

        #region [private] {static} (string) GetSeparatorChar(string): Returns separator char
        /// <summary>
        /// Returns separator char.
        /// </summary>
        /// <param name="separator">Separator text.</param>
        /// <returns>
        /// A value than represents separator char.
        /// </returns>
        public static string GetSeparatorChar(string separator)
        {
            var result = separator;

            switch (separator)
            {
                case "None":
                    result = KnownItemGroupSeparator.EmptySeparator;
                    break;

                case "Space":
                    result = KnownItemGroupSeparator.SpaceSeparator;
                    break;

                case "Backslash":
                    result = KnownItemGroupSeparator.BackslashSeparator;
                    break;

                case "Dash":
                    result = KnownItemGroupSeparator.DashSeparator;
                    break;

                case "Dot":
                    result = KnownItemGroupSeparator.DotSeparator;
                    break;

                case "Comma":
                    result = KnownItemGroupSeparator.CommaSeparator;
                    break;

                case "Colon":
                    result = KnownItemGroupSeparator.ColonSeparator;
                    break;

                case "Slash":
                    result = KnownItemGroupSeparator.SlashSeparator;
                    break;

                case "Semi Colon":
                    result = KnownItemGroupSeparator.SemiColonSeparator;
                    break;

                case "New Line":
                    result = KnownItemGroupSeparator.NewLineSeparator;
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
        /// This method <see cref="GroupFieldModel.ToString()"/> returns a string that includes name of group and alias of field.
        /// </remarks>
        public override string ToString()
        {
            return $"Group=\"{Name}\", {base.ToString()}";
        }
        #endregion

        #endregion
    }
}
