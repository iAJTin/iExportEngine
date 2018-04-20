
namespace iTin.Export.Helper
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    /// <summary> 
    /// Static class than contains methods for manipulating files.
    /// </summary>
    public static class FileHelper
    {
        #region private constants
        private const string TinExportTempDirectoryName = "iTin.Export";
        #endregion

        #region public static properties

        #region [public] {static} (string) TinExportTempDirectory: Gets the export temporary directory
        /// <summary>
        /// Gets the export temporary directory.
        /// </summary>
        /// <value>
        /// The export temporary directory.
        /// </value>
        public static string TinExportTempDirectory
        {
            get 
            { 
                var tempFullPath = Path.GetTempPath();
                var tempDirectory = Path.Combine(tempFullPath, TinExportTempDirectoryName);

                return tempDirectory;
            }
        }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (void) CopyFiles(string, string, string, bool): Copies the files
        /// <summary>
        /// Copies the files.
        /// </summary>
        /// <param name="sourceDirectory">Source directory.</param>
        /// <param name="targetDirectory">Target directory.</param>
        /// <param name="criterial">File criteria.</param>
        /// <param name="overrides">if is <strong>true</strong> overrides destination file.</param>
        public static void CopyFiles(string sourceDirectory, string targetDirectory, string criterial, bool overrides)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(sourceDirectory));
            SentinelHelper.IsTrue(string.IsNullOrEmpty(targetDirectory));

            var items = Directory.GetFiles(sourceDirectory, criterial, SearchOption.TopDirectoryOnly);
            foreach (var item in items)
            {
                var filename = Path.GetFileName(item);
                var target = Path.Combine(targetDirectory, filename);

                File.Copy(item, target, overrides);
            }
        }
        #endregion

        #region [public] {static} (Uri) GetUniqueTempRandomFile: Returns a temp Uri for a new file
        /// <summary>
        /// Returns a temp <see cref="T:System.Uri"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Uri" /> file.
        /// </returns>
        public static Uri GetUniqueTempRandomFile()
        {
            var tempPath = Path.GetTempPath();
            var randomFileName = Path.GetRandomFileName();
            var path = Path.Combine(tempPath, randomFileName);

            return new Uri(path);
        }
        #endregion

        #region [public] {static} (bool) IsValidFileName(string): Determines whether name is a valid name for a file
        /// <summary>
        /// Determines whether <paramref name="name" /> is a valid name for a file.
        /// </summary>
        /// <param name="name">Filename to check.</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="name" /> is a valid file name; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidFileName(string name)
        {
            return Path.GetInvalidFileNameChars().All(c => !name.Contains(c.ToString(CultureInfo.InvariantCulture)));
        }
        #endregion

        #endregion
    }
}
