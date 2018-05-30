
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    /// <summary>
    /// Specifies how an object or text is horizontally aligned relative to a content
    /// </summary>
    [GeneratedCode("System.Xml", "4.0.30319.33440")]
    [Serializable]
    [XmlType(Namespace = "http://schemas.iTin.com/export/engine/2013/configuration")]
    public enum KnownHorizontalAlignment
    {
        /// <summary>
        /// Content is aligned horizontally on the left.
        /// </summary>
        Left,

        /// <summary>
        /// Content is aligned horizontally in the center.
        /// </summary>
        Center,

        /// <summary>
        /// Content is aligned horizontally on the right.
        /// </summary>
        Right
    }
}
