using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Defines content alignment.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Alignment/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ContentAlignmentModel.Horizontal" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Horizontal alignment. The default is <see cref="iTin.Export.Model.KnownHorizontalAlignment.Left" /></td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ContentAlignmentModel.Vertical" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Vertical alignment. The default is <see cref="iTin.Export.Model.KnownVerticalAlignment.Center" /></td>
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
    /// </remarks>
    /// <example>
    /// In the following example shows how create a new content.
    /// <code lang="xml">
    /// &lt;Content Color="DarkBlue"&gt;
    ///   &lt;Alignment Horizontal="Left"/&gt;
    ///   &lt;Text/&gt;
    /// &lt;/Content&gt;
    /// </code>
    /// <code lang="cs">
    /// ContentModel content = new ContentModel
    ///                            {
    ///                                Color = "DarkBlue",
    ///                                DataType = new TextDataTypeModel(),
    ///                                Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
    ///                            };
    /// </code>
    /// </example>
    public partial class ContentAlignmentModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownVerticalAlignment DefaultVerticalAlignment = KnownVerticalAlignment.Center;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownHorizontalAlignment DefaultHorizontalAlignment = KnownHorizontalAlignment.Left;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownVerticalAlignment vertical;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownHorizontalAlignment horizontal;
        #endregion

        #region constructor/s

            #region [public] ContentAlignmentModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ContentAlignmentModel"/> class.
            /// </summary>
            public ContentAlignmentModel()
            {
                Vertical = DefaultVerticalAlignment;
                Horizontal = DefaultHorizontalAlignment;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (KnownHorizontalAlignment) Horizontal: Gets or sets horizontal alignment.
            /// <summary>
            /// Gets or sets horizontal alignment.
            /// </summary>
            /// <value>
            /// One of the <see cref="T:iTin.Export.Model.KnownHorizontalAlignment" /> values. The default is <see cref="iTin.Export.Model.KnownHorizontalAlignment.Left" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Alignment Horizontal="Left|Center|Right" .../&gt;
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
            /// In the following example shows how create a new content.
            /// <code lang="xml">
            /// &lt;Content Color="DarkBlue"&gt;
            ///   &lt;Alignment Horizontal="Left"/&gt;
            ///   &lt;Text/&gt;
            /// &lt;/Content&gt;
            /// </code>
            /// <code lang="cs">
            /// ContentModel content = new ContentModel
            ///                            {
            ///                                Color = "DarkBlue",
            ///                                DataType = new TextDataTypeModel(),
            ///                                Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
            ///                            };
            /// </code>
            /// </example>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultHorizontalAlignment)]
            public KnownHorizontalAlignment Horizontal
            {
                get
                {
                    return horizontal;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);
                    horizontal = value;
                }
            }
            #endregion

            #region [public] (KnownVerticalAlignment) Vertical: Gets or sets vertical alignment.
            /// <summary>
            /// Gets or sets vertical alignment.
            /// </summary>
            /// <value>
            /// One of the <see cref="T:iTin.Export.Model.KnownVerticalAlignment" /> values. The default is <see cref="iTin.Export.Model.KnownVerticalAlignment.Center" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Alignment Vertical="Top|Center|Bottom" .../&gt;
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
            /// In the following example shows how create a new content.
            /// <code lang="xml">
            /// &lt;Content Color="DarkBlue"&gt;
            ///   &lt;Alignment Horizontal="Left"/&gt;
            ///   &lt;Text/&gt;
            /// &lt;/Content&gt;
            /// </code>
            /// <code lang="cs">
            /// ContentModel content = new ContentModel
            ///                            {
            ///                                Color = "DarkBlue",
            ///                                DataType = new TextDataTypeModel(),
            ///                                Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
            ///                            };
            /// </code>
            /// </example>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultVerticalAlignment)]
            public KnownVerticalAlignment Vertical
            {
                get
                {
                    return vertical;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);
                    vertical = value;
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
                    return
                        Vertical.Equals(DefaultVerticalAlignment) &&
                        Horizontal.Equals(DefaultHorizontalAlignment);
                }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (ContentAlignmentModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public ContentAlignmentModel Clone()
            {
                var contentAlignmentCloned = (ContentAlignmentModel)MemberwiseClone();
                contentAlignmentCloned.Properties = Properties.Clone();

                return contentAlignmentCloned;
            }
            #endregion

        #region [public] (void) Combine(ContentAlignmentModel): Combines this instance with reference parameter.
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(ContentAlignmentModel reference)
            {
                if (vertical.Equals(DefaultVerticalAlignment))
                {
                    vertical = reference.Vertical;
                }

                if (horizontal.Equals(DefaultHorizontalAlignment))
                {
                    horizontal = reference.Horizontal;
                }
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
