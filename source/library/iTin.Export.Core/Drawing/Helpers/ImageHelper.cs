using System.Drawing.Imaging;

using iTin.Export.Model;

namespace iTin.Export.Drawing.Helper
{
    /// <summary> 
    /// Static class than contains methods for manipulating images.
    /// </summary>
    static class ImageHelper
    {
        private static readonly ColorMatrix DisabledColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 0.30f, 0.30f, 0.30f, 0.00f, 0.00f }, 
                        new[] { 0.59f, 0.59f, 0.59f, 0.00f, 0.00f },
                        new[] { 0.11f, 0.11f, 0.11f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 0.00f, -0.60f, 1.00f }
                    });

        private static readonly ColorMatrix GrayScaleColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 0.30f, 0.30f, 0.30f, 0.00f, 0.00f }, 
                        new[] { 0.59f, 0.59f, 0.59f, 0.00f, 0.00f },
                        new[] { 0.11f, 0.11f, 0.11f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 0.00f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix GrayScaleRedColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 1.00f, 0.00f, 0.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.59f, 0.59f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.11f, 0.11f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 0.00f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix GrayScaleGreenColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 0.30f, 0.00f, 0.30f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 1.00f, 0.00f, 0.00f, 0.00f },
                        new[] { 0.11f, 0.00f, 0.11f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 0.00f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix GrayScaleBlueColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 0.30f, 0.30f, 0.00f, 0.00f, 0.00f }, 
                        new[] { 0.59f, 0.59f, 0.00f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 1.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 0.00f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix BrightnessColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 1.00f, 0.00f, 0.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 1.00f, 0.00f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 1.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.10f, 0.10f, 0.10f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix MoreBrightnessColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 1.00f, 0.00f, 0.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 1.00f, 0.00f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 1.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { 0.20f, 0.20f, 0.20f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix DarkColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 1.00f, 0.00f, 0.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 1.00f, 0.00f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 1.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { -0.10f, -0.10f, -0.10f, 0.00f, 1.00f }
                    });

        private static readonly ColorMatrix MoreDarkColorMatrix =
            new ColorMatrix(
                new[]
                    {
                        new[] { 1.00f, 0.00f, 0.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 1.00f, 0.00f, 0.00f, 0.00f },
                        new[] { 0.00f, 0.00f, 1.00f, 0.00f, 0.00f }, 
                        new[] { 0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
                        new[] { -0.25f, -0.25f, -0.25f, 0.00f, 1.00f }
                    });

        /// <summary>
        /// Gets the manipulation of the colors in an image to an effect.
        /// </summary>
        /// <param name="effect">Effect type.</param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Imaging.ImageAttributes" /> object that contains the information about how bitmap colors are manipulated. 
        /// </returns>
        public static ImageAttributes GetImageAttributesFromEffect(KnownEffectType effect)
        {
            var newColorMatrix = new ColorMatrix();
            switch (effect)
            {
                case KnownEffectType.None:
                    break;

                case KnownEffectType.Disabled:
                    newColorMatrix = DisabledColorMatrix;
                    break;

                case KnownEffectType.GrayScale:
                    newColorMatrix = GrayScaleColorMatrix;
                    break;

                case KnownEffectType.GrayScaleRed:
                    newColorMatrix = GrayScaleRedColorMatrix;
                    break;

                case KnownEffectType.GrayScaleGreen:
                    newColorMatrix = GrayScaleGreenColorMatrix;
                    break;

                case KnownEffectType.Brightness:
                    newColorMatrix = BrightnessColorMatrix;
                    break;

                case KnownEffectType.MoreBrightness:
                    newColorMatrix = MoreBrightnessColorMatrix;
                    break;

                case KnownEffectType.Dark:
                    newColorMatrix = DarkColorMatrix;
                    break;

                case KnownEffectType.MoreDark:
                    newColorMatrix = MoreDarkColorMatrix;
                    break;

                case KnownEffectType.GrayScaleBlue:
                    newColorMatrix = GrayScaleBlueColorMatrix;
                    break;

                case KnownEffectType.OpacityPercent05:
                    newColorMatrix.Matrix33 = 0.05f;
                    break;

                case KnownEffectType.OpacityPercent10:
                    newColorMatrix.Matrix33 = 0.10f;
                    break;

                case KnownEffectType.OpacityPercent20:
                    newColorMatrix.Matrix33 = 0.20f;
                    break;

                case KnownEffectType.OpacityPercent30:
                    newColorMatrix.Matrix33 = 0.30f;
                    break;

                case KnownEffectType.OpacityPercent40:
                    newColorMatrix.Matrix33 = 0.40f;
                    break;

                case KnownEffectType.OpacityPercent50:
                    newColorMatrix.Matrix33 = 0.50f;
                    break;

                case KnownEffectType.OpacityPercent60:
                    newColorMatrix.Matrix33 = 0.60f;
                    break;

                case KnownEffectType.OpacityPercent70:
                    newColorMatrix.Matrix33 = 0.70f;
                    break;

                case KnownEffectType.OpacityPercent80:
                    newColorMatrix.Matrix33 = 0.80f;
                    break;

                case KnownEffectType.OpacityPercent90:
                    newColorMatrix.Matrix33 = 0.90f;
                    break;
            }

            ImageAttributes imageAttributes;
            ImageAttributes tempImageAttributes = null;
            try
            {
                tempImageAttributes = new ImageAttributes();
                tempImageAttributes.SetColorMatrix(newColorMatrix);
                imageAttributes = (ImageAttributes)tempImageAttributes.Clone();
            }
            finally
            {
                if (tempImageAttributes != null)
                {
                    tempImageAttributes.Dispose();
                }
            }

            return imageAttributes;
        }

        /// <summary>
        /// Gets the manipulation of the colors in an image to an effect.
        /// </summary>
        /// <param name="threshold">Effect type.</param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Imaging.ImageAttributes" /> object that contains the information about how bitmap colors are manipulated. 
        /// </returns>
        public static ImageAttributes GetImageAttributesFromOpacityValueEffect(float threshold)
        {
            ImageAttributes imageAttributes;
            ImageAttributes tempImageAttributes = null;
            try
            {
                tempImageAttributes = new ImageAttributes();
                tempImageAttributes.SetColorMatrix(new ColorMatrix { Matrix33 = threshold / 100.0f });
                imageAttributes = (ImageAttributes)tempImageAttributes.Clone();
            }
            finally
            {
                if (tempImageAttributes != null)
                {
                    tempImageAttributes.Dispose();
                }
            }

            return imageAttributes;
        }
    }
}
