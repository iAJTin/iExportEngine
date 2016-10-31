using System.Diagnostics.CodeAnalysis;
using System.Xml;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Static class that contains helper extension methods for objects <see cref="System.Xml.XmlWriter" /> that allows create <strong>Xslt</strong> sentences easily.
    /// </summary>
    public static class XsltExtensions
    {
        #region [public] {static} (void) WriteXsltStartIf(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartIf(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteXsltStartIf(string.Empty);
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartIf(this XmlWriter, string): 
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="condition">The condition.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartIf(this XmlWriter writer, string condition)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(condition));
           
            writer.WriteStartElement("xsl:if");              
            writer.WriteAttributeString("test", condition);
        }
        #endregion

        #region [public] {static} (void) WriteXsltEndIf(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltEndIf(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteEndElement();
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartVariable(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartVariable(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteXsltStartVariable(string.Empty);
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartVariable(this XmlWriter, string):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="name">The condition.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartVariable(this XmlWriter writer, string name)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(name));

            writer.WriteStartElement("xsl:variable");
            writer.WriteAttributeString("name", name);
        }
        #endregion

        #region [public] {static} (void) WriteXsltEndVariable(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltEndVariable(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteEndElement();
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartChoose(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartChoose(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteStartElement("xsl:choose");
        }
        #endregion

        #region [public] {static} (void) WriteXsltEndChoose(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltEndChoose(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteEndElement();
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartWhen(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartWhen(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteStartElement("xsl:when");
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartWhen<T>(this XmlWriter, string, T):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <typeparam name="T">Test data type</typeparam>
        /// <param name="writer">The writer.</param>
        /// <param name="test">The condition.</param>
        /// <param name="testok">The test true.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartWhen<T>(this XmlWriter writer, string test, T testok)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.IsTrue(testok.Equals(null));
            SentinelHelper.IsTrue(string.IsNullOrEmpty(test));

            writer.WriteStartElement("xsl:when");
            writer.WriteAttributeString("test", test);
            writer.WriteValue(testok);
        }
        #endregion

        #region [public] {static} (void) WriteXsltEndWhen(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltEndWhen(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteEndElement();
        }
        #endregion

        #region [public] {static} (void) WriteXsltStartOtherwise(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltStartOtherwise(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteStartElement("xsl:otherwise");
        }
        #endregion

        #region [public] {static} (void) WriteXsltEndOtherwise(this XmlWriter):
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static void WriteXsltEndOtherwise(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteEndElement();
        }
        #endregion
    }
}
