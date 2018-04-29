
namespace iTin.Export
{
    /// <summary>
    /// Static class <b>Math</b> provides constants and static methods for conversion operations and other common mathematical functions.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Gets a value indicating whether the parametre is odd.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <b>true</b> if value is odd; <b>false</b> otherwise.
        /// </returns>
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Gets a value indicating whether the parametre is odd.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <b>true</b> if value is odd; <b>false</b> otherwise.
        /// </returns>
        public static bool IsOdd(this uint value)
        {
            return value % 2 != 0;
        }


        /// <summary>
        /// Gets a value indicating whether the parametre is odd.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <b>true</b> if value is odd; <b>false</b> otherwise.
        /// </returns>
        public static bool IsOdd(this short value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Gets a value indicating whether the parametre is odd.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <b>true</b> if value is odd; <b>false</b> otherwise.
        /// </returns>
        public static bool IsOdd(this ushort value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Gets a value indicating whether the parametre is odd.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <b>true</b> if value is odd; <b>false</b> otherwise.
        /// </returns>
        public static bool IsOdd(this long value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Gets a value indicating whether the parametre is odd.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <b>true</b> if value is odd; <b>false</b> otherwise.
        /// </returns>
        public static bool IsOdd(this ulong value)
        {
            return value % 2 != 0;
        }
    }
}
