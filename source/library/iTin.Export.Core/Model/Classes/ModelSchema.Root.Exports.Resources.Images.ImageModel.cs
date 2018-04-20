
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Xml.Serialization;

    using Drawing;
    using Helper;

    /// <summary>
    /// Includes definition for a font type, type of content, such as the background color, the alignment type and the data type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Images</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ImageModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Image ...&gt;
    ///   &lt;Path/&gt;
    ///   &lt;Effects/&gt;
    /// &lt;/Image&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ImageModel.Key" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of image resource.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.ImageModel.Path" /></term> 
    ///     <description>Defines as shown the content of a field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ImageModel.Effects" /></term> 
    ///     <description>Represents a font. Defines a particular format for text, including font face, size, and style attributes.</description>
    ///   </item>
    /// </list>
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
    public partial class ImageModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _key;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _path;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FlipModel _flip;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ImagesModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<BaseEffectModel> _effects;
        #endregion

        #region public properties

        #region [public] (string) Key: Gets or sets the key of image resource
        /// <summary>
        /// Gets or sets the key of image resource.
        /// </summary>
        /// <value>
        /// The key of image resource.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Image Key="string"&gt;
        /// ...
        /// ...
        /// &lt;/Image&gt;
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
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:iTin.Export.Model.InvalidIdentifierNameException"><paramref name="value" /> not is a valid identifier name.</exception>
        [XmlAttribute]
        public string Key
        {
            get => _key;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                _key = value;
            }
        }
        #endregion

        #region [public] (string) Path: Gets or sets the image file path
        /// <summary>
        /// Gets or sets the image file path.
        /// </summary>
        /// <value>
        /// The image file path.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Image ...&gt;
        ///   &lt;Path&gt;string&lt;/Path&gt;
        ///   ...
        /// &lt;/Image&gt;
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
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:iTin.Export.Model.InvalidFileNameException">If <paramref name="value" /> is an invalid filename.</exception>
        [XmlElement]
        public string Path
        {
            get => _path;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Path", value)));
                _path = value;
            }
        }
        #endregion

        #region [public] (List<BaseEffectModel>) Effects: Gets or sets collection of image effects
        /// <summary>
        /// Gets or sets collection of image effects.
        /// </summary>
        /// <value>
        /// Collection of image effects. Each element is an image effect.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Effects&gt;
        ///   &lt;Disabled/&gt; | 
        ///   &lt;GrayScale/&gt; | 
        ///   &lt;GrayScaleRed/&gt; | 
        ///   &lt;GrayScaleGreen/&gt; | 
        ///   &lt;GrayScaleBlue/&gt; | 
        ///   &lt;Brightness/&gt; | 
        ///   &lt;MoreBrightness/&gt; | 
        ///   &lt;Dark/&gt; | 
        ///   &lt;MoreDark/&gt; | 
        ///   &lt;Opacity .../&gt;
        /// &lt;/Effects&gt;
        /// </code>
        /// </remarks>
        [XmlArrayItem("Disabled", typeof(DisabledEffectModel))]
        [XmlArrayItem("GrayScale", typeof(GrayScaleEffectModel))]
        [XmlArrayItem("GrayScaleRed", typeof(GrayScaleRedEffectModel))]
        [XmlArrayItem("GrayScaleGreen", typeof(GrayScaleGreenEffectModel))]
        [XmlArrayItem("GrayScaleBlue", typeof(GrayScaleBlueEffectModel))]
        [XmlArrayItem("Brightness", typeof(BrightnessEffectModel))]
        [XmlArrayItem("MoreBrightness", typeof(MoreBrightnessEffectModel))]
        [XmlArrayItem("Dark", typeof(DarkEffectModel))]
        [XmlArrayItem("MoreDark", typeof(MoreDarkEffectModel))]
        [XmlArrayItem("Opacity", typeof(OpacityEffectModel))]       
        public List<BaseEffectModel> Effects
        {
            get
            {
                if (_effects == null)
                {
                    _effects = new List<BaseEffectModel>();
                }

                foreach (var item in _effects)
                {
                    item.SetOwner(this);
                }

                return _effects;
            }
            set => _effects = value;
        }
        #endregion

        #region [public] (FlipModel) Flip: Gets or sets flip mode for an image
        /// <summary>
        /// Gets or sets the flip.
        /// </summary>
        /// <value>
        /// The flip.
        /// </value>
        [XmlElement]
        public FlipModel Flip
        {
            get => _flip ?? (_flip = new FlipModel());
            set => _flip = value;
        }
        #endregion

        #region [public] (GlobalResourcesImagesModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.ImageModel"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ImagesModel"/> that owns this <see cref="T:iTin.Export.Model.ImageModel"/>.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public ImagesModel Owner => _owner;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => Flip.IsDefault &&
                                          string.IsNullOrEmpty(Path) && 
                                          string.IsNullOrEmpty(Key);
        #endregion

        #endregion

        #region public methods

        #region [public] (Image) GetImage(ExportModel): Gets a reference to the image object that contains modified image
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Image" /> object that contains modified image.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Image" /> object that represents modified image.
        /// </returns>
        public Image GetImage(ExportModel model)
        {
            SentinelHelper.ArgumentNull(model);

            var imagePath = model.ParseRelativeFilePath(Path);

            var exist = File.Exists(imagePath);
            return exist
                ? Image.FromFile(imagePath).ApplyEffects(Effects.ToArray()).Flip(Flip.Mode)
                : null;
        }
        #endregion

        #region [public] (Image) GetOriginalImage(ExportModel): Gets a reference to the image object that contains original image
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Image" /> object that contains original image.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Image" /> object that represents original image.
        /// </returns>
        public Image GetOriginalImage(ExportModel model)
        {
            SentinelHelper.ArgumentNull(model);

            var imagePath = model.ParseRelativeFilePath(Path);

            var exist = File.Exists(imagePath);
            return exist
                ? Image.FromFile(imagePath)
                : null;
        }
        #endregion

        #region [public] (void) SetOwner(ImagesModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ImagesModel"/>.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(ImagesModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
