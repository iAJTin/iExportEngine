using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    /// <summary>
    /// Base class for different effects compatible with <strong><c>iTin Export Engine</c></strong>.<br/>
    /// Which acts as the base class for different image effects.
    /// </summary>
    /// <remarks>
    ///   <para>The following table shows the different effects.</para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.DisabledEffectModel" /></term>
    ///       <description>Represents disabled effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.GrayScaleEffectModel" /></term>
    ///       <description>Represents gray-scale effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.GrayScaleRedEffectModel" /></term>
    ///       <description>Represents gray-scale red effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.GrayScaleGreenEffectModel" /></term>
    ///       <description>Represents gray-scale green effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.GrayScaleBlueEffectModel" /></term>
    ///       <description>Represents gray-scale blue effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.BrightnessEffectModel" /></term>
    ///       <description>Represents brightness effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.MoreBrightnessEffectModel" /></term>
    ///       <description>Represents more brightness effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.DarkEffectModel" /></term>
    ///       <description>Represents brightness effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.MoreDarkEffectModel" /></term>
    ///       <description>Represents more brightness effect.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.OpacityEffectModel" /></term>
    ///       <description>Represents opacity effect.</description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public partial class BaseEffectModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ImageModel _owner;
        #endregion

        #region public properties

            #region [public] (GlobalResourceImageModel) Owner: Gets the element that owns this.
            /// <summary>
            /// Gets the element that owns this effect.
            /// </summary>
            /// <value>
            /// The <see cref="T:iTin.Export.Model.ImageModel" /> that owns this effect.
            /// </value>
            [XmlIgnore]
            [Browsable(false)]
            public ImageModel Owner
            {
                get { return _owner; }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (void) SetOwner(ImageModel): Sets the element that owns this.
            /// <summary>
            /// Sets the element that owns this effect.
            /// </summary>
            /// <param name="reference">Reference to owner.</param>
            public void SetOwner(ImageModel reference)
            {
                _owner = reference;
            }
            #endregion

        #endregion

        #region public abstract methods

            #region [public] {abstract} (ImageAttributes) Apply(): Gets the manipulation of the colors in an image to an effect.
            /// <summary>
            /// Gets the manipulation of the colors in an image to an effect.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.Drawing.Imaging.ImageAttributes" /> object that contains the information about how bitmap colors are manipulated. 
            /// </returns>
            public abstract ImageAttributes Apply();
            #endregion

        #endregion
    }
}
