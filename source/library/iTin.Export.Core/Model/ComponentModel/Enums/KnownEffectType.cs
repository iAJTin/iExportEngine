
namespace iTin.Export.Model
{
    using System.ComponentModel;

    using iTin.Export.Drawing.ComponentModel;

    using ComponentModel;

    /// <summary>
    /// Specifies effects applicable to an image
    /// </summary>
    [TypeConverter(typeof(EffectTypeConverter))]
    public enum KnownEffectType
    {
        /// <summary>
        /// Specifies that the image is drawn without applying any effect.
        /// </summary>
        [EnumDescription("None")]
        None,

        /// <summary>
        /// Specifies that the image is drawn disabled.
        /// </summary>
        [EnumDescription("Disabled")]
        Disabled,

        /// <summary>
        /// Specifies that the image is drawn in grayscale.
        /// </summary>
        [EnumDescription("Gray Scale")]
        GrayScale,

        /// <summary>
        /// Specifies that the image is drawn in grayscale except red color.
        /// </summary>
        [EnumDescription("Gray Scale - Except Red")]
        GrayScaleRed,

        /// <summary>
        /// Specifies that the image is drawn in grayscale except green color.
        /// </summary>
        [EnumDescription("Gray Scale - Except Green")]
        GrayScaleGreen,

        /// <summary>
        /// Specifies that the image is drawn in grayscale except blue color.
        /// </summary>
        [EnumDescription("Gray Scale - Except Blue")]
        GrayScaleBlue,

        /// <summary>
        /// Specifies that the image is drawn with a little more brightness.
        /// </summary>
        [EnumDescription("Brightness")]
        Brightness,

        /// <summary>
        /// Specifies that the image is drawn with much more brightness.
        /// </summary>
        [EnumDescription("More Brightness")]
        MoreBrightness,

        /// <summary>
        /// Specifies that the image is drawn with a little less brightness.
        /// </summary>
        [EnumDescription("Dark")]
        Dark,

        /// <summary>
        /// Specifies that the image is drawn with much less brightness.
        /// </summary>
        [EnumDescription("More Dark")]
        MoreDark,

        /// <summary>
        /// Specifies that the image is drawn with a level of 5 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 5%")]
        OpacityPercent05,

        /// <summary>
        /// Specifies that the image is drawn with a level of 10 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 10%")]
        OpacityPercent10,

        /// <summary>
        /// Specifies that the image is drawn with a level of 20 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 20%")]
        OpacityPercent20,

        /// <summary>
        /// Specifies that the image is drawn with a level of 30 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 30%")]
        OpacityPercent30,

        /// <summary>
        /// Specifies that the image is drawn with a level of 40 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 40%")]
        OpacityPercent40,

        /// <summary>
        /// Specifies that the image is drawn with a level of 50 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 50%")]
        OpacityPercent50,

        /// <summary>
        /// Specifies that the image is drawn with a level of 60 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 60%")]
        OpacityPercent60,

        /// <summary>
        /// Specifies that the image is drawn with a level of 70 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 70%")]
        OpacityPercent70,

        /// <summary>
        /// Specifies that the image is drawn with a level of 80 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 80%")]
        OpacityPercent80,

        /// <summary>
        /// Specifies that the image is drawn with a level of 90 percent opacity.
        /// </summary>
        [EnumDescription("Opacity 90%")]
        OpacityPercent90
    }
}
