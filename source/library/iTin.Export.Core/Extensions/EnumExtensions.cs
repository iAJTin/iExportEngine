using System;

using iTin.Export.Model;

namespace iTin.Export.Helper
{
    /// <summary> 
    /// Static class than contains extension methods for objects <see cref="T:System.Enum"/>.
    /// </summary>
    public static class EnumExtensions
    {
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
