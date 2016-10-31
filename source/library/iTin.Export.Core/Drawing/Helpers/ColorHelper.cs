using System;
using System.Drawing;
using System.Globalization;

namespace iTin.Export.Drawing.Helper
{
    /// <summary> 
    /// Static class that contains methods for manipulating structures of type <see cref="T:System.Drawing.Color"/>.
    /// </summary>
    public static class ColorHelper
    {
        #region Public Static Methods

            #region [public] {static} (Color) GetColorFromString(string): Returns a color structure from its name, its hexdecimal encoding or from color space definition.
            /// <summary>
            /// Returns a new <see cref="T:System.Drawing.Color"/> structure from its name, its hexdecimal encoding or from color space definition.
            /// </summary>
            /// <param name="value">A <see cref="T:System.String" /> that represents the color to convert.</param>
            /// <returns>
            /// Creates a new <see cref="T:System.Drawing.Color" /> structure from the specified string color.
            /// </returns>
            /// <remarks>
            /// The <paramref name="value"/> parameter may contain:
            /// <list type="table">
            ///   <item>
            ///     <description>A color name, such as <see cref="P:System.Drawing.Color.Black"/>, <see cref="P:System.Drawing.Color.Red"/>.</description>
            ///   </item>
            ///   <item>
            ///     <description>A hexadecimal RGB color encoding preceded by the character <strong>#</strong>, such as <strong>#00FF00</strong>, <strong>#00FFFF</strong>.</description>
            ///   </item>
            ///   <item>
            ///     <description>
            ///       A space color definition, for this has to precede the color string with this string <strong>sc#</strong>.
            ///       <para>for example <strong>sc# 0.15 0.15 0.15</strong>, where the three color components (RGB) are set to 15% of its maximum value, producing a very light gray. 
            ///       Each component has to be between <strong>0.0</strong> and <strong>1.0</strong>.</para>    
            ///     </description>
            ///   </item>
            ///  </list>
            ///  <para><strong>iTin Export Engine</strong> uses this method for convert the value of some color attribute of an element of <strong>XML</strong> model.</para>
            ///  For example, in the following list of styles for each color attribute value, there are a call to this method to make your conversion to a valid color in <strong>.Net Framework</strong>.
            ///  <code lang="xml">
            ///    &lt;Styles&gt;
            /// 
            ///      &lt;Style Name="Style1"&gt;
            ///        &lt;Content Color="#C9C9C9"&gt;
            ///          &lt;Alignment Horizontal="Left" Vertical="Center"/&gt;
            ///          &lt;Text/&gt;
            ///        &lt;Content/&gt;
            ///        &lt;Font Color="Green" Bold="Yes"/&gt;
            ///      &lt;/Style&gt;
            /// 
            ///      &lt;Style Name="Style2"&gt;
            ///        &lt;Content Color="sc# 0.15 0.15 0.15">&gt;
            ///          &lt;Alignment Vertical="Top"/&gt;
            ///          &lt;Text/&gt;
            ///        &lt;Content/&gt;
            ///        &lt;Font Size="10" Color="Navy"/&gt;
            ///      &lt;/Style&gt;
            /// 
            ///      &lt;Style Name="Style3"&gt;
            ///        &lt;Content Color="Red"&gt;
            ///          &lt;Text/&gt;
            ///        &lt;Content/&gt;
            ///        &lt;Font Size="10"/&gt;
            ///      &lt;/Style&gt;
            /// 
            ///    &lt;/Styles&gt;
            /// </code>
            /// </remarks>
            /// <example>
            /// The following code example, we obtain three different ways the same color, the color <see cref="P:System.Drawing.Color.Black"/>.
            /// <code lang="cs">
            ///   using System;   
            ///   using System.Drawing;
            /// 
            ///   using iTin.Export.Helper;
            /// 
            ///   class ColorTestClass   
            ///   {   
            ///       static int Main()   
            ///       {
            ///            // From color name.
            ///            Color fromColorName = ColorHelper.GetColorFromString("Black");
            ///
            ///            // From hexadecimal.
            ///            Color fromHexString = ColorHelper.GetColorFromString("#000000");
            /// 
            ///            // From space color.
            ///            Color fromSpace = ColorHelper.GetColorFromString("sc: 0.0 0.0 0.0");
            ///       }
            ///   }   
            ///  </code>
            /// </example>
            public static Color GetColorFromString(string value)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return Color.Empty;
                }                

                var isHexColor = value.Trim().StartsWith("#", StringComparison.Ordinal);
                if (isHexColor)
                {
                    return ColorTranslator.FromHtml(value);
                }

                var isSpaceColor = value.Trim().StartsWith("sc#", StringComparison.Ordinal);
                if (isSpaceColor)
                {
                    return FromSpaceColor(value);
                }

                return Color.FromName(value);
            }
            #endregion

            #region [public] {static} (Color) MergeColors(Color, float, Color, float): Combine two colors with relative percentages.
            /// <summary>
            /// Combine two colors with relative percentages.
            /// </summary>
            /// <param name="color1">First color.</param>
            /// <param name="percent1">Percentage of the first color.</param>
            /// <param name="color2">Second color</param>
            /// <param name="percent2">Percentage of the second color.</param>
            /// <returns>
            /// Returns a new <see cref="T:System.Drawing.Color" /> structure as result of the combination.
            /// </returns>
            public static Color MergeColors(Color color1, float percent1, Color color2, float percent2)
            {
                return MergeColors(color1, percent1, color2, percent2, Color.Empty, 0f);
            }
            #endregion

            #region [public] {static} (Color) MergeColors(Color, float, Color, float, Color, float): Combine three colors with relative percentages.
            /// <summary>
            /// Combinar tres colores con porcentajes relativos.
            /// </summary>
            /// <param name="color1">First color.</param>
            /// <param name="percent1">Percentage of the first color.</param>
            /// <param name="color2">Second color</param>
            /// <param name="percent2">Percentage of the second color.</param>
            /// <param name="color3">Third color.</param>
            /// <param name="percent3">Percentage of the third color.</param>
            /// <returns>
            /// Returns a new <see cref="T:System.Drawing.Color" /> structure as result of the combination.
            /// </returns>
            public static Color MergeColors(Color color1, float percent1, Color color2, float percent2, Color color3, float percent3)
            {
                var red = (int)((color1.R * percent1) + (color2.R * percent2) + (color3.R * percent3));
                var green = (int)((color1.G * percent1) + (color2.G * percent2) + (color3.G * percent3));
                var blue = (int)((color1.B * percent1) + (color2.B * percent2) + (color3.B * percent3));

                if (red < 0)
                {
                    red = 0;
                }

                if (red > 255)
                {
                    red = 255;
                }

                if (green < 0)
                {
                    green = 0;
                }

                if (green > 255)
                {
                    green = 255;
                }

                if (blue < 0)
                {
                    blue = 0;
                }

                if (blue > 255)
                {
                    blue = 255;
                }

                return Color.FromArgb(red, green, blue);
            }
            #endregion

            #region [public] {static} (Color) ToGray(Color): Converts specified color to grayscale.
            /// <summary>
            /// Converts specified color to grayscale.
            /// </summary>
            /// <param name="color"><see cref="T:System.Drawing.Color"/> structure to convert.</param>
            /// <returns>
            /// Returns a new <see cref="T:System.Drawing.Color"/> structure converted to grayscale.
            /// </returns>
            public static Color ToGray(Color color)
            {
                int gray = (color.R + color.G + color.B) / 3;
                color = Color.FromArgb(gray, gray, gray);
                return color;
            }
            #endregion

            #region [public] {static} (string) ToHex(Color): Returns the hexadecimal encoding of a color.
            /// <summary>
            /// Returns the hexadecimal encoding of a color.
            /// </summary>
            /// <param name="value"><see cref="T:System.Drawing.Color"/> structure to convert.</param>
            /// <returns>
            /// A hexadecimal <see cref="T:System.String" /> representing color.
            /// </returns>
            /// <example>
            /// The following code example, we obtain hexadecimal code for white color without chararacter <strong>#</strong>. The result is <strong>FFFFFF</strong>.
            /// <code lang="cs">
            ///   using System;   
            ///   using System.Drawing;
            /// 
            ///   using iTin.Export.Helper;
            /// 
            ///   class ColorTestClass   
            ///   {   
            ///       static int Main()   
            ///       {
            ///            // From color name.
            ///            string hexColorString = ColorHelper.GetColorFromString(Color.White);
            ///            
            ///            // Print result.
            ///            Console.WriteLine("The hexadecimal representation of the color white is {0}", hexColorString); 
            ///       }
            ///   }   
            ///  </code>
            /// </example>
            public static string ToHex(Color value)
            {
                return value.ToHex();
            }
        #endregion

            #region [public] {static} (Color) ToTransparencyLevel(Color, int): Sets transparency level of specified color.
            /// <summary>
            /// Sets transparency level of specified color.
            /// </summary>
            /// <param name="color"><see cref="T:System.Drawing.Color"/> structure to convert.</param>
            /// <param name="opacity">El nivel de transparencia aplicado. The value must be between 0 and 255.</param>
            /// <returns>
            /// Returns a new <see cref="T:System.Drawing.Color"/> structure with specified transparency level.
            /// </returns>
            /// <remarks>
            /// If the value is outside the limits, not makes no changes.
            /// </remarks>
            public static Color ToTransparencyLevel(Color color, int opacity)
            {
                if ((opacity < 0) || (opacity > 255))
                {
                    return color;
                }

                color = Color.FromArgb(opacity, color);
                return color;
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (Color) FromSpaceColor(string): A color obtained from the color percentage of each of its components.
            /// <summary>
            /// A color obtained from the color percentage of each of its components.
            /// </summary>
            /// <param name="value">A <see cref="T:System.String" /> that represents the color to convert.</param>
            /// <returns>
            /// Creates a <see cref="T:System.Drawing.Color" /> structure from the specified string color.
            /// </returns>
            private static Color FromSpaceColor(string value)
            {
                string[] valueArray = null;

                if (value.StartsWith("sc#", StringComparison.Ordinal))
                {
                    value = value.Substring(4);
                    valueArray = value.Split(' ');
                }

                if (valueArray == null)
                {
                    throw new InvalidOperationException(Resources.ErrorMessage.InvalidColor);
                }

                var r = 0xff * (1 - float.Parse(valueArray[0], CultureInfo.InvariantCulture));
                var g = 0xff * (1 - float.Parse(valueArray[1], CultureInfo.InvariantCulture));
                var b = 0xff * (1 - float.Parse(valueArray[2], CultureInfo.InvariantCulture));

                return Color.FromArgb((int)r, (int)g, (int)b);
            }
            #endregion

        #endregion
    }
}
