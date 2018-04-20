
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseDataTypeModel"/> class.<br/>
    /// Which acts as the base class for data types with decimal numbers.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different data field types.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.NumericDataTypeModel" /></term>
    ///       <description>Represents base class for the data types negative numbers with decimals.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.PercentageDataTypeModel" /></term>
    ///       <description>Displays the result with a percent sign (%). You can specify the number of decimal places to use.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ScientificDataTypeModel"/></term>
    ///       <description>Displays a number in exponential notation, which replaces part of the number with E + n, where E (exponent) multiplies the preceding number by 10 to n. You can specify the number of decimal places you want to use.</description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public partial class RealDataTypeModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultDecimals = 2;
        #endregion

        #region field member
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int decimals;
        #endregion

        #region constructor/s

        #region [protected] RealDataTypeModel: Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.RealDataTypeModel" /> class.
        /// </summary>
        protected RealDataTypeModel()
        {
            Decimals = DefaultDecimals;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int) Decimals: Gets or sets number of decimal places
        /// <summary>
        /// Gets or sets number of decimal places.
        /// </summary>
        /// <value>
        /// Number of decimal places. The default is <c>2</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Percentage|NumericDataType|Scientific Decimals="int" ...&gt;
        /// ...
        /// &lt;/Percentage|NumericDataType|Scientific&gt;
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
        /// In the following example shows how create a new style with a currency data type (inherits <see cref="iTin.Export.Model.NumericDataTypeModel" />).
        /// <code lang="xml">
        /// &lt;Style Name="AccountValue"&gt;
        ///   &lt;Content Color="Blue"&gt;
        ///     &lt;Currency Decimals="1" Locale="mk"&gt;
        ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
        ///     &lt;/Currency&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Size="8" Color="White"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// <para>Another example for the percentage data type (inherits <see cref="iTin.Export.Model.RealDataTypeModel" />).</para>
        /// <code lang="xml">
        /// &lt;Style Name="PercentValue"&gt;
        ///   &lt;Content Color="DarkGray"&gt;
        ///     &lt;Alignment Horizontal="Right" /&gt;
        ///     &lt;Percentage Decimals="1" /&gt;
        ///   &lt;/Content>
        ///   &lt;Font Size="10" Bold="Yes" /&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="value" /> is less than 0.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultDecimals)]
        public int Decimals
        {
            get => decimals;
            set
            {
                SentinelHelper.ArgumentLessThan("value", value, 0);

                decimals = value;
            }
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
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => base.IsDefault && Decimals.Equals(DefaultDecimals);
        #endregion

        #endregion

        #region public methods

        #region [public] {new} (RealDataTypeModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new RealDataTypeModel Clone()
        {
            var realDataTypeCloned = (RealDataTypeModel)MemberwiseClone();
            realDataTypeCloned.Properties = Properties.Clone();

            return realDataTypeCloned;
        }
        #endregion

        #region [public] (void) Combine(RealDataTypeModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(RealDataTypeModel reference)
        {
            if (Decimals.Equals(DefaultDecimals))
            {
                Decimals = reference.Decimals;
            }
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
