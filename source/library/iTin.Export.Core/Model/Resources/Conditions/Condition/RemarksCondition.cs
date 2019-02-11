
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    /// <summary>
    /// Represents a field condition. Defines the style that will be applied to the field when it met specified condition.
    /// </summary>
    public partial class RemarksCondition : ICloneable
    {
        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownOperator _operator;
        #endregion

        #region public static readonly properties

        #region [public] {static} (RemarksCondition) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static RemarksCondition Empty => new RemarksCondition();
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

        #region [public] (KnownOperator) Criterial: Gets or sets a value that represents the criteria to apply to the field of this condition
        /// <summary>
        /// Gets or sets a value that represents the criteria to apply to the field of this condition. 
        /// </summary>
        /// <value>
        /// One of the enumeration values <see cref ="T:iTin.Export.Model.KnownOperator"/>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;RemarksValue Criterial="EqualTo|NotEqualTo|LessThan|LessOrEqualThan|GreatherThan|GreatherOrEqualsThan|In|Like|Beetween" .../&gt;
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
        ///     &lt;RemarksValue Key="eq" Active="Yes" Field="TOTAL" Criterial="EqualTo" Value="10" EntireRow="No" Style="eqTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public KnownOperator Criterial
        {
            get => (KnownOperator)Enum.Parse(typeof(KnownOperator), GetStaticBindingValue(_operator.ToString()));
            set
            {
                SentinelHelper.IsEnumValid(value);

                _operator = value;
            }
        }
        #endregion

        #region [public] (string) Style: Gets or sets a value that represents the style that is applied when the condition is met
        /// <summary>
        /// Gets or sets a value that represents the style that is applied when the condition is met.
        /// </summary>
        /// <value>
        /// A <see cref ="T:System.String"/> that represents the style that is applied when the condition is met.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;RemarksValue Style="string" .../&gt;
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
        ///     &lt;RemarksValue Key="eq" Active="Yes" Field="TOTAL" Criterial="EqualTo" Value="10" EntireRow="No" Style="eqTotalStyle"/&gt;
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

        #region [public] (string) Value: Defines the value associated with the specified condition that the condition must meet
        /// <summary>
        /// Defines the value associated with the specified condition that the condition must meet.
        /// </summary>
        /// <value>
        /// A <see cref ="T:System.String"/> that contains criterial value.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;RemarksValue Value="string" .../&gt;
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
        ///     &lt;RemarksValue Key="eq" Active="Yes" Field="TOTAL" Criterial="EqualTo" Value="10" EntireRow="No" Style="eqTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Value
        {
            get => GetStaticBindingValue(_value);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _value = value;
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
            return new ConditionResult {CanApply = EvaluateCriterial(Criterial, target, Value, Locale), Style = Style};
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (RemarksCondition) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public RemarksCondition Clone()
        {
            return (RemarksCondition)MemberwiseClone();
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) EvaluateCriterial(KnownOperator, FieldValueInformation, string, KnownCulture): Evaluates criterial
        /// <summary>
        /// Evaluates criterial
        /// </summary>
        /// <param name="op">Operator</param>
        /// <param name="context">Field data context</param>
        /// <param name="testValue">Value to evaluate</param>
        /// <param name="locale">Culture to use with field data value</param>
        /// <returns>
        /// <c>true</c> if it meets the criteria; otherwise <c>false</c>.
        /// </returns>
        private static bool EvaluateCriterial(KnownOperator op, FieldValueInformation context, string testValue, KnownCulture locale)
        {
            bool result = false;

            var culture = locale == KnownCulture.Current
                ? CultureInfo.CurrentUICulture
                : new CultureInfo(locale.ToString());

            switch (op)
            {
                #region Criterial: Beetween
                //case KnownOperator.Beetween:
                //    {
                //        var values = testValue.Split(' ').ToList();
                //        var totalValues = values.Count;
                //        if (totalValues != 2)
                //        {
                //            throw new ArgumentOutOfRangeException();
                //        }

                //        var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                //        var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                //        var leftValueAsSpanishFormat = values[0].Replace(".", ",");
                //        var okLeftValueDecimal = decimal.TryParse(leftValueAsSpanishFormat, out decimal leftValueAsDecimal);

                //        var rightValueAsSpanishFormat = values[1].Replace(".", ",");
                //        var okRightValueDecimal = decimal.TryParse(rightValueAsSpanishFormat, out decimal rightValueAsDecimal);

                //        var canContinue = okValueDecimal && okLeftValueDecimal && okRightValueDecimal;
                //        if (!canContinue)
                //        {
                //            break;
                //        }

                //        if (dataValueAsDecimal >= leftValueAsDecimal && dataValueAsDecimal >= rightValueAsDecimal)
                //        {
                //            result = true;
                //        }
                //        break;
                //    }
                #endregion

                #region Criterial: EqualTo
                case KnownOperator.EqualTo:

                    if (context.IsText)
                    {
                        var left = context.Value.ToString();
                        var right = testValue;
                        return left.Equals(right);
                    }

                    if (context.IsNumeric)
                    {
                        var left = decimal.Parse(context.Value.ToString(), culture);
                        var right = decimal.Parse(testValue, culture);
                        return left.Equals(right);
                    }

                    if (context.IsDateTime)
                    {
                        var left = DateTime.Parse(context.Value.ToString(), culture);
                        var right = DateTime.Parse(testValue, culture);

                        return left.Equals(right);
                    }
                    break;
                #endregion

                #region Criterial: GreatherOrEqualsThan
                //case KnownOperator.GreatherOrEqualsThan:
                //    {
                //        var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                //        var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                //        var testValueAsSpanishFormat = testValue.Replace(".", ",");
                //        var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                //        var canContinue = okValueDecimal && okTestValueDecimal;
                //        if (!canContinue)
                //        {
                //            break;
                //        }

                //        if (dataValueAsDecimal >= testValueAsDecimal)
                //        {
                //            result = true;
                //        }
                //        break;
                //    }
                #endregion

                #region Criterial: GreatherThan
                //case KnownOperator.GreatherThan:
                //    {
                //        var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                //        var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                //        var testValueAsSpanishFormat = testValue.Replace(".", ",");
                //        var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                //        var canContinue = okValueDecimal && okTestValueDecimal;
                //        if (!canContinue)
                //        {
                //            break;
                //        }

                //        if (dataValueAsDecimal > testValueAsDecimal)
                //        {
                //            result = true;
                //        }
                //        break;
                //    }
                #endregion

                #region Criterial: In
                //case KnownOperator.In:
                //    {
                //        var inValues = testValue.Split(' ').ToList();
                //        if (dataValue.In(inValues))
                //        {
                //            result = true;
                //        }
                //        break;
                //    }
                #endregion

                #region Criterial: LessOrEqualThan
                //case KnownOperator.LessOrEqualThan:
                //    {
                //        var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                //        var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                //        var testValueAsSpanishFormat = testValue.Replace(".", ",");
                //        var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                //        var canContinue = okValueDecimal && okTestValueDecimal;
                //        if (!canContinue)
                //        {
                //            break;
                //        }

                //        if (dataValueAsDecimal <= testValueAsDecimal)
                //        {
                //            result = true;
                //        }
                //        break;
                //    }
                #endregion

                #region Criterial: LessThan
                //case KnownOperator.LessThan:
                //    {
                //        var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                //        var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                //        var testValueAsSpanishFormat = testValue.Replace(".", ",");
                //        var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                //        var canContinue = okValueDecimal && okTestValueDecimal;
                //        if (!canContinue)
                //        {
                //            break;
                //        }

                //        if (dataValueAsDecimal < testValueAsDecimal)
                //        {
                //            result = true;
                //        }
                //        break;
                //    }
                #endregion

                #region Criterial: Like
                //case KnownOperator.Like:
                //    if (dataValue.Contains(testValue))
                //    {
                //        result = true;
                //    }
                //    break;
                #endregion

                #region Criterial: NotEqualTo
                case KnownOperator.NotEqualTo:
                    if (context.IsText)
                    {
                        var left = context.Value.ToString();
                        var right = testValue;
                        return !left.Equals(right);
                    }

                    if (context.IsNumeric)
                    {
                        var left = decimal.Parse(context.Value.ToString(), culture);
                        var right = decimal.Parse(testValue, culture);
                        return !left.Equals(right);
                    }

                    if (context.IsDateTime)
                    {
                        var left = DateTime.Parse(context.Value.ToString(), culture);
                        var right = DateTime.Parse(testValue, culture);

                        return !left.Equals(right);
                    }
                    break;
                    #endregion
            }

            return result;
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
