
namespace iTin.Export.Helpers
{
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary> 
    /// Static class than contains methods for manipulating objects of type <see cref="T:System.IO.Stream" />.
    /// </summary>
    public static class StreamHelper
    {
        /// <summary>
        /// Returns the specified file as a byte array.
        /// </summary>
        /// <param name="fileName">File to convert.</param>
        /// <returns>
        /// Array of byte than represent the file.
        /// </returns>
        public static byte[] AsByteArrayFromFile(string fileName)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            byte[] buffer;

            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                buffer = stream.AsByteArray();
            }

            return buffer;
        }

        /// <summary>
        /// Convert input file to memory stream.
        /// </summary>
        /// <param name="fileName">File to convert.</param>
        /// <returns>
        /// A <see cref="T:System.IO.MemoryStream" /> than represent the input file.
        /// </returns>
        [SuppressMessage("Microsoft.Reliability", "CA2000:Eliminar (Dispose) objetos antes de perder el ámbito")]
        public static MemoryStream AsMemoryStreamFromFile(string fileName)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            MemoryStream ms;
            FileStream fs = null;
            MemoryStream mstemp = null;

            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {
                    mstemp = new MemoryStream(fs.AsByteArray());
                    ms = mstemp;
                    mstemp = null;
                }
                finally
                {
                    if (mstemp != null)
                    {
                        mstemp.Dispose();
                    }
                }
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }

            return ms;
        }
    }
}
