
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    /// <summary>
    /// Represents a logo.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Table</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TableModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
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
    ///       <td><see cref="P:iTin.Export.Model.LogoModel.Effects" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Reference to effects collection to apply to logo. The default is <see cref="iTin.Export.Model.KnownEffectType.None"/>.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.LogoModel.Flip" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred flip style to apply to logo. The default is <c><see cref="iTin.Export.Model.KnownFlipStyle.None" /></c>.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.LogoModel.Size" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred size of the logo. The default is <c>-1 -1</c>, indicates original size of logo.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.LogoModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the logo. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.</td>
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
    public partial class LogoImageModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LogoModel parent;
        #endregion

        #region public properties

        #region [public] (string) Key: Gets or sets a reference to collection of effects to apply to logo
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        [XmlAttribute]
        public string Key { get; set; }
        #endregion

        #region [public] (LogoModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public LogoModel Parent => parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise <strong>false</strong>.
        /// </value>
        public override bool IsDefault => string.IsNullOrEmpty(Key);
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) TryGetImage(out Image): Gets a reference to the image object that contains modified image
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Image" /> object that contains modified image.
        /// </summary>
        /// <param name="image">A <see cref="T:System.Drawing.Image" /> object that represents modified image.</param>
        /// <returns>
        /// <strong>true</strong> if returns the image from resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetImage(out Image image)
        {
            image = null;

            var foudResource = TryGetResourceInformation(out var resource);
            if (!foudResource)
            {
                return true;
            }

            var logo = parent;
            var table = logo.Parent;
            var export = table.Parent;
            image = resource.GetImage(export);

            return true;
        }
        #endregion

        #region [public] (bool) TryGetOriginalImage(out Image): Gets a reference to the image object that contains original image
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Image" /> object that contains modified image.
        /// </summary>
        /// <param name="image">A <see cref="T:System.Drawing.Image" /> object that represents modified image.</param>
        /// <returns>
        /// <strong>true</strong> if returns the image from resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetOriginalImage(out Image image)
        {
            image = null;

            var foudResource = TryGetResourceInformation(out var resource);
            if (!foudResource)
            {
                return true;
            }

            var logo = parent;
            var table = logo.Parent;
            var export = table.Parent;
            image = resource.GetOriginalImage(export);

            return true;
        }
        #endregion

        #region [public] (bool) TryGetResourceInformation(out ImageModel): Gets a reference to the image resource information
        /// <summary>
        /// Gets a reference to the image resource information.
        /// </summary>
        /// <param name="resource">Resource information.</param>
        /// <returns>
        /// <strong>true</strong> if exist available information about resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetResourceInformation(out ImageModel resource)
        {
            bool result;

            resource = null;
            if (string.IsNullOrEmpty(Key))
            {
                return false;
            }

            try
            {
                var logo = parent;
                var table = logo.Parent;
                var export = table.Parent;
                resource = export.Resources.GetImageResourceByKey(Key);

                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(LogoModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(LogoModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
