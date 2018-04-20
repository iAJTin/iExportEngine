
namespace iTin.Export
{
    using System;
    using System.Text;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.String" />.
    /// </summary> 
    public static class StringExtensions
    {
        /// <summary>
        /// Clears the specified string builder.
        /// </summary>
        /// <param name="builder">The sb.</param>
        public static void Clear(this StringBuilder builder)
        {
            builder.Length = 0;
        }

        /// <summary>
        /// Ases the boolean.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if is boolean; Otherwise <c>false</c>.
        /// </returns>
        public static bool AsBoolean(this string value)
        {
            var val = value.ToUpperInvariant().Trim();

            if (val == "FALSE")
            {
                return false;
            }

            if (val == "NO")
            {
                return false;
            }

            if (val == "F")
            {
                return false;
            }

            if (val == "N")
            {
                return false;
            }

            if (val == "0")
            {
                return false;
            }

            if (val == "TRUE")
            {
                return true;
            }

            if (val == "YES")
            {
                return true;
            }

            if (val == "T")
            {
                return true;
            }

            if (val == "Y")
            {
                return true;
            }

            if (val == "1")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified value is boolean.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if is boolean; Otherwise <c>false</c>.
        /// </returns>
        public static bool IsBoolean(this string value)
        {
            var val = value.ToUpperInvariant().Trim();

            if (val == "FALSE")
            {
                return true;
            }

            if (val == "F")
            {
                return true;
            }

            if (val == "0")
            {
                return true;
            }

            if (val == "TRUE")
            {
                return true;
            }

            if (val == "T")
            {
                return true;
            }

            if (val == "YES")
            {
                return true;
            }

            if (val == "1")
            {
                return true;
            }

            if (val == "NO")
            {
                return true;
            }

            if (val == "Y")
            {
                return true;
            }

            if (val == "N")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Converts string to enum object
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="value">String value to convert</param>
        /// <returns>Returns enum object</returns>
        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        /// <summary>
        /// Converts a string into a "SecureString"
        /// </summary>
        /// <param name="text">Input String</param>
        /// <returns></returns>
        public static System.Security.SecureString ToSecureString(this string text)
        {
            System.Security.SecureString secureString = new System.Security.SecureString();
            foreach (var c in text)
            {
                secureString.AppendChar(c);
            }

            return secureString;
        }

        /////// <summary>
        /////// Returns the plural form of the specified word.
        /////// </summary>
        /////// <param name="count">How many of the specified word there are. A count equal to 1 will not pluralize the specified word.</param>
        /////// <returns>A string that is the plural form of the input parameter.</returns>
        ////public static string ToPlural(this string @this, int count = 0)
        ////{
        ////    return count == 1 ? @this : System.Data.Entity.Design.PluralizationServices.PluralizationService.CreateService(new System.Globalization.CultureInfo("en-US")).Pluralize(@this);
        ////}
    }
}
