
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    /// <summary>
    /// Represents a field condition. Defines the style that will be applied to the field when its value is zero.
    /// </summary>
    public partial class ZeroCondition : ICloneable
    {
        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;
        #endregion

        #region public static readonly properties

        #region [public] {static} (ZeroCondition) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static ZeroCondition Empty => new ZeroCondition();
        #endregion

        #endregion

        #region public override readonly properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => base.IsDefault &&
                                          string.IsNullOrEmpty(Style);
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (bool) IsEmpty: Gets a value indicating whether this condition is an empty condition
        /// <summary>
        /// Gets a value indicating whether this condition is an empty condition.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if is an empty condition; otherwise, <strong>false</strong>.
        /// </value>        
        public bool IsEmpty => IsDefault;
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Style: Gets or sets a value that represents the style that is applied when the condition is met
        /// <summary>
        /// Gets or sets a value that represents the style that is applied when the condition is met.
        /// </summary>
        /// <value>
        /// A <see cref ="T:System.String"/> that represents the style that is applied when the condition is met.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;ZeroValue Style="string" .../&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Global.Resources&gt;
        ///   &lt;Conditions&gt;
        ///     &lt;ZeroValue Key="zero" Active="Yes" Field="TOTAL" EntireRow="No" Style="zeroConditionStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Style
        {
            get => GetStaticBindingValue(_style);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(GetType().Name, "Style", value)));

                _style = value;
            }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (ConditionResult) Evaluate(int, int, FieldValueInformation): Returns result of evaluates condition
        /// <summary>
        /// Returns result of evaluates condition.
        /// </summary>
        /// <param name="row">Data row</param>
        /// <param name="col">Field column</param>
        /// <param name="target">Field data</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.Model.ConditionResult"/> object that contains evaluate result.
        /// </returns>
        public override ConditionResult Evaluate(int row, int col, FieldValueInformation target)
        {
            var remarks = new RemarksCondition
            {
                Active = Active,
                Criterial = KnownOperator.EqualTo,
                Field = Field,
                EntireRow = EntireRow,
                Locale = Locale,
                Style = Style,
                Value = "0"
            };

            return remarks.Evaluate(row, col, target);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (ZeroCondition) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public ZeroCondition Clone()
        {
            return (ZeroCondition)MemberwiseClone();
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
