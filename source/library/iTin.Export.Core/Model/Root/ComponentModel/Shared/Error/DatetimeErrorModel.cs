
namespace iTin.Export.Model
{    
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// A Specialization of <see cref="BaseErrorModel" /> class.<br/>
    /// Represents the error structure for datetime data type. Allows us to set a default value and an additional comment.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Datetime</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.DatetimeDataTypeModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Error ...&gt;
    ///   &lt;Comment/&gt;
    /// &lt;/Error&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.DatetimeErrorModel.Value" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred default value when occurs an error. The default is "<c>MinValue</c>".</td>
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
    ///     <term><see cref="P:iTin.Export.Model.BaseErrorModel.Comment" /></term> 
    ///     <description>Reference for error comment. Includes comment text, format, including font face, size, and style attributes.</description>
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
    /// In the following example shows how create a new style with a percentage data type.
    /// <code lang="xml">
    /// &lt;Style Name="DateValue"&gt;
    ///   &lt;Content Color="sc# 0.15 0.15 0.15"&gt;
    ///     &lt;Alignment Horizontal="Center"/&gt;
    ///     &lt;DateTime Format="Year-Month" Locale="en-US"&gt;
    ///       &lt;Error Value="Today"&gt;
    ///         &lt;Comment Show="Yes"&gt;
    ///           &lt;Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
    ///         &lt;/Comment&gt;
    ///       &lt;/Error&gt;
    ///     &lt;/DateTime&gt;
    ///   &lt;/Content&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>    
    public partial class DatetimeErrorModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultValue = "MinValue";
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;
        #endregion

        #region constructor/s

        #region [public] DatetimeErrorModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.DatetimeErrorModel" /> class.
        /// </summary>
        public DatetimeErrorModel()
        {
            Value = DefaultValue;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DateTime) DateTimeValue: Gets a value that represent the date time value
        /// <summary>
        /// Gets a value that represent the date time value.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.DateTime" /> that represent the date time value.
        /// </value>
        public DateTime DateTimeValue
        {
            get
            {
                DateTime value;
                switch (Value)
                {
                    case "MinValue":
                        value = new DateTime(1900, 1, 1);
                        break;

                    case "MaxValue":
                        value = DateTime.MaxValue;
                        break;

                    case "Today":
                        value = DateTime.Today;
                        break;

                    default:
                        var isValid = DateTime.TryParse(Value, out value);
                        if (!isValid)
                        {
                            value = new DateTime(1900, 1, 1);
                        }                            
                        break;
                }

                return value;
            }
        }
        #endregion

        #region [public] (string) Value: Gets or sets preferred default value when occurs an error
        /// <summary>
        /// Gets or sets preferred default value when occurs an error.
        /// </summary>
        /// <value>
        /// Preferred default value when occurs an error. The default is "<c>MinValue</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Error Value="string" ...&gt;
        ///   ...
        /// &lt;/Error&gt;
        /// </code>
        /// <para>
        /// <c>AEE</c> recognizes the following strings as valid values:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Value</term>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>MinValue</term> 
        ///     <description>Represents date '01/01/1900'.</description>
        ///   </item>
        ///   <item>
        ///     <term>MaxValue</term> 
        ///     <description>Represents maximun system date.</description>
        ///   </item>
        ///   <item>
        ///     <term>Today</term> 
        ///     <description>Represents today date.</description>
        ///   </item>
        ///   <item>
        ///     <term>Other value</term> 
        ///     <description>Defined by user. If the value is not correct will used <string><c>MinValue</c></string>.</description>
        ///   </item>
        /// </list>
        /// </para>
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
        /// In the following example shows how create a new style with a currency data type.
        /// <code lang="xml">
        /// &lt;Style Name="DateValue"&gt;
        ///   &lt;Content Color="sc# 0.15 0.15 0.15"&gt;
        ///     &lt;Alignment Horizontal="Center"/&gt;
        ///     &lt;DateTime Format="Year-Month" Locale="en-US"&gt;
        ///       &lt;Error Value="Today"&gt;
        ///         &lt;Comment Show="Yes"&gt;
        ///           &lt;Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
        ///         &lt;/Comment&gt;
        ///       &lt;/Error&gt;
        ///     &lt;/DateTime&gt;
        ///   &lt;/Content&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultValue)]
        public string Value
        {
            get => _value;
            set => _value = value;
        }

        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance is default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => base.IsDefault && Value.Equals(DefaultValue);
        #endregion

        #endregion

        #region public methods

        #region [public] {new} (DatetimeErrorModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new DatetimeErrorModel Clone()
        {
            var datetimeErrorCloned = (DatetimeErrorModel)MemberwiseClone();
            datetimeErrorCloned.Comment = Comment.Clone();
            datetimeErrorCloned.Properties = Properties.Clone();

            return datetimeErrorCloned;
        }
        #endregion

        #region [public] (void) Combine(DatetimeErrorModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(DatetimeErrorModel reference)
        {
            if (Value.Equals(DefaultValue))
            {
                Value = reference.Value;
            }

            base.Combine(reference);
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
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
