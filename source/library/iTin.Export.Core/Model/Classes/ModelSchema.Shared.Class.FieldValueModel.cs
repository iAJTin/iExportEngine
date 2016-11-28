using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using iTin.Export.ComponentModel;
using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Reference to visual setting of value of the data field.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Field</c></strong>, please see <see cref="T:iTin.Export.Model.DataFieldModel" /><br/>
    /// - Or - <strong><c>Fixed</c></strong>, please see <see cref="T:iTin.Export.Model.FixedFieldModel" /><br/>
    /// - Or - <strong><c>Gap</c></strong>, please see <see cref="T:iTin.Export.Model.GapFieldModel" /><br/> 
    /// - Or - <strong><c>Group</c></strong>, please see <see cref="T:iTin.Export.Model.GroupFieldModel" /><br/>
    /// - Or - <strong><c>Packet</c></strong>, please see <see cref="T:iTin.Export.Model.PacketFieldModel" /><br/>.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Value .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.FieldAggregateModel.Style" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of a style defined in the list of styles. The default is "<c>Default</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.FieldAggregateModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines visibility of the element. The default is <see cref="iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
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
    public partial class FieldValueModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultStyle = "Default";
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BaseDataFieldModel _parent;
        #endregion

        #region constructor/s

            #region [public] FieldValueModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.FieldValueModel" /> class.
            /// </summary>
            public FieldValueModel()
            {
                Show = DefaultShow;
                Style = DefaultStyle;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (YesNo) Show: Gets or sets a value that determines visibility of the element.
            /// <summary>
            /// Gets or sets a value that determines visibility of the element.
            /// </summary>
            /// <value>
            /// <see cref="iTin.Export.Model.YesNo.Yes" /> if the item is displayed; otherwise, <strong><see cref="iTin.Export.Model.YesNo.No"/></strong>. The default is <see cref="iTin.Export.Model.YesNo.No" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Value Show="Yes|No" ...&gt;
            /// ...
            /// &lt;/Value&gt;
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
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultShow)]
            public YesNo Show
            {
                get
                {
                    return _show;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    _show = value;
                }
            }
            #endregion

            #region [public] (BaseDataFieldModel) Parent: Gets the parent element of the element.
            /// <summary>
            /// Gets the parent element of the element.
            /// </summary>
            /// <value>
            /// The element that represents the container element of the element.
            /// </value>
            [Browsable(false)]
            public BaseDataFieldModel Parent
            {
                get { return _parent; }
            }
            #endregion

            #region [public] (string) Style: Gets or sets one of the styles defined in the element styles.
            /// <summary>
            /// Gets or sets one of the styles defined in the element styles.
            /// </summary>
            /// <value>
            /// Name of a style defined in the list of styles. The default is "<c>Default</c>".
            /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # @ % $</c>'</strong>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Value Style="string" ...&gt;
            /// ...
            /// &lt;/Value&gt;
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
            /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
            /// <exception cref="T:iTin.Export.Model.InvalidIdentifierNameException"><paramref name="value" /> not is a valid identifier name.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultStyle)]
            public string Style
            {
                get
                {
                    return GetValueByReflection(Parent.Owner.Parent.Parent, _style); 
                }
                set
                {
                    SentinelHelper.ArgumentNull(value);

                    var isBindField = RegularExpressionHelper.IsValidStaticResource(value);
                    if (!isBindField)
                    {
                        SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Value", "Style", value)));
                    }

                    _style = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region public override properties

                #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
                /// <summary>
                /// Gets a value indicating whether this instance is default.
                /// </summary>
                /// <value>
                /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
                /// </value>
                public override bool IsDefault
                {
                    get
                    {
                        return
                            Show.Equals(DefaultShow) &&
                            Style.Equals(DefaultStyle);
                    }
                }
                #endregion

            #endregion

        #endregion

        #region public methods

            #region [public] (bool) CheckStyleName(): Performs a test for check if there this name of the style into the user-defined styles list.
            /// <summary>
            /// Performs a test for check if there this name of the style into the user-defined styles list.
            /// </summary>
            /// <returns>
            /// <strong>true</strong> if exist; otherwise, <strong>false</strong>.
            /// </returns>
            public bool CheckStyleName()
            {
                return Style.Equals("Default") ||
                       Parent.Owner.Parent.Parent.Owner.Resources.Styles.Contains(Style);
            }
            #endregion

            #region [public] (FieldValueInformation) GetValue(): 
            /// <summary>
            /// Gets the value.
            /// </summary>
            /// <returns>
            /// The value
            /// </returns>
            public FieldValueInformation GetValue()
            {
                return GetValue(null);
            }
            #endregion

            #region [public] (FieldValueInformation) GetValue(IEnumerable<char>): 
            /// <summary>
            /// Gets the value.
            /// </summary>
            /// <param name="specialChars">The special chars.</param>
            /// <returns>
            /// The value
            /// </returns>
            public FieldValueInformation GetValue(IEnumerable<char> specialChars)
            {
                //// return FieldValueInformationCache.Cache.Get(Parent, specialChars);

                var value = FieldValueInformation.Default;
                var unformattedValue = string.Empty;

                var specialCharsList = new List<char>();
                if (specialChars != null)
                {
                    specialCharsList = specialChars.ToList();
                }

                if (Show == YesNo.No)
                {
                    return value;
                }

                StyleModel style;
                var found = Parent.Value.TryGetStyle(out style);
                if (!found)
                {
                    // Mensaje de Log usando default style; 
                    style = StyleModel.Default;
                }

                value.Style = style;

                if (Parent.DataSource == null)
                {
                    return value;
                }

                var fieldType = Parent.FieldType;
                switch (fieldType)
                {
                    #region Field: Data
                    case KnownFieldType.Field:
                        {
                            var current = (DataFieldModel)Parent;
                            var parsedName = BaseAdapter.Parse(current.Name, specialCharsList);

                            var fieldAsAttribute = Parent.DataSource.Attribute(parsedName);
                            if (fieldAsAttribute == null)
                            {
                                fieldAsAttribute = Parent.DataSource.Attribute(parsedName.ToUpperInvariant());
                                if (fieldAsAttribute == null)
                                {
                                    fieldAsAttribute = Parent.DataSource.Attribute(parsedName.ToLowerInvariant());
                                }                                
                            }

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
                            var current = (FixedFieldModel)Parent;

                            var @fixed = Parent.Owner.Parent.Parent.Resources.Fixed;
                            var fixedItem = @fixed[current.Pieces];
                            fixedItem.DataSource = Parent.DataSource;

                            var parsedName = BaseAdapter.Parse(current.Piece, specialCharsList);
                            var piece = fixedItem.Pieces[parsedName];
                            unformattedValue = piece.GetValue();
                        }

                        break;
                    #endregion

                    #region Field: Group
                    case KnownFieldType.Group:
                        {
                            var current = (GroupFieldModel)Parent;
                            var currentName = current.Name;

                            var @fixed = Parent.Owner.Parent.Parent.Owner.Resources.Fixed;
                            var groups = Parent.Owner.Parent.Parent.Owner.Resources.Groups;
                            var groupValue = string.Empty;
                            var builder = new StringBuilder();

                            var group = groups[currentName];
                            var groupFields = group.Fields;
                            foreach (var groupField in groupFields)
                            {
                                var parsedName = BaseAdapter.Parse(groupField.Name, specialCharsList);
                                var asAttribute = Parent.DataSource.Attribute(parsedName);
                                if (asAttribute == null)
                                {
                                    foreach (var fixedwidth in @fixed)
                                    {
                                        fixedwidth.DataSource = Parent.DataSource;

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
                            var current = (PacketFieldModel)Parent;
                            var parsedName = BaseAdapter.Parse(current.Name, specialCharsList);

                            var fieldAsAttribute = Parent.DataSource.Attribute(parsedName);
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
            #endregion

            #region [public] (bool) TryGetStyle(out Style): Gets a reference to the style from resource.
            /// <summary>
            /// Gets a reference to the <see cref="T:iTin.Export.Model.StyleModel" /> from global resources.
            /// </summary>
            /// <param name="style">A <see cref="T:iTin.Export.Model.StyleModel" /> resource.</param>
            /// <returns>
            /// <strong>true</strong> if returns the style from resource; otherwise, <strong>false</strong>.
            /// </returns>
            public bool TryGetStyle(out StyleModel style)
            {
                style = StyleModel.Empty;

                StyleModel resource;
                var found = TryGetResourceInformation(out resource);
                if (!found)
                {
                    return false;
                }

                style = resource;

                return true;
            }
            #endregion

        #endregion

        #region internal methods

            #region [internal] (void) SetParent(BaseDataFieldModel): Sets the parent element of the element.
            /// <summary>
            /// Sets the parent element of the element.
            /// </summary>
            /// <param name="reference">Reference to parent.</param>
            internal void SetParent(BaseDataFieldModel reference)
            {
                _parent = reference;
            }
            #endregion

        #endregion

        #region private methods

            #region [private] (bool) TryGetResourceInformation(out StyleModel): Gets a reference to the image resource information.
            /// <summary>
            /// Gets a reference to the image resource information.
            /// </summary>
            /// <param name="resource">Resource information.</param>
            /// <returns>
            /// <strong>true</strong> if exist available information about resource; otherwise, <strong>false</strong>.
            /// </returns>
            private bool TryGetResourceInformation(out StyleModel resource)
            {
                bool result;

                resource = StyleModel.Empty;
                if (string.IsNullOrEmpty(Style))
                {
                    return false;
                }

                try
                {
                    var field = Parent;
                    var fields = field.Owner;
                    var table = fields.Parent;
                    var export = table.Parent;
                    resource = export.Resources.GetStyleResourceByName(Style);

                    result = resource != null;
                }
                catch
                {
                    result = false;
                }

                return result;
            }
            #endregion

        #endregion

    }
}
