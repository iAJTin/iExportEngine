using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Defines a single style, includes definition for a font type, type of content, such as the background color, the alignment type and the data type.
    /// </summary>
    /// <remarks>
    /// <para><strong>Type Information</strong></para>
    /// <list type="table">
    ///   <item>
    ///     <term><strong>Namespace</strong></term> 
    ///     <description>http://schemas.itin.com/export/engine/2014/configuration/v1.0</description>
    ///   </item>
    ///   <item>
    ///     <term><strong>Schema name</strong></term> 
    ///     <description>iTin Export Configuration File</description>
    ///   </item>
    /// </list>
    /// <para><strong>Parent Element</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.StylesModel" /></term> 
    ///     <description>Contains a collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.</description>
    ///   </item>
    /// </list>
    /// <para><strong>Child Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.StyleModel.Borders" /></term> 
    ///     <description>Defines the border properties to use.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.StyleModel.Content" /></term> 
    ///     <description>Defines as shown the content of a field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.StyleModel.Font" /></term> 
    ///     <description>Represents a font. Defines a particular format for text, including font face, size, and style attributes.</description>
    ///   </item>
    /// </list>
    /// <para><strong>Attributes</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Attribute</th>
    ///       <th>Required</th>
    ///       <th>Description</th>
    ///       <th>Possible Values</th>
    ///       </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.StyleModel.Name" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Name of the style.</td>
    ///       <td>See <see cref="P:iTin.Export.Model.StyleModel.Name" /> property</td>
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
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">X</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// <para><strong>XML Usage</strong></para>
    /// <para>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Style&gt;
    ///   &lt;Borders/&gt;
    ///   &lt;Content&gt;
    ///     &lt;Alignment/&gt;
    ///     &lt;Numeric/&gt; | &lt;Currency/&gt; | &lt;Percentage/&gt; | &lt;Scientific/&gt; | &lt;Datetime/&gt; | &lt;Special/&gt; &lt;Text/&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font/&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </para>
    /// </remarks>
    public partial class StyleModel : ICloneable
    {
        #region public constants
        /// <summary>
        /// The name of default style. Always is '_Default_'.
        /// </summary>
        public const string NameOfDefaultStyle = "_Default_";
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FontModel _font;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _inherits;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BordersModel _borders;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StylesModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContentModel _content;
        #endregion

        #region public static properties

            #region [public] {static} (StyleModel) Default: Gets a default style.
            /// <summary>
            /// Gets a default style.
            /// </summary>
            /// <value>
            /// A default style.
            /// </value>
            public static StyleModel Default
            {
                get
                {
                    var @default = Empty;
                    @default.Name = NameOfDefaultStyle;

                    return @default;
                }
            }
            #endregion

            #region [public] {static} (StyleModel) Empty: Gets an empty style.
            /// <summary>
            /// Gets an empty style.
            /// </summary>
            /// <value>
            /// An empty style.
            /// </value>
            public static StyleModel Empty
            {
                get { return new StyleModel(); }
            }
        #endregion

        #endregion

        #region public properties

            #region [public] (string) Name: Gets or sets the name of the style.
            /// <summary>
            /// Gets or sets the name of the style.
            /// </summary>
            /// <value>
            /// The name of the style.
            /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # @ % $</c>'</strong>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Style Name="string"&gt;
            /// ...
            /// ...
            /// &lt;/Style&gt;
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
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    SentinelHelper.ArgumentNull(value);
                    SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                    _name = value;
                }
            }
            #endregion

            #region [public] (string) Inherits: Gets or sets the name of parent style.
            [XmlAttribute]
            [DefaultValue("")]
            public string Inherits
            {
                get
                {
                    return _inherits;
                }
                set
                {
                    SentinelHelper.ArgumentNull(value);
                    SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                    _inherits = value;
                }
            }
            #endregion

            #region [public] (BordersModel) Borders: Gets or sets the collection of border properties.
            /// <summary>
            /// Gets or sets the collection of border properties.
            /// </summary>
            /// <value>
            /// Collection of border properties. Each element defines a border.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Style&gt;
            ///   &lt;Borders&gt;
            /// &lt;/Style&gt;
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
            [XmlArrayItem("Border", typeof(BorderModel), IsNullable = false)]
            public BordersModel Borders
            {
                get
                {
                    if (!string.IsNullOrEmpty(Inherits))
                    {
                        if (InheritStyle != Empty)
                        {
                            if (_borders == null)
                            {
                                _borders = new BordersModel(this);
                            }
                            
                            _borders.Combine(InheritStyle.Borders);
                        }
                    }

                    return _borders ?? (_borders = new BordersModel(this));
                }
                set
                {
                    _borders = value;
                }
            }
            #endregion

            #region [public] (ContentModel) Content: Gets or sets a reference to the content model.
            /// <summary>
            /// Gets or sets a reference to the content model.
            /// </summary>
            /// <value>
            /// Reference that contains the definition of as shown the content of a field.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Style&gt;
            ///   &lt;Content&gt;
            /// &lt;/Style&gt;
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
            public ContentModel Content
            {
                get
                {
                    if (!string.IsNullOrEmpty(Inherits))
                    {
                        if (InheritStyle != Empty)
                        {
                            _content.Combine(InheritStyle.Content);
                        }
                    }

                    if (_content == null)
                    {
                        _content = new ContentModel();
                    }

                    _content.SetParent(this);

                    return _content;
                }
                set
                {
                    _content = value;
                }
            }
            #endregion

            #region [public] (FontModel) Font: Gets or sets the font model.
            /// <summary>
            /// Gets or sets the font model.
            /// </summary>
            /// <value>
            /// Reference that contains the definition of a font.            
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Style&gt;
            ///   &lt;Font/&gt;
            /// &lt;/Style&gt;
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
            public FontModel Font
            {
                get
                {
                    if (!string.IsNullOrEmpty(Inherits))
                    {
                        if (InheritStyle != Empty)
                        {
                            if (_font == null)
                            {
                                _font = new FontModel();
                            }
                            
                           _font.Combine(InheritStyle.Font);
                        }
                    }

                    return _font ?? (_font = new FontModel());
                }
                set
                {
                    _font = value;
                }
            }
            #endregion

            #region [public] (bool) IsEmpty: Gets a value indicating whether this style is an empty style.
            /// <summary>
            /// Gets a value indicating whether this style is an empty style.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if is an empty style; otherwise, <strong>false</strong>.
            /// </value>        
            public bool IsEmpty
            {
                get
                {
                    return IsDefault;
                }
            }
            #endregion

            #region [public] (StylesModel) Owner: Gets the element that owns this.
            /// <summary>
            /// Gets the element that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
            /// </summary>
            /// <value>
            /// The <see cref="T:iTin.Export.Model.StylesModel" /> that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
            /// </value>
            [XmlIgnore]
            [Browsable(false)]
            public StylesModel Owner
            {
                get { return _owner; }
            }
            #endregion

        #endregion

        #region private properties

            #region [private] (StyleModel) InheritStyle: Gets a reference to inherit model.
            /// <summary>
            /// Gets a reference to inherit model.
            /// </summary>
            /// <value>
            /// A inherit style.
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private StyleModel InheritStyle
            {
                get
                {
                    return Owner == null 
                        ? Empty 
                        : Owner.GetBy(_inherits);
                }
            }
            #endregion

        #endregion

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
                    return Font.IsDefault &&
                           Content.IsDefault &&
                           Borders.IsDefault &&
                           string.IsNullOrEmpty(Inherits);
                }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (StyleModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public StyleModel Clone()
            {
                var styleCloned = (StyleModel)MemberwiseClone();
                styleCloned.Font = Font.Clone();
                styleCloned.Borders = Borders.Clone();
                styleCloned.Content = Content.Clone();
                styleCloned.Properties = Properties.Clone();

                return styleCloned;
            }
            #endregion

            #region [public] (void) Combine(StyleModel): Combines this instance with reference parameter.
            /// <summary>
            /// Combines this instance with reference parameter.
            /// </summary>
            public void Combine(StyleModel reference)
            {
                Combine(reference, true);
            }
            #endregion

            #region [public] (void) Combine(StyleModel, bool): Combines this instance with reference parameter.
            /// <summary>
            /// Combines this instance with reference parameter.
            /// </summary>
            public void Combine(StyleModel reference, bool forceInherits)
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new NullReferenceException("Primero asignar un nombre de estilo antes de combinar");
                }

                if (forceInherits)
                {
                    Inherits = reference.Inherits;
                }

                Borders.Combine(reference.Borders);
                Content.Combine(reference.Content);
                Font.Combine(reference.Font);
            }
            #endregion

            #region [public] (void) SetOwner(StylesModel): Sets the element that owns this.
            /// <summary>
            /// Sets the element that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
            /// </summary>
            /// <param name="reference">Reference to owner.</param>
            internal void SetOwner(StylesModel reference)
            {
                _owner = reference;
            }
            #endregion

        #endregion

        #region private methods

            #region [private] (object) Clone(): Creates a new object that is a copy of the current instance.
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
