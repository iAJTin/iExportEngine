using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTin.Export.ComponentModel;

namespace iTin.Export.Model
{
    static class FieldValueInformationFactory
    {
        public static FieldValueInformation Create(BaseDataFieldModel field, IEnumerable<char> specialChars)
        {
            var value = FieldValueInformation.Default;
            var unformattedValue = string.Empty;

            var specialCharsList = new List<char>();
            if (specialChars != null)
            {
                specialCharsList = specialChars.ToList();
            }

            if (field.Value.Show == YesNo.No)
            {
                return value;
            }

            StyleModel style;
            var found = field.Value.TryGetStyle(out style);
            if (!found)
            {
                // Mensaje de Log usando default style; 
                style = StyleModel.Default;
            }
                
            value.Style = style;

            if (field.DataSource == null)
            {
                return value;
            }

            var fieldType = field.FieldType;
            switch (fieldType)
            {
                #region Field: Data
                case KnownFieldType.Field:
                    {
                        var current = (DataFieldModel)field;
                        var parsedName = BaseTarget.Parse(current.Name, specialCharsList);

                        var fieldAsAttribute = field.DataSource.Attribute(parsedName);
                        if (fieldAsAttribute != null)
                        {
                            unformattedValue = fieldAsAttribute.Value;
                        }
                    }

                    break;
                #endregion

                #region Field: Fixed
                case KnownFieldType.Fixed:
                    {
                        var current = (FixedFieldModel)field;

                        var @fixed = field.Owner.Parent.Parent.Resources.Fixed;
                        var fixedItem = @fixed[current.Pieces];
                        fixedItem.DataSource = field.DataSource;

                        var parsedName = BaseTarget.Parse(current.Piece, specialCharsList);
                        var piece = fixedItem.Pieces[parsedName];
                        unformattedValue = piece.GetValue();
                    }
                        
                    break;
                #endregion

                #region Field: Group
                case KnownFieldType.Group:
                    {
                        var current = (GroupFieldModel)field;
                        var currentName = current.Name;

                        var @fixed = field.Owner.Parent.Parent.Owner.Resources.Fixed;
                        var groups = field.Owner.Parent.Parent.Owner.Resources.Groups;
                        var groupValue = string.Empty;
                        var builder = new StringBuilder();

                        var group = groups[currentName];
                        var groupFields = group.Fields;
                        foreach (var groupField in groupFields)
                        {
                            var parsedName = BaseTarget.Parse(groupField.Name, specialCharsList);
                            var asAttribute = field.DataSource.Attribute(parsedName);
                            if (asAttribute == null)
                            {
                                foreach (var fixedwidth in @fixed)
                                {
                                    fixedwidth.DataSource = field.DataSource;

                                    var piece = fixedwidth.Pieces[groupField.Name];
                                    if (piece == null)
                                    {
                                        continue;
                                    }

                                    groupValue = piece.GetValue();
                                }
                            }
                            else
                            {
                                groupValue = asAttribute.Value;
                            }

                            builder.Append(groupValue);
                            builder.Append(GroupFieldModel.GetSeparatorChar(groupField.Separator));
                        }

                        unformattedValue = builder.ToString();
                    }

                    break;
                #endregion

                #region Field: Packet
                case KnownFieldType.Packet:
                    {
                        var current = (PacketFieldModel)field;
                        var parsedName = BaseTarget.Parse(current.Name, specialCharsList);

                        var fieldAsAttribute = field.DataSource.Attribute(parsedName);
                        if (fieldAsAttribute != null)
                        {
                            var builder = new StringBuilder();
                            builder.Clear();

                            var inputFormat = current.InputFormat;
                            var fieldvalue = fieldAsAttribute.Value;
                            switch (inputFormat)
                            {
                                #region InputFormat: FullDateFormat
                                case KnownInputPacketFormat.FullDateFormat:
                                    if (!string.IsNullOrEmpty(fieldvalue) &&
                                        !fieldvalue.IsNullOrWhiteSpace() &&
                                        !fieldvalue.Trim().Equals("0"))
                                    {
                                        var adjustedValue = string.Concat(new string('0', 14), fieldvalue);
                                        adjustedValue = adjustedValue.Substring(adjustedValue.Length - 14, 14);

                                        builder.Append(adjustedValue.Substring(6, 2));
                                        builder.Append('/');
                                        builder.Append(adjustedValue.Substring(4, 2));
                                        builder.Append('/');
                                        builder.Append(adjustedValue.Substring(0, 4));
                                        builder.Append(' ');
                                        builder.Append(adjustedValue.Substring(8, 2));
                                        builder.Append(':');
                                        builder.Append(adjustedValue.Substring(10, 2));
                                        builder.Append(':');
                                        builder.Append(adjustedValue.Substring(12, 2));
                                    }
                                    break;
                                #endregion

                                #region InputFormat: LongDateFormat
                                case KnownInputPacketFormat.LongDateFormat:
                                    if (!string.IsNullOrEmpty(fieldvalue) &&
                                        !fieldvalue.IsNullOrWhiteSpace() &&
                                        !fieldvalue.Trim().Equals("0"))
                                    {
                                        var adjustedValue = string.Concat(new string('0', 8), fieldvalue);
                                        adjustedValue = adjustedValue.Substring(adjustedValue.Length - 8, 8);

                                        builder.Append(adjustedValue.Substring(0, 4));
                                        builder.Append('/');
                                        builder.Append(adjustedValue.Substring(4, 2));
                                        builder.Append('/');
                                        builder.Append(adjustedValue.Substring(6, 2));
                                    }
                                    break;
                                #endregion

                                #region InputFormat: ShortDateFormat
                                case KnownInputPacketFormat.ShortDateFormat:
                                    if (!string.IsNullOrEmpty(fieldvalue) &&
                                        !fieldvalue.IsNullOrWhiteSpace() &&
                                        !fieldvalue.Trim().Equals("0"))
                                    {
                                        var adjustedValue = string.Concat(new string('0', 6), fieldvalue);
                                        adjustedValue = adjustedValue.Substring(adjustedValue.Length - 6, 6);

                                        builder.Append(adjustedValue.Substring(0, 2));
                                        builder.Append('/');
                                        builder.Append(adjustedValue.Substring(2, 2));
                                        builder.Append('/');
                                        builder.Append(adjustedValue.Substring(4, 2));
                                    }
                                    break;
                                #endregion
                            }

                            unformattedValue = builder.ToString();
                        }
                    }

                    break;
                #endregion
            }

            return style.Content.DataType.GetFormattedDataValue(unformattedValue);
        }
    }
}
