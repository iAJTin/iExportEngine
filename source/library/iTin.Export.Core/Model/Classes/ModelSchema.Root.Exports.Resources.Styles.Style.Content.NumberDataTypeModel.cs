using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.NumericDataTypeModel" /> class.<br/>
    /// You can specify the number of decimal places that you want to use, whether you want to use a thousands separator, and how you want to display negative numbers. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Number ...&gt;
    ///   &lt;Negative/&gt;
    ///   &lt;Error/&gt;
    /// &lt;Number/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.RealDataTypeModel.Decimals" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Number of decimal places. The default is <c>2</c>.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.NumberDataTypeModel.Separator" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether to display the thousands separator. The default is <see cref="iTin.Export.Model.YesNo.No" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.NumericDataTypeModel.Error" /></term> 
    ///     <description>Reference for numeric data type error settings.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.NumericDataTypeModel.Negative" /></term> 
    ///     <description>Reference for negative number format.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
    ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
    /// <example>
    /// The following example indicate that the content should be number data type.
    /// <code lang="xml">
    /// &lt;Style Name="TopAggregate"&gt;
    ///   &lt;Content Color="#C9C9C9"&gt;
    ///     &lt;Alignment Horizontal="Center"/&gt;
    ///     &lt;Number Decimals="0" Separator="Yes"&gt;
    ///       &lt;Negative Color="Yellow" Sign="Brackets"/&gt;
    ///       &lt;Error Value="-9999"&gt;
    ///         &lt;Comment Show="Yes"&gt;
    ///           &lt;Text>Original value:  &lt;/Text&gt;
    ///           &lt;Font Size="12" Color="Navy"/&gt;
    ///         &lt;/Comment&gt;
    ///       &lt;/Error&gt;           
    ///     &lt;/Number&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class NumberDataTypeModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultSeparator = YesNo.No;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo separator;
        #endregion

        #region constructor/s

            #region [public] NumberDataTypeModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.NumberDataTypeModel"/> class.
            /// </summary>
            public NumberDataTypeModel()
            {
                Separator = DefaultSeparator;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (YesNo) Separator: Gets or sets a value indicating whether displays thousands separator.
            /// <summary>
            /// Gets or sets a value indicating whether displays thousands separator.
            /// </summary>
            /// <value>
            /// <see cref="iTin.Export.Model.YesNo.Yes" /> if displays thousands separator; otherwise, <see cref="iTin.Export.Model.YesNo.No"/>. The default is <see cref="iTin.Export.Model.YesNo.No"/>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Number Separator="Yes|No" ...&gt;
            /// ...
            /// &lt;/Number&gt;
            /// </code>
            /// <para>
            /// <para><strong>Compatibility table with native writers.</strong></para>
            /// <table>
            ///   <thead>
            ///     <tr>
            ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
            ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
            ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
            ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
            /// <example>
            /// In the following example shows how create a new style.
            /// <code lang="xml">
            /// &lt;Style Name="TopAggregate"&gt;
            ///   &lt;Content Color="#C9C9C9"&gt;
            ///     &lt;Alignment Horizontal="Center"/&gt;
            ///     &lt;Number Decimals="0" Separator="Yes"&gt;
            ///       &lt;Negative Color="Yellow" Sign="Brackets"/&gt;
            ///       &lt;Error Value="-9999"&gt;
            ///         &lt;Comment Show="Yes"&gt;
            ///           &lt;Text>Original value:  &lt;/Text&gt;
            ///           &lt;Font Size="12" Color="Navy"/&gt;
            ///         &lt;/Comment&gt;
            ///       &lt;/Error&gt;           
            ///     &lt;/Number&gt;
            ///   &lt;/Content&gt;
            ///   &lt;Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// </example>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultSeparator)]
            public YesNo Separator
            {
                get
                {
                    return separator;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);
                    separator = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return base.IsDefault &&
                           Separator.Equals(DefaultSeparator);
                }
            }
        #endregion

        #endregion

        #region public methods

            #region [public] {new} (NumberDataTypeModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public new NumberDataTypeModel Clone()
            {
                var numberDataTypeCloned = (NumberDataTypeModel)MemberwiseClone();
                numberDataTypeCloned.Properties = Properties.Clone();

                return numberDataTypeCloned;
            }
            #endregion

        #region [public] (void) Combine(NumberDataTypeModel): Combines this instance with reference parameter.
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(NumberDataTypeModel reference)
            {
                if (Separator.Equals(DefaultSeparator))
                {
                    Separator = reference.Separator;
                }

                base.Combine(reference);
            }
        #endregion

        #endregion

        #region private methods

            #region [private] (object) Clone(): Creates a new object that is a copy of the current instance.
            /// <summary>
            /// Creates a new object that is a copy of the current instance.
            /// </summary>
            /// <returns>
            /// A new object that is a copy of this instance.
            /// </returns>
            object ICloneable.Clone()
            {
                return Clone();
            }
            #endregion

        #endregion
    }
}
