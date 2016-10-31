using System;
using System.CodeDom.Compiler;

namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies the position of major and minor tick marks for an axis.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.17929")]
    public enum KnownTickMarkStyle
    {
        /// <summary>
        /// No mark.
        /// </summary>
        None,

        /// <summary>
        /// Crosses the axis.
        /// </summary>
        Cross,

        /// <summary>
        /// Inside the axis.
        /// </summary>
        Inside,

        /// <summary>
        /// Outside the axis.
        /// </summary>
        Outside
    }
}
