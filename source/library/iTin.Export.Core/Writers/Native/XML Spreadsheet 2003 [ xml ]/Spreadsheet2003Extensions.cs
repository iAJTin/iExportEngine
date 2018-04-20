
namespace iTin.Export.Writers.Native
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Text;
    using System.Xml;

    using Helper;
    using Model;

    /// <summary>
    /// Contains common extensions for <c>Xml Spreadsheet 2003</c>.
    /// </summary>
    static class Spreadsheet2003Extensions
    {
        #region [public] {static} (string) ToSpreadsheet(this FieldAggregateModel, YesNo): Gets the appropriate formula for this aggregate
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="aggregate">Aggregate model.</param>
        /// <param name="hasAutoFilter">Has auto filter.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the appropriate formula for this aggregate.
        /// </returns>
        public static string ToSpreadsheet(this FieldAggregateModel aggregate, YesNo hasAutoFilter)
        {
            var pattern = KnownSpreadsheetExpression.TopAggregateFormulaPattern;
            if (aggregate.Location == KnownAggregateLocation.Bottom)
            {
                pattern = KnownSpreadsheetExpression.BottomAggregateFormulaPattern;
            }

            var type = int.MaxValue;
            var result = string.Empty;
            if (aggregate.AggregateType != KnownAggregateType.None)
            {
                if (aggregate.AggregateType != KnownAggregateType.Text)
                {
                    switch (aggregate.AggregateType)
                    {
                        case KnownAggregateType.Average:
                            type = hasAutoFilter == YesNo.Yes ? 101 : 1;
                            break;

                        case KnownAggregateType.Count:
                            type = hasAutoFilter == YesNo.Yes ? 103 : 3;
                            break;

                        case KnownAggregateType.Max:
                            type = hasAutoFilter == YesNo.Yes ? 104 : 4;
                            break;

                        case KnownAggregateType.Min:
                            type = hasAutoFilter == YesNo.Yes ? 105 : 5;
                            break;

                        case KnownAggregateType.Sum:
                            type = hasAutoFilter == YesNo.Yes ? 109 : 9;
                            break;
                    }

                    result = string.Format(CultureInfo.InvariantCulture, pattern, type);
                }
                else
                {
                    result = aggregate.Text;
                }
            }

            return result;
        }
        #endregion

        #region [public] {static} (string) ToSpreadsheetDataFormat(this string, BaseDataTypeModel): Gets data format from model
        /// <summary>
        /// Gets data format from model.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="modelDataType">Data model.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the data format.
        /// </returns>
        public static string ToSpreadsheetDataFormat(this string format, BaseDataTypeModel modelDataType)
        {
            SentinelHelper.ArgumentNull(format);
            SentinelHelper.ArgumentNull(modelDataType);

            var formatBuilder = new StringBuilder();
            var culture = CultureInfo.CurrentCulture;
            var formatPatternsArray = format.Split(';');

            var dataFormat = modelDataType.Type;
            switch (dataFormat)
            {
                #region Type: Numeric
                case KnownDataType.Numeric:
                    var number = (NumberDataTypeModel)modelDataType;

                    var numberPositivePattern = formatPatternsArray[0];
                    var numberNegativePattern = formatPatternsArray[1];
          
                    var numberNegativeColor = number.Negative.GetColor().ToString().Split(' ')[1];
                    formatBuilder.Append(numberPositivePattern);
                    formatBuilder.Append(";");
                    formatBuilder.Append(numberNegativeColor);
                    formatBuilder.Append(@"\");
                    formatBuilder.Append(numberNegativePattern);
                    return formatBuilder.ToString();
                #endregion

                #region Type: Currency
                case KnownDataType.Currency:
                    var currency = (CurrencyDataTypeModel)modelDataType;
                    var currencyPositivePattern = formatPatternsArray[0];

                    var lcidBuilder = new StringBuilder();
                    if (currency.Locale != KnownCulture.Current)
                    {
                        culture = CultureInfo.GetCultureInfo(ExportsModel.GetXmlEnumAttributeFromItem(currency.Locale));
                        lcidBuilder.Append("[$-");
                        lcidBuilder.Append(culture.LCID.ToString("X", CultureInfo.InvariantCulture));
                        lcidBuilder.Append("]");
                    }

                    lcidBuilder.Append(currencyPositivePattern);

                    var currencyPositiveFormatPattern = lcidBuilder.ToString().Replace(culture.NumberFormat.CurrencySymbol, culture.NumberFormat.CurrencySymbol);
                    formatBuilder.Append(currencyPositiveFormatPattern);

                    var color = currency.Negative.GetColor().ToString().Split(' ')[1];
                    formatBuilder.Append(";");
                    formatBuilder.Append(color);

                    switch (currency.Negative.Sign)
                    {
                        case KnownNegativeSign.None:
                           formatBuilder.Append(currencyPositiveFormatPattern);
                           break;

                        case KnownNegativeSign.Standard:
                            formatBuilder.Append("-");
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            break;

                        case KnownNegativeSign.Parenthesis:
                            formatBuilder.Append(@"\");
                            formatBuilder.Append("(");
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            formatBuilder.Append(@"\");
                            formatBuilder.Append(")");
                            break;

                        case KnownNegativeSign.Brackets:
                            formatBuilder.Append(@"\");
                            formatBuilder.Append("[");
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            formatBuilder.Append(@"\");
                            formatBuilder.Append("]");
                            break;
                    }

                    return formatBuilder.ToString();
                #endregion

                #region Type: Percentage
                case KnownDataType.Percentage:
                    var percent = (PercentageDataTypeModel)modelDataType;

                    formatBuilder.Append("###0");
                    var percentDecimals = percent.Decimals;
                    if (percentDecimals > 0)
                    {
                        var digits = new string('0', percentDecimals);
                        formatBuilder.Append(".");
                        formatBuilder.Append(digits);
                    }

                    formatBuilder.Append("%");

                    return formatBuilder.ToString();
                #endregion

                #region Type: Scientific
                case KnownDataType.Scientific:
                    var scientific = (ScientificDataTypeModel)modelDataType;

                    formatBuilder.Append("0");
                    var scientificDecimals = scientific.Decimals;
                    if (scientificDecimals > 0)
                    {
                        var digits = new string('0', scientificDecimals);
                        formatBuilder.Append(".");
                        formatBuilder.Append(digits);
                    }

                    formatBuilder.Append("E+00");

                    return formatBuilder.ToString();
                #endregion

                #region Type: DateTime
                case KnownDataType.Datetime:
                    var datetime = (DatetimeDataTypeModel)modelDataType;

                    if (datetime.Locale != KnownCulture.Current)
                    {
                        culture = CultureInfo.GetCultureInfo(ExportsModel.GetXmlEnumAttributeFromItem(datetime.Locale));
                        formatBuilder.Append("[$-");
                        formatBuilder.Append(culture.LCID.ToString("X", CultureInfo.InvariantCulture));
                        formatBuilder.Append("]");
                    }

                    formatBuilder.Append(format);
                    return formatBuilder.ToString();
                #endregion

                #region Type: Text
                default:
                    return format;
                #endregion
            }
        }
        #endregion

        #region [public] {static} (string) ToSpreadsheetDataType(this KnownDataType): Converts generic data type to spreadsheet datatype
        /// <summary>
        /// Converts generic data type to spreadsheet data type.
        /// </summary>
        /// <param name="knowFieldValueType">Generic data type to convert.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the appropriate data type for a spreadsheet.
        /// </returns>
        public static string ToSpreadsheetDataType(this KnownDataType knowFieldValueType)
        {
            SentinelHelper.IsEnumValid(knowFieldValueType);

            switch (knowFieldValueType)
            {
                case KnownDataType.Numeric:
                case KnownDataType.Currency:
                case KnownDataType.Scientific:
                case KnownDataType.Percentage:
                    return "Number";

                case KnownDataType.Datetime:
                    return "DateTime";

                default:
                    return "String";
            }
        }
        #endregion

        #region [public] {static} (int) ToSpreadsheetPaperSize(this KnownDocumentSize): Converter for KnownDocumentSize enumeration type to int value
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownDocumentSize"/> enumeration type to <see cref="T:System.Int32"/>.
        /// </summary>
        /// <param name="paper">Paper size value from model.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> value.
        /// </returns>
        public static int ToSpreadsheetPaperSize(this KnownDocumentSize paper)
        {
            SentinelHelper.IsEnumValid(paper);

            var paperSize = 9; //// A4
            switch (paper)
            {
                case KnownDocumentSize.A0:
                    break;

                case KnownDocumentSize.A1:
                    break;

                case KnownDocumentSize.A2:
                    break;

                case KnownDocumentSize.A3:
                    paperSize = 8;
                    break;

                case KnownDocumentSize.A5:
                    break;

                case KnownDocumentSize.A6:
                    break;

                case KnownDocumentSize.A7:
                    break;

                case KnownDocumentSize.A8:
                    break;

                case KnownDocumentSize.A9:
                    break;

                case KnownDocumentSize.A10:
                    break;

                case KnownDocumentSize.Executive:
                    paperSize = 7;
                    break;

                case KnownDocumentSize.HalfLetter:
                    break;

                case KnownDocumentSize.Letter:
                    break;

                case KnownDocumentSize.Note:
                    break;

                case KnownDocumentSize.PostCard:
                    break;
            }

            return paperSize;
        }
        #endregion

        #region [public] {static} (void) WriteDataFieldErrorComment(this XmlWriter, string, Style): Writes a error comment for specified field
        /// <summary>
        /// Writes a error comment for specified field.
        /// </summary>
        /// <param name="writer">Xml Writer</param>
        /// <param name="fieldName">Data field name</param>
        /// <param name="style">Field style</param>
        public static void WriteDataFieldErrorComment(this XmlWriter writer, string fieldName, StyleModel style)
        {                                
            var xmlFieldName = $"@{fieldName}";
            var autorComment = $"{Environment.MachineName}\\{Environment.UserName}";

            CommentModel commentModel = null;
            var conditionBuilder = new StringBuilder();

            var dataType = style.Content.DataType.Type;
            switch (dataType)
            {
                #region DataType: Number, Currency
                case KnownDataType.Numeric:
                case KnownDataType.Currency:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", xmlFieldName);
                    commentModel = ((NumericDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: DateTime
                case KnownDataType.Datetime:
                    conditionBuilder.AppendFormat("ms:format-date({0}, 'yyyy-MM-dd')=''", xmlFieldName);
                    commentModel = ((DatetimeDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: Percentage
                case KnownDataType.Percentage:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", xmlFieldName);
                    commentModel = ((PercentageDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: Scientific
                case KnownDataType.Scientific:
                    conditionBuilder.AppendFormat("string(ms:number({0}))='NaN'", xmlFieldName);
                    commentModel = ((ScientificDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: Text
                case KnownDataType.Text:
                    break;
                #endregion
            }

            if (commentModel == null)
            {
                return;
            }

            var showComment = commentModel.Show == YesNo.Yes;
            if (!showComment)
            {
                return;
            }

            writer.WriteXsltStartIf(conditionBuilder.ToString());
                Spreadsheet2003Helper.WriteErrorComment(writer, xmlFieldName, commentModel, autorComment);
            writer.WriteXsltEndIf();
        }
        #endregion

        #region [public] {static} (void) WriteDataFieldErrorComment(this XmlWriter, FixedFieldModel, Style): Writes a error comment for specified field
        /// <summary>
        /// Writes a error comment for specified field.
        /// </summary>
        /// <param name="writer">Xml Writer</param>
        /// <param name="field">Fixed data field.</param>
        /// <param name="style">Field style</param>
        public static void WriteDataFieldErrorComment(this XmlWriter writer, FixedFieldModel field, StyleModel style)
        {
            var xmlFieldName = string.Format(CultureInfo.InvariantCulture, "${0}_{1}", field.Pieces, field.Piece);
            var autorComment = string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", Environment.MachineName, Environment.UserName);

            CommentModel commentModel = null;
            var conditionBuilder = new StringBuilder();

            var dataType = style.Content.DataType.Type;
            switch (dataType)
            {
                #region DataType: Number, Currency
                case KnownDataType.Numeric:
                case KnownDataType.Currency:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", xmlFieldName);
                    commentModel = ((NumericDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: DateTime
                case KnownDataType.Datetime:
                    conditionBuilder.AppendFormat("ms:format-date({0}, 'yyyy-MM-dd')=''", xmlFieldName);
                    commentModel = ((DatetimeDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: Percentage
                case KnownDataType.Percentage:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", xmlFieldName);
                    commentModel = ((PercentageDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: Scientific
                case KnownDataType.Scientific:
                    conditionBuilder.AppendFormat("string(ms:number({0}))='NaN'", xmlFieldName);
                    commentModel = ((ScientificDataTypeModel)style.Content.DataType).Error.Comment;
                    break;
                #endregion

                #region DataType: Text
                case KnownDataType.Text:
                    break;
                #endregion
            }

            if (commentModel == null)
            {
                return;
            }

            var showComment = commentModel.Show == YesNo.Yes;
            if (!showComment)
            {
                return;
            }

            writer.WriteXsltStartIf(conditionBuilder.ToString());
                Spreadsheet2003Helper.WriteErrorComment(writer, xmlFieldName, commentModel, autorComment);
            writer.WriteXsltEndIf();
        }
        #endregion

        #region [public] {static} (string) WriteTestSpreadsheet2003Field(this XmlWriter, string, StyleModel, string): Writes a test for specified data field and returns the appropiate format for this data field
        /// <summary>
        /// Writes a test for specified data field and returns the appropriate format for this data field.
        /// </summary>
        /// <param name="writer">Xml Writer</param>
        /// <param name="fieldName">Data field name.</param>
        /// <param name="style">Field style.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> containing the appropriate format for this data field.
        /// </returns>
        public static string WriteTestSpreadsheet2003Field(this XmlWriter writer, string fieldName, StyleModel style)
        {
            var variableBuilder = new StringBuilder();
            variableBuilder.AppendFormat("testValueOf{0}", fieldName);

            var otherwiseBuilder = new StringBuilder();
            otherwiseBuilder.AppendFormat("normalize-space(@{0})", fieldName);

            var valueBuilder = new StringBuilder();
            var conditionBuilder = new StringBuilder();

            var dataType = style.Content.DataType.Type;
            switch (dataType)
            {
                #region DataType: Currency, Number
                case KnownDataType.Numeric:
                case KnownDataType.Currency:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", otherwiseBuilder);

                    var numericErrorModel = ((NumericDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                            writer.WriteXsltStartWhen(conditionBuilder.ToString(), numericErrorModel.Value);
                            writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();
                    valueBuilder.AppendFormat("${0}", variableBuilder);
                    break;
                #endregion

                #region DataType: DateTime
                case KnownDataType.Datetime:  
                    conditionBuilder = new StringBuilder();
                    conditionBuilder.AppendFormat("ms:format-date({0}, 'yyyy-MM-dd')=''", otherwiseBuilder);

                    var datatimeErrorModel = ((DatetimeDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                            writer.WriteXsltStartWhen(conditionBuilder.ToString(), datatimeErrorModel.DateTimeValue);
                            writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();

                    var dateBuilder = new StringBuilder();
                    var timeBuilder = new StringBuilder();
                    dateBuilder.AppendFormat("ms:format-date(${0}, 'yyyy-MM-dd')", variableBuilder);
                    timeBuilder.AppendFormat("ms:format-time(${0}, 'HH:mm:ss')", variableBuilder);

                    valueBuilder.AppendFormat("concat({0}, 'T', {1})", dateBuilder, timeBuilder);
                    break;
                #endregion

                #region DataType: Percentage
                case KnownDataType.Percentage:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", otherwiseBuilder);

                    var percentageErrorModel = ((PercentageDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                            writer.WriteXsltStartWhen(conditionBuilder.ToString(), percentageErrorModel.Value);
                            writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();
                    valueBuilder.AppendFormat("${0} div 100", variableBuilder);
                break;
                #endregion

                #region DataType: Scientific
                case KnownDataType.Scientific:
                    conditionBuilder.AppendFormat("string(ms:number({0}))='NaN'", otherwiseBuilder);

                    var scientificErrorModel = ((ScientificDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                            writer.WriteXsltStartWhen(conditionBuilder.ToString(), scientificErrorModel.Value);
                            writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();

                    valueBuilder.AppendFormat("ms:number(${0})", variableBuilder);
                    break;
                #endregion

                ////#region DataType: Special
                ////case KnownDataType.Special:
                ////    var special = (SpecialDataTypeModel)style.Content.DataType;
                ////    var format = special.Format;

                ////    var concatVariableBuilder = new StringBuilder();
                ////    concatVariableBuilder.AppendFormat("concat{0}", fieldName);

                ////    var substringVariableBuilder = new StringBuilder();
                ////    substringVariableBuilder.AppendFormat("substring{0}", fieldName);

                ////    var concatVariableValueBuilder = new StringBuilder();
                ////    var substringVariableValueBuilder = new StringBuilder();
                ////    var resultVariableValueBuilder = new StringBuilder();

                ////    switch (format)
                ////    {
                ////        #region Format: ShortDateFormat '99/99/99'
                ////        case KnownSpecialFormat.ShortDateFormat:
                ////            concatVariableValueBuilder.AppendFormat("concat('000000', {0})", otherwiseBuilder);
                ////            substringVariableValueBuilder.AppendFormat("substring(${0}, string-length(${0}) - 5, 6)", concatVariableBuilder);
                ////            resultVariableValueBuilder.AppendFormat("concat(substring(${0}, 1, 2), '/', substring(${0}, 3, 2), '/', substring(${0}, 5, 2))", substringVariableBuilder);

                ////            conditionBuilder.AppendFormat("{0}='0'", otherwiseBuilder);

                ////            writer.WriteXsltStartVariable(variableBuilder.ToString());
                ////                writer.WriteXsltStartChoose();
                ////                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), string.Empty);
                ////                    writer.WriteXsltEndWhen();
                ////                    writer.WriteXsltStartOtherwise();

                ////                        writer.WriteXsltStartVariable(concatVariableBuilder.ToString());
                ////                            writer.WriteStartElement("xsl:value-of");
                ////                                writer.WriteAttributeString("select", concatVariableValueBuilder.ToString());
                ////                            writer.WriteEndElement();
                ////                        writer.WriteXsltEndVariable();

                ////                        writer.WriteXsltStartVariable(substringVariableBuilder.ToString());
                ////                            writer.WriteStartElement("xsl:value-of");
                ////                                writer.WriteAttributeString("select", substringVariableValueBuilder.ToString());
                ////                            writer.WriteEndElement();
                ////                        writer.WriteXsltEndVariable();

                ////                        writer.WriteStartElement("xsl:value-of");
                ////                        writer.WriteAttributeString("select", resultVariableValueBuilder.ToString());
                ////                        writer.WriteEndElement();

                ////                    writer.WriteXsltEndOtherwise();
                ////                writer.WriteXsltEndChoose();
                ////            writer.WriteXsltEndVariable();

                ////            valueBuilder.AppendFormat("${0}", variableBuilder);
                ////            break;
                ////        #endregion

                ////        #region Format: LongDateFormat '99/99/9999'
                ////        case KnownSpecialFormat.LongDateFormat:
                ////            concatVariableValueBuilder.AppendFormat("concat('00000000', {0})", otherwiseBuilder);
                ////            substringVariableValueBuilder.AppendFormat("substring(${0}, string-length(${0}) - 7, 8)", concatVariableBuilder);
                ////            resultVariableValueBuilder.AppendFormat("concat(substring(${0}, 1, 2), '/', substring(${0}, 3, 2), '/', substring(${0}, 5, 4))", substringVariableBuilder);

                ////            conditionBuilder.AppendFormat("{0}='0'", otherwiseBuilder);

                ////            writer.WriteXsltStartVariable(variableBuilder.ToString());
                ////                writer.WriteXsltStartChoose();
                ////                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), string.Empty);
                ////                writer.WriteXsltEndWhen();
                ////            writer.WriteXsltStartOtherwise();

                ////            writer.WriteXsltStartVariable(concatVariableBuilder.ToString());
                ////                writer.WriteStartElement("xsl:value-of");
                ////                    writer.WriteAttributeString("select", concatVariableValueBuilder.ToString());
                ////                writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteXsltStartVariable(substringVariableBuilder.ToString());
                ////                writer.WriteStartElement("xsl:value-of");
                ////                    writer.WriteAttributeString("select", substringVariableValueBuilder.ToString());
                ////                writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteStartElement("xsl:value-of");
                ////                writer.WriteAttributeString("select", resultVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();

                ////            writer.WriteXsltEndOtherwise();
                ////                writer.WriteXsltEndChoose();
                ////            writer.WriteXsltEndVariable();

                ////            valueBuilder.AppendFormat("${0}", variableBuilder);
                ////            break;
                ////        #endregion
                ////    }

                ////    break;
                ////#endregion

                #region DateType: Text
                case KnownDataType.Text:
                    valueBuilder = otherwiseBuilder;
                    break;
                #endregion
            }

            return valueBuilder.ToString();
        }
        #endregion

        #region [public] {static} (string) WriteTestSpreadsheet2003Field(this XmlWriter, FixedFieldModel, FixedItemModel, StyleModel): Writes a test for specified data field and returns the appropiate format for this data field
        /// <summary>
        /// Writes a test for specified fixed data field and returns the appropriate format for this data field.
        /// </summary>
        /// <param name="writer">Xml Writer</param>
        /// <param name="field">Fixed data field.</param>
        /// <param name="fixedwidth">Piece collection.</param>
        /// <param name="style">Field style.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the appropriate format for this data field.
        /// </returns>
        public static string WriteTestSpreadsheet2003Field(this XmlWriter writer, FixedFieldModel field, FixedItemModel fixedwidth, StyleModel style)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.ArgumentNull(style);
            SentinelHelper.ArgumentNull(field);
            SentinelHelper.ArgumentNull(fixedwidth);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(field.Piece));
           
            var pieceModel = fixedwidth.Pieces[field.Piece];

            var previousVariableBuilder = new StringBuilder();
            previousVariableBuilder.AppendFormat("{0}_{1}", field.Pieces, field.Piece);

            var selectBuilder = new StringBuilder();
            selectBuilder.AppendFormat("substring(@{0}, {1}, {2})", fixedwidth.Reference, pieceModel.From, pieceModel.Lenght);

            writer.WriteXsltStartVariable(previousVariableBuilder.ToString());
                writer.WriteAttributeString("select", selectBuilder.ToString());
            writer.WriteXsltEndVariable();

            var variableBuilder = new StringBuilder();
            variableBuilder.AppendFormat("testValueOf{0}", previousVariableBuilder);

            var otherwiseBuilder = new StringBuilder();
            otherwiseBuilder.AppendFormat("normalize-space(${0})", previousVariableBuilder);

            var valueBuilder = new StringBuilder();
            var conditionBuilder = new StringBuilder();

            var dataType = style.Content.DataType.Type;
            switch (dataType)
            {
                #region DataType: Currency, Number
                case KnownDataType.Currency:
                case KnownDataType.Numeric:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", otherwiseBuilder);

                    var numericErrorModel = ((NumericDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                            writer.WriteXsltStartWhen(conditionBuilder.ToString(), numericErrorModel.Value);
                            writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();
                    valueBuilder.AppendFormat("${0}", variableBuilder);
                    break;
                #endregion

                #region DataType: DateTime
                case KnownDataType.Datetime:
                    conditionBuilder = new StringBuilder();
                    conditionBuilder.AppendFormat("ms:format-date({0}, 'yyyy-MM-dd')=''", otherwiseBuilder);

                    var datatimeErrorModel = ((DatetimeDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                            writer.WriteXsltStartWhen(conditionBuilder.ToString(), datatimeErrorModel.DateTimeValue);
                            writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();

                    var dateBuilder = new StringBuilder();
                    var timeBuilder = new StringBuilder();
                    dateBuilder.AppendFormat("ms:format-date(${0}, 'yyyy-MM-dd')", variableBuilder);
                    timeBuilder.AppendFormat("ms:format-time(${0}, 'HH:mm:ss')", variableBuilder);

                    valueBuilder.AppendFormat("concat({0}, 'T', {1})", dateBuilder, timeBuilder);
                    break;
                #endregion

                #region DataType: Percentage
                case KnownDataType.Percentage:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", otherwiseBuilder);

                    var percentageErrorModel = ((PercentageDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                        writer.WriteXsltStartWhen(conditionBuilder.ToString(), percentageErrorModel.Value);
                        writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();
                    valueBuilder.AppendFormat("${0} div 100", variableBuilder);
                    break;
                #endregion

                #region DataType: Scientific
                case KnownDataType.Scientific:
                    conditionBuilder.AppendFormat("string(ms:number({0}))='NaN'", otherwiseBuilder);

                    var scientificErrorModel = ((ScientificDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                        writer.WriteXsltStartChoose();
                        writer.WriteXsltStartWhen(conditionBuilder.ToString(), scientificErrorModel.Value);
                        writer.WriteXsltEndWhen();
                            writer.WriteXsltStartOtherwise();
                                writer.WriteStartElement("xsl:value-of");
                                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                                writer.WriteEndElement();
                            writer.WriteXsltEndOtherwise();
                        writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();

                    valueBuilder.AppendFormat("ms:number(${0})", variableBuilder);
                    break;
                #endregion

                ////#region DataType: Special
                ////case KnownDataType.Special:
                ////    var special = (SpecialDataTypeModel)style.Content.DataType;
                ////    var format = special.Format;

                ////    var concatVariableBuilder = new StringBuilder();
                ////    concatVariableBuilder.AppendFormat("concat{0}", previousVariableBuilder);

                ////    var substringVariableBuilder = new StringBuilder();
                ////    substringVariableBuilder.AppendFormat("substring{0}", previousVariableBuilder);

                ////    var concatVariableValueBuilder = new StringBuilder();
                ////    var substringVariableValueBuilder = new StringBuilder();
                ////    var resultVariableValueBuilder = new StringBuilder();

                ////    switch (format)
                ////    {
                ////        #region Format: ShortDateFormat '99/99/99'
                ////        case KnownSpecialFormat.ShortDateFormat:
                ////            concatVariableValueBuilder.AppendFormat("concat('000000', {0})", otherwiseBuilder);
                ////            substringVariableValueBuilder.AppendFormat("substring(${0}, string-length(${0}) - 5, 6)", concatVariableBuilder);
                ////            resultVariableValueBuilder.AppendFormat("concat(substring(${0}, 1, 2), '/', substring(${0}, 3, 2), '/', substring(${0}, 5, 2))", substringVariableBuilder);

                ////            conditionBuilder.AppendFormat("{0}='0'", otherwiseBuilder);

                ////            writer.WriteXsltStartVariable(variableBuilder.ToString());
                ////                writer.WriteXsltStartChoose();
                ////                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), string.Empty);
                ////                writer.WriteXsltEndWhen();
                ////            writer.WriteXsltStartOtherwise();

                ////            writer.WriteXsltStartVariable(concatVariableBuilder.ToString());
                ////                writer.WriteStartElement("xsl:value-of");
                ////                    writer.WriteAttributeString("select", concatVariableValueBuilder.ToString());
                ////                writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteXsltStartVariable(substringVariableBuilder.ToString());
                ////                writer.WriteStartElement("xsl:value-of");
                ////                    writer.WriteAttributeString("select", substringVariableValueBuilder.ToString());
                ////                writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteStartElement("xsl:value-of");
                ////                writer.WriteAttributeString("select", resultVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();

                ////            writer.WriteXsltEndOtherwise();
                ////                writer.WriteXsltEndChoose();
                ////            writer.WriteXsltEndVariable();

                ////            valueBuilder.AppendFormat("${0}", variableBuilder);
                ////            break;
                ////        #endregion

                ////        #region Format: LongDateFormat '99/99/9999'
                ////        case KnownSpecialFormat.LongDateFormat:
                ////            concatVariableValueBuilder.AppendFormat("concat('00000000', {0})", otherwiseBuilder);
                ////            substringVariableValueBuilder.AppendFormat("substring(${0}, string-length(${0}) - 7, 8)", concatVariableBuilder);
                ////            resultVariableValueBuilder.AppendFormat("concat(substring(${0}, 1, 2), '/', substring(${0}, 3, 2), '/', substring(${0}, 5, 4))", substringVariableBuilder);

                ////            conditionBuilder.AppendFormat("{0}='0'", otherwiseBuilder);

                ////            writer.WriteXsltStartVariable(variableBuilder.ToString());
                ////                writer.WriteXsltStartChoose();
                ////                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), string.Empty);
                ////                writer.WriteXsltEndWhen();
                ////            writer.WriteXsltStartOtherwise();

                ////            writer.WriteXsltStartVariable(concatVariableBuilder.ToString());
                ////                writer.WriteStartElement("xsl:value-of");
                ////                    writer.WriteAttributeString("select", concatVariableValueBuilder.ToString());
                ////                writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteXsltStartVariable(substringVariableBuilder.ToString());
                ////                writer.WriteStartElement("xsl:value-of");
                ////                    writer.WriteAttributeString("select", substringVariableValueBuilder.ToString());
                ////                writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteStartElement("xsl:value-of");
                ////                writer.WriteAttributeString("select", resultVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();

                ////            writer.WriteXsltEndOtherwise();
                ////                writer.WriteXsltEndChoose();
                ////            writer.WriteXsltEndVariable();

                ////            valueBuilder.AppendFormat("${0}", variableBuilder);
                ////            break;
                ////        #endregion
                ////    }

                ////    break;
                ////#endregion

                #region DateType: Text
                case KnownDataType.Text:
                    valueBuilder = otherwiseBuilder;
                    break;
                #endregion
            }

            return valueBuilder.ToString();
        }
        #endregion

        #region [public] {static} (string) WriteTestSpreadsheet2003Field(this XmlWriter, GroupFieldModel, GroupModel): Writes a test for specified group field and returns the appropiate format for this data field
        /// <summary>
        /// Writes a test for specified group field and returns the appropriate format for this data field.
        /// </summary>
        /// <param name="writer">Xml Writer.</param>
        /// <param name="field">Group data field.</param>
        /// <param name="groupModel">Group model.</param>
        /// <param name="table">The table.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the appropriate format for this group field.
        /// </returns>
        [SuppressMessage("Microsoft.Globalization", "CA1303:No pasar cadenas literal como parámetros localizados", MessageId = "System.Xml.XmlWriter.WriteComment(System.String)")]
        public static string WriteTestSpreadsheet2003Field(this XmlWriter writer, GroupFieldModel field, GroupModel groupModel, TableModel table)
        {
            var fieldName = field.Name;
            writer.WriteComment(string.Format(CultureInfo.InvariantCulture, "No test available for '{0}'", fieldName));

            var isDataField = true;
            var pieceBuilder = new StringBuilder();
            var expressionBuilder = new StringBuilder();
            foreach (var fld in groupModel.Fields)
            {
                var separator = GroupFieldModel.GetSeparatorChar(fld.Separator);
                if (fld.Separator.Equals("New Line", StringComparison.OrdinalIgnoreCase))
                {
                    separator = KnownItemGroupSeparator.NewLineSeparatorForXmlFormat;
                }

                var fix = groupModel.Owner.Parent.Fixed;
                foreach (var fixedwidth in fix)
                {
                    var piece = fixedwidth.Pieces[fld.Name];
                    if (piece == null)
                    {
                        continue;
                    }

                    isDataField = false;
                    pieceBuilder.Clear();
                    pieceBuilder.AppendFormat("substring(@{0}, {1}, {2})", fixedwidth.Reference, piece.From + 1, piece.Lenght);
                    expressionBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}, '{1}', ", pieceBuilder, separator);
                    break;
                }

                if (isDataField)
                {
                    expressionBuilder.AppendFormat(CultureInfo.InvariantCulture, "@{0}, '{1}', ", fld.Name, separator);
                }
            }

            // Remove the last 'comma' in the expression.
            var expression = expressionBuilder.ToString().Remove(expressionBuilder.ToString().Length - 2);
            var value = string.Concat("concat(", expression, ")");

            var style = table.Parent.Resources.Styles[field.Value.Style];

            var variableBuilder = new StringBuilder();
            variableBuilder.AppendFormat("testValueOf{0}", field.Name);

            var otherwiseBuilder = new StringBuilder();
            otherwiseBuilder.AppendFormat("normalize-space({0})", value);

            var valueBuilder = new StringBuilder();
            var conditionBuilder = new StringBuilder();

            var dataType = style.Content.DataType.Type;
            switch (dataType)
            {
                #region DataType: Currency, Number
                case KnownDataType.Numeric:
                case KnownDataType.Currency:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", otherwiseBuilder);

                    var numericErrorModel = ((NumericDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                    writer.WriteXsltStartChoose();
                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), numericErrorModel.Value);
                    writer.WriteXsltEndWhen();
                    writer.WriteXsltStartOtherwise();
                    writer.WriteStartElement("xsl:value-of");
                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                    writer.WriteEndElement();
                    writer.WriteXsltEndOtherwise();
                    writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();
                    valueBuilder.AppendFormat("${0}", variableBuilder);
                    break;
                #endregion

                #region DataType: DateTime
                case KnownDataType.Datetime:
                    conditionBuilder = new StringBuilder();
                    conditionBuilder.AppendFormat("ms:format-date({0}, 'yyyy-MM-dd')=''", otherwiseBuilder);

                    var datatimeErrorModel = ((DatetimeDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                    writer.WriteXsltStartChoose();
                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), datatimeErrorModel.DateTimeValue);
                    writer.WriteXsltEndWhen();
                    writer.WriteXsltStartOtherwise();
                    writer.WriteStartElement("xsl:value-of");
                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                    writer.WriteEndElement();
                    writer.WriteXsltEndOtherwise();
                    writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();

                    var dateBuilder = new StringBuilder();
                    var timeBuilder = new StringBuilder();
                    dateBuilder.AppendFormat("ms:format-date(${0}, 'yyyy-MM-dd')", variableBuilder);
                    timeBuilder.AppendFormat("ms:format-time(${0}, 'HH:mm:ss')", variableBuilder);

                    valueBuilder.AppendFormat("concat({0}, 'T', {1})", dateBuilder, timeBuilder);
                    break;
                #endregion

                #region DataType: Percentage
                case KnownDataType.Percentage:
                    conditionBuilder.AppendFormat("string(number({0}))='NaN'", otherwiseBuilder);

                    var percentageErrorModel = ((PercentageDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                    writer.WriteXsltStartChoose();
                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), percentageErrorModel.Value);
                    writer.WriteXsltEndWhen();
                    writer.WriteXsltStartOtherwise();
                    writer.WriteStartElement("xsl:value-of");
                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                    writer.WriteEndElement();
                    writer.WriteXsltEndOtherwise();
                    writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();
                    valueBuilder.AppendFormat("${0} div 100", variableBuilder);
                    break;
                #endregion

                #region DataType: Scientific
                case KnownDataType.Scientific:
                    conditionBuilder.AppendFormat("string(ms:number({0}))='NaN'", otherwiseBuilder);

                    var scientificErrorModel = ((ScientificDataTypeModel)style.Content.DataType).Error;
                    writer.WriteXsltStartVariable(variableBuilder.ToString());
                    writer.WriteXsltStartChoose();
                    writer.WriteXsltStartWhen(conditionBuilder.ToString(), scientificErrorModel.Value);
                    writer.WriteXsltEndWhen();
                    writer.WriteXsltStartOtherwise();
                    writer.WriteStartElement("xsl:value-of");
                    writer.WriteAttributeString("select", otherwiseBuilder.ToString());
                    writer.WriteEndElement();
                    writer.WriteXsltEndOtherwise();
                    writer.WriteXsltEndChoose();
                    writer.WriteXsltEndVariable();

                    valueBuilder.AppendFormat("ms:number(${0})", variableBuilder);
                    break;
                #endregion

                ////#region DataType: Special
                ////case KnownDataType.Special:
                ////    var special = (SpecialDataTypeModel)style.Content.DataType;
                ////    var format = special.Format;

                ////    var concatVariableBuilder = new StringBuilder();
                ////    concatVariableBuilder.AppendFormat("concat{0}", fieldName);

                ////    var substringVariableBuilder = new StringBuilder();
                ////    substringVariableBuilder.AppendFormat("substring{0}", fieldName);

                ////    var concatVariableValueBuilder = new StringBuilder();
                ////    var substringVariableValueBuilder = new StringBuilder();
                ////    var resultVariableValueBuilder = new StringBuilder();

                ////    switch (format)
                ////    {
                ////        #region Format: ShortDateFormat '99/99/99'
                ////        case KnownSpecialFormat.ShortDateFormat:
                ////            concatVariableValueBuilder.AppendFormat("concat('000000', {0})", otherwiseBuilder);
                ////            substringVariableValueBuilder.AppendFormat("substring(${0}, string-length(${0}) - 5, 6)", concatVariableBuilder);
                ////            resultVariableValueBuilder.AppendFormat("concat(substring(${0}, 1, 2), '/', substring(${0}, 3, 2), '/', substring(${0}, 5, 2))", substringVariableBuilder);

                ////            conditionBuilder.AppendFormat("{0}='0'", otherwiseBuilder);

                ////            writer.WriteXsltStartVariable(variableBuilder.ToString());
                ////            writer.WriteXsltStartChoose();
                ////            writer.WriteXsltStartWhen(conditionBuilder.ToString(), string.Empty);
                ////            writer.WriteXsltEndWhen();
                ////            writer.WriteXsltStartOtherwise();

                ////            writer.WriteXsltStartVariable(concatVariableBuilder.ToString());
                ////            writer.WriteStartElement("xsl:value-of");
                ////            writer.WriteAttributeString("select", concatVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteXsltStartVariable(substringVariableBuilder.ToString());
                ////            writer.WriteStartElement("xsl:value-of");
                ////            writer.WriteAttributeString("select", substringVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteStartElement("xsl:value-of");
                ////            writer.WriteAttributeString("select", resultVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();

                ////            writer.WriteXsltEndOtherwise();
                ////            writer.WriteXsltEndChoose();
                ////            writer.WriteXsltEndVariable();

                ////            valueBuilder.AppendFormat("${0}", variableBuilder);
                ////            break;
                ////        #endregion

                ////        #region Format: LongDateFormat '99/99/9999'
                ////        case KnownSpecialFormat.LongDateFormat:
                ////            concatVariableValueBuilder.AppendFormat("concat('00000000', {0})", otherwiseBuilder);
                ////            substringVariableValueBuilder.AppendFormat("substring(${0}, string-length(${0}) - 7, 8)", concatVariableBuilder);
                ////            resultVariableValueBuilder.AppendFormat("concat(substring(${0}, 1, 2), '/', substring(${0}, 3, 2), '/', substring(${0}, 5, 4))", substringVariableBuilder);

                ////            conditionBuilder.AppendFormat("{0}='0'", otherwiseBuilder);

                ////            writer.WriteXsltStartVariable(variableBuilder.ToString());
                ////            writer.WriteXsltStartChoose();
                ////            writer.WriteXsltStartWhen(conditionBuilder.ToString(), string.Empty);
                ////            writer.WriteXsltEndWhen();
                ////            writer.WriteXsltStartOtherwise();

                ////            writer.WriteXsltStartVariable(concatVariableBuilder.ToString());
                ////            writer.WriteStartElement("xsl:value-of");
                ////            writer.WriteAttributeString("select", concatVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteXsltStartVariable(substringVariableBuilder.ToString());
                ////            writer.WriteStartElement("xsl:value-of");
                ////            writer.WriteAttributeString("select", substringVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();
                ////            writer.WriteXsltEndVariable();

                ////            writer.WriteStartElement("xsl:value-of");
                ////            writer.WriteAttributeString("select", resultVariableValueBuilder.ToString());
                ////            writer.WriteEndElement();

                ////            writer.WriteXsltEndOtherwise();
                ////            writer.WriteXsltEndChoose();
                ////            writer.WriteXsltEndVariable();

                ////            valueBuilder.AppendFormat("${0}", variableBuilder);
                ////            break;
                ////        #endregion
                ////    }

                ////    break;
                ////#endregion

                #region DateType: Text
                case KnownDataType.Text:
                    valueBuilder = otherwiseBuilder;
                    break;
                #endregion
            }

            return valueBuilder.ToString();
        }
        #endregion
    }
}
