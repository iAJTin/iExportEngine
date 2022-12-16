
using System.Xml;

namespace iTin.Export.Model
{
    using Helpers;

    /// <summary>
    /// Static class that contains helper extension methods for objects <see cref="System.Xml.XmlWriter" /> that allows create <strong>Xslt</strong> sentences easily.
    /// </summary>
    public static class XsltExtensions
    {
        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltStartIf(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteXsltStartIf(string.Empty);
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="condition">The condition.</param>
        public static void WriteXsltStartIf(this XmlWriter writer, string condition)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(condition));
           
            writer.WriteStartElement("xsl:if");              
            writer.WriteAttributeString("test", condition);
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltEndIf(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltStartVariable(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteXsltStartVariable(string.Empty);
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="name">The condition.</param>
        public static void WriteXsltStartVariable(this XmlWriter writer, string name)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(name));

            writer.WriteStartElement("xsl:variable");
            writer.WriteAttributeString("name", name);
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltEndVariable(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltStartChoose(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteStartElement("xsl:choose");
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltEndChoose(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltStartWhen(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteStartElement("xsl:when");
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <typeparam name="T">Test data type</typeparam>
        /// <param name="writer">The writer.</param>
        /// <param name="test">The condition.</param>
        /// <param name="testok">The test true.</param>
        public static void WriteXsltStartWhen<T>(this XmlWriter writer, string test, T testok)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.IsTrue(testok.Equals(null));
            SentinelHelper.IsTrue(string.IsNullOrEmpty(test));

            writer.WriteStartElement("xsl:when");
            writer.WriteAttributeString("test", test);
            writer.WriteValue(testok);
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltEndWhen(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);

            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltStartOtherwise(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteStartElement("xsl:otherwise");
        }

        /// <summary>
        /// Gets the appropriate formula for this aggregate.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public static void WriteXsltEndOtherwise(this XmlWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            
            writer.WriteEndElement();
        }
    }
}
