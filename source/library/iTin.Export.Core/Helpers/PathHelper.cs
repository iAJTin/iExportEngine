
using System;
using System.IO;

namespace iTin.Export.Helpers
{
    /// <summary>
    /// Helper class for build relative and absolute path's.
    /// </summary>
    public static class PathHelper
    {
        /// <summary>
        /// Gets a valid full path from a relative path.
        /// </summary>
        /// <param name="targetPath">Relative path.</param>
        /// <param name="baseObject">Base path. If is <b>null</b> then use current assembly.</param>
        /// <returns>
        /// Valid full path.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static string ResolveRelativePath(string targetPath, object baseObject = null)
        {
            SentinelHelper.ArgumentNull(targetPath);

            var relativePathNormalized = targetPath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
            var isRelativePath = relativePathNormalized.Trim().StartsWith("~", StringComparison.Ordinal);
            if (!isRelativePath)
            {
                return targetPath;
            }

            if (relativePathNormalized.Length.Equals(1))
            {
                relativePathNormalized = relativePathNormalized.Insert(1, Path.DirectorySeparatorChar.ToString());
            }
            else if (!relativePathNormalized[1].Equals(Path.DirectorySeparatorChar))
            {
                relativePathNormalized = relativePathNormalized.Insert(1, Path.DirectorySeparatorChar.ToString());
            }

            Uri callingUri;

            if (baseObject == null)
            {
                callingUri = AssemblyHelper.GetFullAssemblyUri();
            }
            else
            {
                var callingPath = baseObject.GetType().Assembly.CodeBase;
                callingUri = new Uri(callingPath);
            }

            var candidateUri = new UriBuilder(callingUri);
            var unscapedCandidateUri = Uri.UnescapeDataString(candidateUri.Path);
            var candidateRootPath = Path.GetDirectoryName(unscapedCandidateUri);

            var outputPartialPath = string.Empty;
            var rootPattern = $"~{Path.DirectorySeparatorChar}";
            if (!relativePathNormalized.Equals(rootPattern))
            {
                outputPartialPath = relativePathNormalized.Split(new[] { rootPattern }, StringSplitOptions.RemoveEmptyEntries)[0];
            }

            var rootPath = candidateRootPath.ToUpperInvariant()
                .Replace("BIN", string.Empty)
                .Replace($"{Path.DirectorySeparatorChar}DEBUG", string.Empty);
            return Path.Combine(rootPath, outputPartialPath);
        }
    }
}
