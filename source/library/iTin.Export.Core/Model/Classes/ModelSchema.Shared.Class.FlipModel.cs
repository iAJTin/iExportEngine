
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Flip mode for an image.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Image</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.GlobalResourceImageModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Flip .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.FlipModel.Mode" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred flip style to apply to an image. The default is <see cref="iTin.Export.Model.KnownFlipStyle.None" />.</td>
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
    ///       <td align="center">No has effect</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class FlipModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownFlipStyle DefaultMode = KnownFlipStyle.None;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownFlipStyle _mode;
        #endregion

        #region constructor/s

        #region [public] FlipModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.FlipModel" /> class.
        /// </summary>
        public FlipModel()
        {
            Mode = DefaultMode;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownFlipStyle) Mode: Gets or sets preferred flip style to apply to an image
        /// <summary>
        /// Gets or sets preferred flip style to apply to an image.
        /// </summary>
        /// <value>
        /// Preferred flip style to apply to an image. The default is <see cref="iTin.Export.Model.KnownFlipStyle.None" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Flip Mode="None|X|Y|XY"/&gt;
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
        [DefaultValue(DefaultMode)]
        public KnownFlipStyle Mode
        {
            get => _mode;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _mode = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault&quot;]/*" />
        public override bool IsDefault => Mode.Equals(DefaultMode);
        #endregion

        #endregion

        #region public methods

        #region [public] (FlipModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public FlipModel Clone()
        {
            var flipCloned = (FlipModel)MemberwiseClone();
            flipCloned.Properties = Properties.Clone();

            return flipCloned;
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
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
