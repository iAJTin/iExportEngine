
using System;
using System.IO;
using System.Reflection;

namespace iTin.Export.Helpers
{
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

        public static string GetExecutingAssemblyDirectory()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var codeBaseUri = new Uri(codeBase);
            var uri = new UriBuilder(codeBaseUri);
            var path = Uri.UnescapeDataString(uri.Path);
            return  Path.GetDirectoryName(path);
        }
    }
}
