
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseErrorModel" /> class.
    /// Which acts as the base class of error structures for numerical data.
    /// </summary>
    /// <remarks>
    ///   <para>The following table shows the different data types error structures.</para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.PercentageErrorModel" /></term>
    ///       <description>Represents the error structure for percentage data type.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ScientificErrorModel" /></term>
    ///       <description>Represents the error structure for scientific data type.</description>
    ///     </item>
    ///   </list>
    /// </remarks>        
    public partial class NumericErrorModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultValue = 0f;
        #endregion

        #region constructor/s

        #region [public] NumericErrorModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="iTin.Export.Model.NumericErrorModel" /> class.
        /// </summary>
        public NumericErrorModel()
        {
            Value = DefaultValue;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (float) Value: Gets or sets preferred default value when occurs an error
        /// <summary>
        /// Gets or sets preferred default value when occurs an error.
        /// </summary>
        /// <value>
        /// Preferred default value when occurs an error. The default is <c>0.0</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Error Value="float" ...&gt;
        ///   ...
        /// &lt;/Error&gt;
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
        /// In the following example shows how create a new style with a currency data type.
        /// <code lang="xml">
        /// &lt;Style Name="Account"&gt;
        ///   &lt;Content Color="Blue"&gt;
        ///     &lt;Number Decimals="1"&gt;
        ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
        ///       &lt;Error Value="99"&gt;
        ///         &lt;Comment Show="Yes"&gt;
        ///           &lt;Text&gt;Wrong value: &lt;/Text&gt;
        ///         &lt;/Comment&gt;
        ///       &lt;/Error&gt;
        ///     &lt;/Currency&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Size="8" Color="White"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultValue)]
        public float Value { get; set; }
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

        #region [public] {new} (NumericErrorModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new NumericErrorModel Clone()
        {
            var numericErrorCloned = (NumericErrorModel)MemberwiseClone();
            numericErrorCloned.Comment = Comment.Clone();
            numericErrorCloned.Properties = Properties.Clone();

            return numericErrorCloned;
        }
        #endregion

        #region [public] (void) Combine(NumericErrorModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(NumericErrorModel reference)
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
