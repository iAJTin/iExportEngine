
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Collection of data fields. Each element is a data field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Table</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TableModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Fields&gt;
    ///   &lt;Field/&gt; | &lt;Fixed/&gt; | &lt;Gap/&gt; | &lt;Group/&gt; 
    ///   ...
    /// &lt;/Fields&gt;
    /// </code>
    /// </para>    
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
    ///       <th>SQL Script<br /><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
    public partial class FieldsModel
    {
        #region constructor/s

        #region [public] FieldsModel(TableModel): Initializes a new instance of this class
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Fields/Public/Constructors/Constructor[@name='ctor1']/*" />
        public FieldsModel(TableModel parent)
            : base(parent)
        {
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (IEnumerable<BaseDataFieldModel>) GetRange(YesNo): Gets an enumerator to a list of fields that has visible headers
        /// <summary>
        /// Gets an enumerator to a list of fields that has visible headers.
        /// </summary>
        /// <param name="visibleHeaders">Table position</param>
        /// <returns>
        /// Enumerator that contains list of fields that has visible headers.
        /// </returns>
        public IEnumerable<BaseDataFieldModel> GetRange(YesNo visibleHeaders)
        {
            SentinelHelper.IsEnumValid(visibleHeaders);

            return this.Where(field => field.Header.Show == YesNo.Yes).ToList();
        }
        #endregion

        #region [public] (IEnumerable<BaseDataFieldModel>) GetRange(KnownAggregateLocation): Gets an enumerator to a list of fields that meet the test of being added at the indicated position and this is visible
        /// <summary>
        /// Gets an enumerator to a list of fields that meet the test of being added at the indicated position and this is visible.
        /// </summary>
        /// <param name="location">Table position</param>
        /// <returns>
        /// Enumerator that contains list of fields that meet the condition and is visible.
        /// </returns>
        public IEnumerable<BaseDataFieldModel> GetRange(KnownAggregateLocation location)
        {
            SentinelHelper.IsEnumValid(location);

            return this.Where(field => field.Aggregate.Show == YesNo.Yes && field.Aggregate.Location == location).ToList();
        }
        #endregion

        #region [public] (IEnumerable<BaseDataFieldModel>) GetRange(KnownFieldType): Returns an enumerator to a field list containing only those who meet the condition of type
        /// <summary>
        /// Returns an enumerator to a field list containing only those who meet the condition of type.
        /// </summary>
        /// <param name="field">Type of the field.</param>
        /// <returns>
        /// Enumerator that contains list of fields that meet the condition.
        /// </returns>
        public IEnumerable<BaseDataFieldModel> GetRange(KnownFieldType field)
        {
            SentinelHelper.IsEnumValid(field);

            return this.Where(fld => fld.FieldType.Equals(field)).ToList();
        }
        #endregion

        #region [public] (bool) HasVisibleAggregatesByLocation(KnownAggregateLocation): Gets a value indicating whether there is a field with a visible aggregate and at specified position
        /// <summary>
        /// Gets a value indicating whether there is a field with a visible aggregate and at specified position.
        /// </summary>
        /// <param name="location">Aggregate location</param>
        /// <returns>
        ///  <strong>true</strong> if there is a field with a visible aggregate and at the specified location; otherwise, <strong>false</strong>.
        /// </returns>
        public bool HasVisibleAggregatesByLocation(KnownAggregateLocation location)
        {
            SentinelHelper.IsEnumValid(location);

            return GetRange(location).Any();
        }
        #endregion

        #region [public] (bool) HasVisibleHeaders(): Gets a value indicating whether there are field with a visible header
        /// <summary>
        /// Gets a value indicating whether there are field with a visible header.
        /// </summary>
        /// <returns>
        ///  <strong>true</strong> if there are field with a visible header; otherwise, <strong>false</strong>.
        /// </returns>
        public bool HasVisibleHeaders()
        {
            return GetRange(YesNo.Yes).Any();
        }
        #endregion

        #region [public] (void) Validate(): Validates the field definition list and the definition of field styles
        /// <summary>
        /// Validates the field definition list and the definition of field styles.
        /// </summary>
        /// <exception cref="T:iTin.Export.Model.InvalidFieldsDefinitionException">Thrown if there are field definition errors.</exception>
        public void Validate()
        {
            var hasFieldErrors = HasFieldErrors(this, out var fieldErrorDictionary);
            if (hasFieldErrors)
            {
                var message = ErrorMessageHelper.FormatFieldErrorMessage(fieldErrorDictionary);
                throw new InvalidFieldsDefinitionException(message);
            }

            var hasFieldStyleErrors = HasStyleErrors(this, out var fieldStyleErrorDictionary);
            if (!hasFieldStyleErrors)
            {
                return;
            }

            var errorMessage = ErrorMessageHelper.FormatStyleErrorMessage(fieldStyleErrorDictionary);
            throw new InvalidStylesDefinitionException(errorMessage);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) HasFieldErrors(FieldsModel, out Dictionary<FieldModel, List<string>>): Gets a value indicating whether there are errors in field names assigned to the field list
        /// <summary>
        /// Gets a value indicating whether there are errors in field names assigned to the field list.
        /// </summary>
        /// <param name="fields">Field list.</param>
        /// <param name="errorTable">Dictionary of fields that contains the list of objects with error.</param>
        /// <returns>
        /// <strong>true</strong> if field not found; otherwise, <strong>false</strong>.
        /// </returns>
        /// <remarks>
        /// The parameter <paramref name="errorTable" /> contains a dictionary containing the field and the list of elements whose is not properly defined.
        /// </remarks>
        private static bool HasFieldErrors(FieldsModel fields, out Dictionary<BaseDataFieldModel, List<string>> errorTable)
        {
            SentinelHelper.ArgumentNull(fields);

            errorTable = new Dictionary<BaseDataFieldModel, List<string>>();
            foreach (var field in fields)
            {
                var typeFieldList = new List<string>();
                switch (field.FieldType)
                {
                    case KnownFieldType.Fixed:
                        var fixedField = (FixedFieldModel)field;

                        var fix = fixedField.Owner.Parent.Parent.Resources.Fixed;
                        var exist = fix.Contains(fixedField.Pieces);
                        if (!exist)
                        {
                            typeFieldList.Add("Pieces");
                        }
                        else
                        {
                            var pieces = fix[fixedField.Pieces];
                            exist = pieces.Pieces.Contains(fixedField.Piece);
                            if (!exist)
                            {
                                typeFieldList.Add("Piece");
                            }
                        }
                        break;

                    case KnownFieldType.Group:
                        var groupField = (GroupFieldModel)field;

                        var groups = field.Owner.Parent.Parent.Resources.Groups;
                        var existGroupField = groups.Contains(groupField.Name);
                        if (!existGroupField)
                        {
                            typeFieldList.Add("Group");
                        }
                        break;
                }

                var totalFixed = typeFieldList.Count;
                if (totalFixed > 0)
                {
                    errorTable.Add(field, typeFieldList);
                }
            }

            return errorTable.Count > 0;
        }
        #endregion

        #region [private] {static} (bool) HasStyleErrors(FieldsModel, out Dictionary<FieldModel, List<string>>): Gets a value indicating whether there are errors in style names assigned to the field list
        /// <summary>
        /// Gets a value indicating whether there are errors in style names assigned to the field list.
        /// </summary>
        /// <param name="fields">Field list.</param>
        /// <param name="errorTable">Dictionary of fields that contains the list of objects with error <c>Style</c> property.</param>
        /// <returns>
        /// <strong>true</strong> if a specified style to a field is empty or not found in the list of defined styles; otherwise, <strong>false</strong>.
        /// </returns>
        /// <remarks>
        /// The parameter <paramref name="errorTable" /> contains a dictionary containing the field and the list of elements whose style is not properly defined.
        /// </remarks>
        private static bool HasStyleErrors(FieldsModel fields, out Dictionary<BaseDataFieldModel, List<string>> errorTable)
        {
            SentinelHelper.ArgumentNull(fields);

            errorTable = new Dictionary<BaseDataFieldModel, List<string>>();
            foreach (var field in fields)
            {
                var styles = new List<string>();

                var exist = field.Header.CheckStyleName();
                if (!exist)
                {
                    styles.Add("Header");
                }

                exist = field.Value.CheckStyleName();
                if (!exist)
                {
                    styles.Add("Value");
                }

                exist = field.Aggregate.CheckStyleName();
                if (!exist)
                {
                    styles.Add("Aggregate");
                }

                var totalStyles = styles.Count;
                if (totalStyles > 0)
                {
                    errorTable.Add(field, styles);
                }
            }

            var totalFields = errorTable.Count;
            return totalFields > 0;
        }
        #endregion

        #endregion

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(BaseDataFieldModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override BaseDataFieldModel GetBy(string value)
        {
            var fieldIndex = -1;
            BaseDataFieldModel item = null;

            foreach (var field in this)
            {
                var found = false;

                var fieldType = field.FieldType;
                switch (fieldType)
                {
                    case KnownFieldType.Field:
                        if (((DataFieldModel)field).Name.Equals(value, StringComparison.Ordinal))
                        {
                            found = true;
                            fieldIndex = IndexOf(field);
                        }

                        break;

                    case KnownFieldType.Fixed:
                        if (((FixedFieldModel)field).Piece.Equals(value, StringComparison.Ordinal))
                        {
                            found = true;
                            fieldIndex = IndexOf(field);
                        }

                        break;

                    case KnownFieldType.Gap:
                        if (field.Alias.Equals(value, StringComparison.Ordinal))
                        {
                            found = true;
                            fieldIndex = IndexOf(field);
                        }

                        break;

                    case KnownFieldType.Group:
                        if (((GroupFieldModel)field).Name.Equals(value, StringComparison.Ordinal))
                        {
                            found = true;
                            fieldIndex = IndexOf(field);
                        }

                        break;

                    case KnownFieldType.Packet:
                        if (((PacketFieldModel)field).Name.Equals(value, StringComparison.Ordinal))
                        {
                            found = true;
                            fieldIndex = IndexOf(field);
                        }

                        break;
                }

                if (found)
                {
                    break;
                }
            }

            if (fieldIndex != -1)
            {
                item = this[fieldIndex];
            }

            return item;
        }
    }
}
