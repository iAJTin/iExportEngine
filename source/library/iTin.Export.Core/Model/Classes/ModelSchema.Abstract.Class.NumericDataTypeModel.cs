
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.RealDataTypeModel" /> class.<br/>.
    /// Which acts as base class for the data types negative numbers with decimals .
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different numeric data field types.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.NumberDataTypeModel" /></term>
    ///       <description>Represents number format, You can specify the number of decimal places that you want to use, whether you want to use a thousands separator, and how you want to display negative numbers.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.CurrencyDataTypeModel" /></term>
    ///       <description>Represents currency format. The currency symbol appears right next to the first digit. You can specify the number of decimal places that you want to use and how you want to display negative numbers.</description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public partial class NumericDataTypeModel : ICloneable
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private NegativeModel negative;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private NumericErrorModel error;
        #endregion

        #region public properties

        #region [public] (NumericErrorModel) Error: Gets or sets a reference that contains numeric data type error settings
        /// <summary>
        /// Gets or sets a reference that contains numeric data type error settings.
        /// </summary>
        /// <value>
        /// Numeric data type error settings
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Number ...&gt;
        ///   &lt;Error/&gt;
        ///   ...
        /// &lt;/Number&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Currency ...&gt;
        ///   &lt;Error/&gt;
        ///   ...
        /// &lt;/Currency&gt;
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
        /// &lt;Style Name="AccountValue"&gt;
        ///   &lt;Content Color="Blue"&gt;
        ///     &lt;Currency Decimals="1" Locale="mk"&gt;
        ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
        ///       &lt;Error Value="-1000"&gt;
        ///         &lt;Comment Show="Yes"&gt;
        ///           &lt;Text&gt;Database value: &lt;/Text&gt;
        ///           &lt;Font Size="12" Color="Navy"/&gt;
        ///         &lt;/Comment&gt;
        ///       &lt;/Error&gt;
        ///     &lt;/Currency&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Size="8" Color="White"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// <para>Another example for the number data type.</para>
        /// <code lang="xml">
        /// &lt;Style Name="AccountValue"&gt;
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
        public NumericErrorModel Error
        {
            get => error ?? (error = new NumericErrorModel());
            set => error = value;
        }
        #endregion

        #region [public] (NegativeModel) Negative: Gets or sets a reference that contains the negative number format
        /// <summary>
        /// Gets or sets a reference that contains the negative number format.
        /// </summary>
        /// <value>
        /// Negative number format.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Number ...&gt;
        ///   &lt;Negative/&gt;
        ///   ...
        /// &lt;/Number&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Currency ...&gt;
        ///   &lt;Negative/&gt;
        ///   ...
        /// &lt;/Currency&gt;
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
        /// &lt;Style Name="AccountValue"&gt;
        ///   &lt;Content Color="Blue"&gt;
        ///     &lt;Currency Decimals="1" Locale="mk"&gt;
        ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
        ///     &lt;/Currency&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Size="8" Color="White"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// <para>Another example for the number data type.</para>
        /// <code lang="xml">
        /// &lt;Style Name="AccountValue"&gt;
        ///   &lt;Content Color="Blue"&gt;
        ///     &lt;Number Decimals="1"&gt;
        ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
        ///     &lt;/Currency&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Size="8" Color="White"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// </example>
        public NegativeModel Negative
        {
            get => negative ?? (negative = new NegativeModel());
            set => negative = value;
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
        public override bool IsDefault => base.IsDefault &&
                                          Error.IsDefault && 
                                          Negative.IsDefault;
        #endregion

        #endregion

        #region public methods

        #region [public] {new} (NumericDataTypeModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new NumericDataTypeModel Clone()
        {
            var numericDataCloned = (NumericDataTypeModel)MemberwiseClone();
            numericDataCloned.Error = Error.Clone();
            numericDataCloned.Negative = Negative.Clone();
            numericDataCloned.Properties = Properties.Clone();

            return numericDataCloned;
        }
        #endregion

        #region [public] (void) Combine(NumericDataTypeModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(NumericDataTypeModel reference)
        {
            base.Combine(reference);

            Error.Combine(reference.Error);
            Negative.Combine(reference.Negative);
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
