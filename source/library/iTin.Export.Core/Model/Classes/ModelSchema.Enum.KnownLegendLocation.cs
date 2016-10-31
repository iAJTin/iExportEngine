using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    /// <summary>
    ///  Specifies the known locations for legend.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.18033")]
    [XmlType(Namespace = "http://tempuri.org/NewModel.xsd")]
    public enum KnownLegendLocation
    {
        /// <summary>
        /// The top
        /// </summary>
        Top,

        /// <summary>
        /// The right
        /// </summary>
        Right,

        /// <summary>
        /// The bottom
        /// </summary>
        Bottom,

        /// <summary>
        /// The left
        /// </summary>
        Left
    }
}
