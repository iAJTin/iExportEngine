
using System.Drawing;
using System.Linq;

using iTin.Export.Drawing.Helper;
using iTin.Export.Helpers;
using iTin.Export.Model;

namespace iTin.Export.Drawing
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="System.Drawing.Image" />.
    /// </summary> 
    public static class ImageExtensions
    {
        /// <summary>
        /// Returns a new Image with the specified effects.
        /// </summary>
        /// <param name="image">Image object to which the effect is applied.</param>
        /// <param name="effects">Array of <see cref="T:iTin.Export.Model.KnownEffectType"/> with different effects to apply.</param>
        /// <returns>
        /// Returns a new <see cref="T:System.Drawing.Image"/>, result of applying the effects to specified image .
        /// </returns>
        public static Image ApplyEffects(this Image image, KnownEffectType[] effects)
        {
            SentinelHelper.ArgumentNull(image);
            SentinelHelper.ArgumentNull(effects);

            var imageWithEffect = (Image)image.Clone();
            return effects.Aggregate(imageWithEffect, (current, e) => current.ApplyEffect(e));
        }

        /// <summary>
        /// Returns a new Image with the specified effects.
        /// </summary>
        /// <param name="image">Image object to which the effect is applied.</param>
        /// <param name="effects">Array of <see cref="T:iTin.Export.Model.KnownEffectType"/> with different effects to apply.</param>
        /// <returns>
        /// Returns a new <see cref="T:System.Drawing.Image"/>, result of applying the effects to specified image .
        /// </returns>
        public static Image ApplyEffects(this Image image, BaseEffectModel[] effects)
        {
            SentinelHelper.ArgumentNull(image);
            SentinelHelper.ArgumentNull(effects);

            var imageWithEffect = (Image)image.Clone();
            return effects.Aggregate(imageWithEffect, (current, effect) => current.ApplyEffect(effect));
        }

        /// <summary>
        /// Returns a new <see cref="T:System.Drawing.Image"/> with the specified effect.
        /// </summary>
        /// <param name="image">Image object to which the effect is applied.</param>
        /// <param name="effect">Effect type.</param>
        /// <returns>
        /// Returns a new <see cref="T:System.Drawing.Image"/>, result of applying the effect to specified image .
        /// </returns>
        public static Image ApplyEffect(this Image image, BaseEffectModel effect)
        {
            SentinelHelper.ArgumentNull(image);

            Image imageWithEffect;
            using (var bmp = new Bitmap(image.Width, image.Height))
            {
                using (var graphics = Graphics.FromImage(bmp))
                {
                    bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                    graphics.DrawImage(
                        image,
                        new Rectangle(0, 0, bmp.Width, bmp.Height),
                        0,
                        0,
                        bmp.Width,
                        bmp.Height,
                        GraphicsUnit.Pixel,
                        effect.Apply());
                    imageWithEffect = (Image)bmp.Clone();
                }
            }

            return imageWithEffect;
        }

        /// <summary>
        /// Returns a new <see cref="T:System.Drawing.Image"/> with the specified effect.
        /// </summary>
        /// <param name="image">Image object to which the effect is applied.</param>
        /// <param name="effect">Effect type.</param>
        /// <returns>
        /// Returns a new <see cref="T:System.Drawing.Image"/>, result of applying the effect to specified image .
        /// </returns>
        public static Image ApplyEffect(this Image image, KnownEffectType effect)
        {
            SentinelHelper.ArgumentNull(image);

            Image imageWithEffect;
            using (var bmp = new Bitmap(image.Width, image.Height))
            {
                using (var graphics = Graphics.FromImage(bmp))
                {
                    bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                    graphics.DrawImage(
                        image,
                        new Rectangle(0, 0, bmp.Width, bmp.Height),
                        0,
                        0,
                        bmp.Width,
                        bmp.Height,
                        GraphicsUnit.Pixel,
                        ImageHelper.GetImageAttributesFromEffect(effect));
                    imageWithEffect = (Image)bmp.Clone();
                }
            }

            return imageWithEffect;
        }

        /// <summary>
        /// returns a new <see cref="T:System.Drawing.Image"/> rotated by the specified orientation.
        /// </summary>
        /// <param name="image"><see cref="T:System.Drawing.Image"/> to be rotated.</param>
        /// <param name="style">New orientation.</param>
        /// <returns>
        /// Returns a new <see cref="T:System.Drawing.Image"/> rotated by the specified orientation..
        /// </returns>
        public static Image Flip(this Image image, KnownFlipStyle style)
        {
            SentinelHelper.IsEnumValid(style);

            if (image == null)
            {
                return null;
            }

            var flipImage = (Image)image.Clone();
            switch (style)
            {
                case KnownFlipStyle.None:
                    flipImage.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    break;

                case KnownFlipStyle.X:
                    flipImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;

                case KnownFlipStyle.Y:
                    flipImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;

                case KnownFlipStyle.XY:
                    flipImage.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                    break;
            }

            return flipImage;
        }
    }
}
