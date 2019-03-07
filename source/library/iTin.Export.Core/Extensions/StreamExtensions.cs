
namespace iTin.Export
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    using Helpers;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.IO.Stream" />.
    /// </summary> 
    public static class StreamExtensions
    {
        #region public static methods

        #region [public] {static} (byte[]) AsByteArray(this Stream): Returns stream input as byte array
        /// <summary>
        /// Returns stream input as byte array.
        /// </summary>
        /// <param name="stream">Stream to convert.</param>
        /// <returns>
        /// Array of byte that represent the input stream.
        /// </returns>
        public static byte[] AsByteArray(this Stream stream)
        {
            SentinelHelper.ArgumentNull(stream);

            return AsByteArray(stream, false);
        }
        #endregion

        #region [public] {static} (byte[]) AsByteArray(this Stream, bool): Returns stream input as byte array
        /// <summary>
        /// Returns stream input as byte array.
        /// </summary>
        /// <param name="stream">Stream to convert.</param>
        /// <param name="closeAfter">if set to <strong>true</strong> close stream after convert it.</param>
        /// <returns>
        /// Array of byte that represent the input stream.
        /// </returns>
        public static byte[] AsByteArray(this Stream stream, bool closeAfter)
        {
            SentinelHelper.ArgumentNull(stream);

            var buffer = new byte[stream.Length];
            var position = stream.Position;

            stream.Seek(0L, SeekOrigin.Begin);
            stream.Read(buffer, 0, (int)stream.Length);
            stream.Seek(position, SeekOrigin.Begin);

            if (closeAfter)
            {
                stream.Close();
            }

            return buffer;
        }
        #endregion

        #region [public] {static} (Stream) Clone(this Stream): Create a new object that is a copy of specified instance
        /// <summary>
        /// Create a new object that is a copy of the current instance.
        /// </summary>
        /// <param name="stream">Stream to clone.</param>
        /// <returns>
        /// A new <see cref="T:System.IO.Stream" /> that is a copy of specified instance.
        /// </returns>
        public static Stream Clone(this Stream stream)
        {
            SentinelHelper.ArgumentNull(stream, nameof(stream));

            var ms = new MemoryStream();
            stream.CopyTo(ms);
            ms.Position = 0;

            return ms;
        }
        #endregion

        #region [public] {static} (IEnumerable<Stream>) Clone(this IEnumerable<Stream>): Create a new object that is a copy of specified instance
        /// <summary>
        /// Create a new object that is a copy of the current instance.
        /// </summary>
        /// <param name="items">Stream to clone.</param>
        /// <returns>
        /// A new <see cref="T:System.IO.Stream" /> that is a copy of specified instance.
        /// </returns>
        public static IEnumerable<Stream> Clone(this IEnumerable<Stream> items)
        {
            IList<Stream> streamList = items as IList<Stream> ?? items.ToList();
            SentinelHelper.ArgumentNull(streamList, nameof(items));

            List<Stream> clonedList = streamList.Select(item => item.Clone()).ToList();

            return clonedList;
        }
        #endregion

        #region [public] {static} (void) SaveToFile(this Stream, string): Saves this stream into file
        /// <summary>
        /// Saves this memory stream into file
        /// </summary>
        /// <param name="stream">Stream to save.</param>
        /// <param name="fileName">Destination file.</param>
        public static void SaveToFile(this Stream stream, string fileName)
        {
            SentinelHelper.ArgumentNull(stream);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            var memoryStream = stream as MemoryStream ?? stream.ToMemoryStream();
            memoryStream.SaveToFile(fileName);
        }
        #endregion

        #region [public] {static} (MemoryStream) ToMemoryStream(this Stream): Convert a Stream into MemoryStream
        /// <summary>
        /// Convert a <see cref="T:System.IO.Stream" /> into <see cref="T:System.IO.MemoryStream" />.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>
        /// A <see cref="T:System.IO.MemoryStream" /> with content of a <see cref="T:System.IO.Stream" />.
        /// </returns>
        [SuppressMessage("Microsoft.Reliability", "CA2000:Eliminar (Dispose) objetos antes de perder el ámbito")]
        public static MemoryStream ToMemoryStream(this Stream stream)
        {
            SentinelHelper.ArgumentNull(stream);

            MemoryStream resultStream;
            MemoryStream tempStream = null;

            try
            {
                tempStream = new MemoryStream();
                tempStream.SetLength(stream.Length);
                stream.Read(tempStream.GetBuffer(), 0, (int)stream.Length);
                tempStream.Flush();

                resultStream = tempStream;
                tempStream = null;
            }
            finally
            {
                if (tempStream != null)
                {
                    tempStream.Dispose();
                }
            }

            return resultStream;
        }
    #endregion

        #endregion

        #region private static methods

        #region [private] {static} (void) SaveToFile(MemoryStream, string): Saves this memory stream into file
        /// <summary>
        /// Saves this memory stream into file
        /// </summary>
        /// <param name="stream">Stream to save.</param>
        /// <param name="fileName">Destination file.</param>
        private static void SaveToFile(this MemoryStream stream, string fileName)
        {                
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                stream.WriteTo(fs);
            }
        }
        #endregion
        
        #endregion
    }
}
