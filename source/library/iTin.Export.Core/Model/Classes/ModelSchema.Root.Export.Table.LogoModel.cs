
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Represents a logo.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Table</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TableModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Logo&gt;
    ///   &lt;Image/&gt;
    ///   &lt;Location/&gt;
    /// &lt;/Logo&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.LogoModel.Size" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred size of the logo. The default is <c>-1 -1</c>, indicates original size of logo.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.LogoModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the logo. The default is <see cref="F:iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.LogoModel.Image" /></term> 
    ///     <description>The image file path. To specify a relative path use the character (~).</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.LogoModel.Location" /></term> 
    ///     <description>Defines the location of logo in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates.</description>
    ///   </item>
    /// </list>
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
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class LogoModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region private static readonly member fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly int[] DefaultSize = { -1, -1 };
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int[] _size;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LogoImageModel _image;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel _location;
        #endregion

        #region constructor/s

        #region [public] LogoModel(): Initializes a new instance of this class
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Logo/Public/Constructors/Constructor[@name="ctor1"]/*'/>
        public LogoModel()
        {
            Show = DefaultShow;
            Size = DefaultSize;
            ////this.Flip = KnownFlipStyle.None;
            ////this.Effects = new[] { KnownEffectType.None };
        }
        #endregion

        #endregion

        #region public properties

        ////#region [public] (KnownEffectType[]) Effects: Gets or sets a reference to collection of effects to apply to logo.
        /////// <summary>
        /////// Gets or sets a reference to collection of effects to apply to logo.
        /////// </summary>
        /////// <value>
        /////// A collection of effects to apply to logo. The default is <see cref="iTin.Export.Model.KnownEffectType.None"/>
        /////// </value>
        /////// <remarks>
        /////// <code lang="xml" title="ITEE Object Element Usage">
        /////// &lt;Logo Effects="None|Disabled|GrayScale|GrayScaleRed|GrayScaleGreen|GrayScaleBlue|Brightness|MoreBrightness|Dark|MoreDark|OpacityPercent05|OpacityPercent10|OpacityPercent20|OpacityPercent30|OpacityPercent40|OpacityPercent50|OpacityPercent60|OpacityPercent70|OpacityPercent80|OpacityPercent90" ...&gt;
        ///////   ...
        /////// &lt;/Logo&gt;
        /////// </code>
        /////// <para>
        /////// <para><strong>Compatibility table with native writers.</strong></para>
        /////// <table>
        ///////   <thead>
        ///////     <tr>
        ///////       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></th>
        ///////       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></th>
        ///////       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></th>
        ///////       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></th>
        ///////     </tr>
        ///////   </thead>
        ///////   <tbody>
        ///////     <tr>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////     </tr>
        ///////   </tbody>
        /////// </table>
        /////// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /////// </para>
        /////// </remarks>
        ////[XmlAttribute]
        ////[CLSCompliant(false)]
        ////[DefaultValue(new[] { KnownEffectType.None })]            
        ////public KnownEffectType[] Effects
        ////{
        ////    get
        ////    {
        ////        return this.effects ?? (this.effects = ExportsModel.GetDefaultPropertyValue<KnownEffectType[]>(this.GetType(), "Effects"));
        ////    }
        ////    set
        ////    {
        ////        if (value != null)
        ////        {
        ////            foreach (var effect in value)
        ////            {
        ////                SentinelHelper.IsEnumValid(effect);                            
        ////            }

        ////            this.effects = value;
        ////        }
        ////    }
        ////}
        ////#endregion

        ////#region [public] (KnownFlipStyle) Flip: Gets or sets preferred flip style to apply to logo.
        /////// <summary>
        /////// Gets or sets preferred flip style to apply to logo.
        /////// </summary>
        /////// <value>
        /////// Preferred flip style to apply to logo. The default is <see cref="iTin.Export.Model.KnownFlipStyle.None" />
        /////// </value>
        /////// <remarks>
        /////// <code lang="xml" title="ITEE Object Element Usage">
        /////// &lt;Logo Flip="None|X|Y|XY" ...&gt;
        ///////   ...
        /////// &lt;/Logo&gt;
        /////// </code>
        /////// <para>
        /////// <para><strong>Compatibility table with native writers.</strong></para>
        /////// <table>
        ///////   <thead>
        ///////     <tr>
        ///////       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></th>
        ///////       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></th>
        ///////       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></th>
        ///////       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></th>
        ///////     </tr>
        ///////   </thead>
        ///////   <tbody>
        ///////     <tr>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////     </tr>
        ///////   </tbody>
        /////// </table>
        /////// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /////// </para>
        /////// </remarks>
        ////[XmlAttribute]
        ////[DefaultValue(KnownFlipStyle.None)]
        ////public KnownFlipStyle Flip
        ////{
        ////    get
        ////    {
        ////        return this.flip;
        ////    }
        ////    set
        ////    {
        ////        SentinelHelper.IsEnumValid(value);

        ////        this.flip = value;
        ////    }
        ////}
        ////#endregion

        ////#region [public] (string) Image: Gets or sets the logo image file path.
        /////// <summary>
        /////// Gets or sets the logo image file path.
        /////// </summary>
        /////// <value>
        /////// The logo image file path.
        /////// </value>
        /////// <remarks>
        /////// <code lang="xml" title="ITEE Object Element Usage">
        /////// &lt;Logo ...&gt;
        ///////   &lt;Image&gt;string&lt;/File&gt;
        ///////   ...
        /////// &lt;/Logo&gt;
        /////// </code>
        /////// <para>
        /////// <para><strong>Compatibility table with native writers.</strong></para>
        /////// <table>
        ///////   <thead>
        ///////     <tr>
        ///////       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///////       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///////       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///////       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///////     </tr>
        ///////   </thead>
        ///////   <tbody>
        ///////     <tr>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////       <td align="center">No has effect</td>
        ///////     </tr>
        ///////   </tbody>
        /////// </table>
        /////// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /////// </para>
        /////// </remarks>
        /////// <example>
        /////// The following example show how to use this element.
        /////// <code lang="xml">
        /////// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /////// 
        /////// &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
        ///////   &lt;Export Name="Test" Current="Yes"&gt;
        ///////     &lt;Description&gt;Sample Export&lt;/Description&gt;
        ///////     &lt;Table Name="R740D01"
        ///////            Location="1 1"
        ///////            AutoFilter="Yes"
        ///////            AutoFitColumns="Yes"              
        ///////            Alias="Table alias"&gt;
        ///////       &lt;Logo&gt;
        ///////         &lt;Image&gt;~\Samples\Logos\Logo.png&lt;/Image&gt;
        ///////       &lt;/Logo&gt;
        /////// 
        ///////       &lt;Exporter&gt;
        ///////         &lt;Writer Name="Spreadsheet2003TabularWriter"/&gt;
        ///////         &lt;Behaviors&gt;
        ///////           &lt;Download/&gt;
        ///////           &lt;TransformFile Save="Yes"/&gt;
        ///////         &lt;/Behaviors&gt;
        ///////       &lt;/Exporter&gt;
        ///////       ... 
        ///////       ...
        ///////     &lt;/Table&gt;
        ///////   &lt;/Export&gt;
        /////// &lt;/Exports&gt;
        /////// </code>
        /////// </example>
        /////// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /////// <exception cref="T:iTin.Export.Model.InvalidFileNameException">If <paramref name="value" /> is an invalid filename.</exception>
        ////public string Image
        ////{
        ////    get
        ////    {
        ////        return this.image;
        ////    }
        ////    set
        ////    {
        ////        SentinelHelper.ArgumentNull(value);
        ////        SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Image", value)));
        ////        this.image = value;
        ////    }
        ////}
        ////#endregion

        #region [public] (int[]) Size: Gets or sets width and height of the logo
        /// <summary>
        /// Gets or sets width and height of the logo.
        /// </summary>
        /// <value>
        /// An <see cref="T:System.Array"/> of <see cref="T:System.String" /> structure that contains logo size. The default is <c>-1 -1</c> for original size.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Logo Size="int int" ...&gt;
        ///   ...
        /// &lt;/Logo&gt;
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
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlAttribute]
        [CLSCompliant(false)]
        [DefaultValue(new[] { -1, -1 })]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int[] Size
        {
            get => _size ?? (_size = DefaultSize);
            set
            {
                if (value == null)
                {
                    return;
                }

                SentinelHelper.IsTrue(value[0] < -1, "El ancho no puede ser menor que -1");
                SentinelHelper.IsTrue(value[1] < -1, "El alto no puede ser menor que -1");

                _size = value;
            }
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the logo
        /// <summary>
        /// Gets or sets a value that determines whether displays the logo.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if display the logo; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Logo Show="Yes|No" ...&gt;
        ///   ...
        /// &lt;/Logo&gt;
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
        ///       <td align="center">No has effect</td>
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
            get => GetStaticBindingValue(_show.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (LogoImageModel) Image: Gets or sets the logo image file path
        /// <summary>
        /// Gets or sets the logo image file path.
        /// </summary>
        /// <value>
        /// The logo image file path.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Logo ...&gt;
        ///   &lt;Image .../&gt;
        ///   ...
        /// &lt;/Logo&gt;
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
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlElement("Image")]
        public LogoImageModel Image
        {
            get
            {
                if (_image == null)
                {
                    _image = new LogoImageModel();
                }

                _image.SetParent(this);

                return _image;
            }
            set
            {
                if (value != null)
                {
                    value.SetParent(this);
                }

                _image = value;
            }
        }
        #endregion

        #region [public] (LocationModel) Location: Gets or sets a reference which contains the location of the logo in the host
        /// <summary>
        /// Gets or sets a reference which contains the location of the logo in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format.
        /// You can only choose one of the modes. If this tag does not define the defaults is by coordinates
        /// </summary>
        /// <value>
        /// Reference to location of the logo in the host.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Logo&gt;
        ///   &lt;Location .../&gt;
        ///   ...
        /// &lt;/Logo&gt;
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
        public LocationModel Location
        {
            get => _location ?? (_location = new LocationModel());
            set => _location = value;
        }
        #endregion

        #region [public] (Size) LogoSize: Gets the dimensions of logo
        /// <summary>
        /// Gets the dimensions of logo.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Drawing.Size" /> structure that contains the dimensions of logo measured in pixels.
        /// </value>
        public Size LogoSize => new Size(Size[0], Size[1]);
        #endregion

        #region [public] (TableModel) Parent: Gets the parent container of the logo
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Logo/Public/Properties/Property[@name="Parent"]/*'/>
        [Browsable(false)]
        public TableModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Image.IsDefault &&
                                          Location.IsDefault &&
                                          Show.Equals(DefaultShow) &&
                                          Size.SequenceEqual(DefaultSize);
        #endregion

        #endregion

        #region public methods

        #region [public] (SizeF) SizeToPoints(IntPtr): Converts chart size value in pixels to points for the specified device
        /// <summary>
        /// Converts chart size value in pixels to points for the specified device.
        /// </summary>
        /// <param name="hwnd">Pointer to device.</param>
        /// <returns>
        /// Returns size of chart, in points.
        /// </returns>
        public SizeF SizeToPoints(IntPtr hwnd)
        {
            SizeF points;

            using (var graphics = Graphics.FromHwnd(hwnd))
            {
                points = new SizeF(LogoSize.Width * 72 / graphics.DpiX, LogoSize.Height * 72 / graphics.DpiY);
            }

            return points;
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(TableModel): Sets the parent element of the element
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Internal/Methods/Method[@name="SetParent"]/*'/>
        internal void SetParent(TableModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
