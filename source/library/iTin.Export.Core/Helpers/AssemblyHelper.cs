
namespace iTin.Export.Helpers
{
    using System;
    using System.Reflection;

    /// <summary> 
    /// Static class which contains methods for retrieve <see cref="T:System.Assembly" /> information.
    /// </summary>
    public static class AssemblyHelper
    {
        /// <summary>
        /// Returns <see cref="T:System.Uri" /> that contains full path to current assembly.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Uri" /> that contains full path to current assembly.
        /// </returns>
        public static Uri GetFullAssemblyUri()
        {
            return new Uri(Assembly.GetCallingAssembly().CodeBase);
        }
    }
}
