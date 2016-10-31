using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using iTin.Export.Model;

namespace iTin.Export.Helper
{
    /// <summary> 
    /// Static class than contains methods for creates error messages.
    /// </summary>
    static class ErrorMessageHelper
    {
        #region [public] {static} (StringBuilder) FieldIdentifierNameErrorMessage(string, string, string): Returns a StringBuilder than contains the error message for wrong field identifier.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong field identifier.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="attribute">The attribute.</param>
        /// <param name="attributeValue">The value attribute.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> that contains the error message.
        /// </returns>
        public static StringBuilder FieldIdentifierNameErrorMessage(string element, string attribute, string attributeValue)
        {
            var message = new StringBuilder();

            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorHeaderText, Resources.ErrorMessage.InvalidFieldNameText);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorSimpleElementLine, element);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorAttributeLine, attribute, attributeValue);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorCommentLine, Resources.ErrorMessage.FieldText, Resources.ErrorMessage.ModelFieldNameValidSpecialChars);

            return message;
        }
        #endregion

        #region [public] {static} (StringBuilder) FormatFieldErrorMessage(Dictionary<BaseDataFieldModel, List<string>>): Returns a StringBuilder than contains the error message for wrong field definitions.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong field definitions.
        /// </summary>
        /// <param name="messageDictionary">Data dictionary to format.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> than contains the formatted error message.
        /// </returns>
        public static StringBuilder FormatFieldErrorMessage(Dictionary<BaseDataFieldModel, List<string>> messageDictionary)
        {
            var message = new StringBuilder();

            message.AppendLine();
            message.AppendFormat(Resources.ErrorMessage.ModelErrorHeaderText, Resources.ErrorMessage.InvalidFieldDefinitionListText);
            message.AppendLine();
            foreach (var entry in messageDictionary)
            {
                switch (entry.Key.FieldType)
                {
                    case KnownFieldType.Group:
                        var groupField = (GroupFieldModel)entry.Key;
                        message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelGroupFieldDefinitionErrorText, groupField.Name);
                        message.AppendLine();
                        break;

                    case KnownFieldType.Fixed:
                        var fixedField = (FixedFieldModel)entry.Key;
                        if (entry.Value.First().Equals("Pieces"))
                        {
                            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelFixedFieldDefinitionErrorText, fixedField.Pieces);
                        }
                        else
                        {
                            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelPieceDefinitionErrorText, fixedField.Piece, fixedField.Pieces);                          
                        }

                        message.AppendLine();
                        break;
                }
            }

            return message;
        }
        #endregion

        #region [public] {static} (StringBuilder) FormatSeriesErrorMessage(Dictionary<ChartSerieModel, List<string>>): Returns a StringBuilder than contains the error message for wrong series definitions.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong series definitions.
        /// </summary>
        /// <param name="messageDictionary">Data dictionary to format.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> than contains the formatted error message.
        /// </returns>
        public static StringBuilder FormatSeriesErrorMessage(Dictionary<ChartSerieModel, List<string>> messageDictionary)
        {
            var message = new StringBuilder();

            message.AppendLine();
            message.Append(Resources.ErrorMessage.InvalidSerieDefinitionListText);
            message.AppendLine();

            foreach (var entry in messageDictionary)
            {
                var serie = entry.Key;
                var index = serie.Owner.IndexOf(serie);

                message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelChartSerieDefinitionErrorText, index);
                message.AppendLine();

                foreach (var item in entry.Value)
                {
                    message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelChartSerieFieldDefinitionErrorText, item, serie.Field);
                    message.AppendLine();
                }                
            }

            message.Append(Resources.ErrorMessage.ModelChartSeriesErrorCommentLine);
            return message;
        }
        #endregion

        #region [public] {static} (StringBuilder) FormatStyleErrorMessage(Dictionary<BaseDataFieldModel, List<string>>): Returns a StringBuilder than contains the error message for wrong field style definitions.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong field style definitions.
        /// </summary>
        /// <param name="messageDictionary">Data dictionary to format.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> than contains the formatted error message.
        /// </returns>
        public static StringBuilder FormatStyleErrorMessage(Dictionary<BaseDataFieldModel, List<string>> messageDictionary)
        {
            var message = new StringBuilder();

            message.Append(Resources.ErrorMessage.StyleErrorFormatMessageHeader);
            message.AppendLine();

            foreach (var entry in messageDictionary)
            {
                switch (entry.Key.FieldType)
                {
                    #region Fixed Field
                    case KnownFieldType.Fixed:
                        var fixedField = (FixedFieldModel)entry.Key;

                        var qualifiedFieldNameBuilder = new StringBuilder();
                        qualifiedFieldNameBuilder.Append(fixedField.Piece);
                        qualifiedFieldNameBuilder.Append(" [ ");
                        qualifiedFieldNameBuilder.Append(fixedField.Pieces);
                        qualifiedFieldNameBuilder.Append(" ]");

                        message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.StyleErrorFormatMessageFieldLine, qualifiedFieldNameBuilder, fixedField.Alias);
                        message.AppendLine();

                        foreach (var style in entry.Value)
                        {
                            var styleValue = style.Equals("Header")
                                                    ? fixedField.Header.Style
                                                    : fixedField.Value.Style;
                            message.AppendFormat(CultureInfo.InvariantCulture, Resources.ErrorMessage.StyleErrorFormatMessageNotFound, style, styleValue, Environment.NewLine);
                            message.AppendLine();
                        }

                        break;
                    #endregion

                    #region Gap Field
                    case KnownFieldType.Gap:
                        var gapField = (GapFieldModel)entry.Key;

                        message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.StyleErrorFormatMessageFieldLine, "[Gap Field]", gapField.Alias);
                        message.AppendLine();

                        foreach (var style in entry.Value)
                        {
                            var styleValue = style.Equals("Header")
                                                    ? gapField.Header.Style
                                                    : gapField.Value.Style;
                            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.StyleErrorFormatMessageNotFound, style, styleValue, Environment.NewLine);
                            message.AppendLine();
                        }

                        break;
                    #endregion

                    #region Data, Group Field
                    default:
                        var dataField = (DataFieldModel)entry.Key;
                        message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.StyleErrorFormatMessageFieldLine, dataField.Name, dataField.Alias);
                        message.AppendLine();

                        foreach (var style in entry.Value)
                        {
                            var styleValue = style.Equals("Header")
                                                    ? dataField.Header.Style
                                                    : dataField.Value.Style;
                            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.StyleErrorFormatMessageNotFound, style, styleValue, Environment.NewLine);
                            message.AppendLine();
                        }
                    
                        break;
                    #endregion
                }
            }

            message.Append(Resources.ErrorMessage.ModelStyleErrorCommentLine);
            return message;
        }
        #endregion

        #region [public] {static} (StringBuilder) ModelIdentifierNameErrorMessage(string, string, string): Returns a StringBuilder than contains the error message for wrong identifier.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong identifier.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="attribute">The attribute.</param>
        /// <param name="attributeValue">The value attribute.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> that contains the error message.
        /// </returns>
        public static StringBuilder ModelIdentifierNameErrorMessage(string element, string attribute, string attributeValue)
        {
            var message = new StringBuilder();

            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorHeaderText, Resources.ErrorMessage.InvalidIdentifierText);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorSimpleElementLine, element);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorAttributeLine, attribute, attributeValue);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorCommentLine, Resources.ErrorMessage.IdentifierText, Resources.ErrorMessage.ModelIdentifierValidSpecialChars);

            return message;
        }
        #endregion

        #region [public] {static} (StringBuilder) ModelFileNameErrorMessage(string, string): Returns a StringBuilder than contains the error message for wrong file name.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong file name.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="elementValue">Filename value.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> that contains the error message.
        /// </returns>
        public static StringBuilder ModelFileNameErrorMessage(string element, string elementValue)
        {
            var message = new StringBuilder();

            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorHeaderText, Resources.ErrorMessage.InvalidFileNameText);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorComplexElementLine, element, elementValue);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelFileNameError, Resources.ErrorMessage.ModelFileNameInvalidSpecialChars);

            return message;
        }
        #endregion

        #region [public] {static} (StringBuilder) ModelPathErrorMessage(string, string): Returns a StringBuilder than contains the error message for wrong path.
        /// <summary>
        /// Returns a <see cref="T:System.Text.StringBuilder" /> than contains the error message for wrong path.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="elementValue">Filename value.</param>
        /// <returns>
        /// A <see cref="T:System.Text.StringBuilder" /> that contains the error message.
        /// </returns>
        public static StringBuilder ModelPathErrorMessage(string element, string elementValue)
        {
            var message = new StringBuilder();

            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorHeaderText, Resources.ErrorMessage.InvalidPathText);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorComplexElementLine, element, elementValue);
            message.AppendLine();
            message.AppendFormat(CultureInfo.CurrentCulture, Resources.ErrorMessage.ModelErrorCommentLine, Resources.ErrorMessage.PathText, Resources.ErrorMessage.ModelPathNameValidSpecialChars);

            return message;
        }
        #endregion
    }
}
