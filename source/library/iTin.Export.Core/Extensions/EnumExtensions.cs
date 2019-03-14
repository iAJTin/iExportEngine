
namespace iTin.Export
{
    using System;

    using Helpers;
    using Model;

    /// <summary> 
    /// Static class than contains extension methods for objects <see cref="T:System.Enum"/>.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Converts a value of the enumerated type <see cref="YesNo"/> to boolean representation
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>
        /// <c>true</c> if value is <c>Yes</c>; otherwise, <c>false</c>.
        /// </returns>
        public static bool AsBoolean(this YesNo value) => value == YesNo.Yes;

        /// <summary>
        /// Returns index in the enum type.
        /// </summary>
        /// <param name="item">Target item.</param>
        /// <returns>
        /// Index in the enum type.
        /// </returns>
        public static int IndexOf(this KnownWidthLineStyle item)
        {
            SentinelHelper.IsEnumValid(item);

            var enumArray = (KnownWidthLineStyle[]) Enum.GetValues(typeof (KnownWidthLineStyle));
            return Array.IndexOf(enumArray, item);
        }
    }
}
