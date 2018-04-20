
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing.Imaging;
    using System.Xml.Serialization;

    using iTin.Export.Drawing.Helper;

    using Helper;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseEffectModel"/> class.<br/>
    /// Which represents opacity effect.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Effects</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ImageEffectsModel" />.<br/>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Opacity .../&gt;
    /// </code>
    /// </para>
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
    /// <example>
    /// <code lang="xml">
    /// &lt;Effects&gt;
    ///   &lt;Opacity percent="30"/&gt;
    /// &lt;/Effects&gt;
    /// </code>
    /// </example>
    public partial class OpacityEffectModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultPercent = 100.0f;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _percent;
        #endregion

        #region constructor/s

        #region [public] OpacityEffectModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.OpacityEffectModel"/> class.
        /// </summary>
        public OpacityEffectModel()
        {
            Percent = DefaultPercent;
        }
        #endregion

        #endregion

        #region public properties

        [XmlAttribute("percent")]
        [DefaultValue(DefaultPercent)]
        public float Percent
        {
            get => _percent;
            set
            {
                SentinelHelper.ArgumentOutOfRange("value", value, 0.0f, 100.0f, "El valor debe estar comprendido entre 0 y 100");

                _percent = value;
            }
        }

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Percent.Equals(DefaultPercent);
        #endregion

        #endregion

        #region public override methods

        public override ImageAttributes Apply()
        {
            return ImageHelper.GetImageAttributesFromOpacityValueEffect(_percent);
        }

        #endregion
    }
}
