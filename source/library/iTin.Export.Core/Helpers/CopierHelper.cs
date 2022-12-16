
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace iTin.Export.Helpers
{
    /// <summary> 
    /// Static class than contains methods for cloning objects.
    /// </summary>
    public static class CopierHelper
    {
        /// <summary>
        /// Deeps the copy 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">El tipo de dato debe ser serializable.</exception>
        public static T DeepCopy<T>(T source)
        {
            // Verificamos que sea serializable antes de hacer la copia
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("El tipo de dato debe ser serializable.", "source");
            }

            if (ReferenceEquals(source, null))
            {
                return default(T);
            }

            // Creamos un stream en memoria
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);

                // Deserializamos la porcón de memoria en el nuevo objeto
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
