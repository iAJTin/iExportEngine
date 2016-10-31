using System;
using System.CodeDom.Compiler;

namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies known negative sign style
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.17929")]
    public enum KnownNegativeSign
    {
        /// <summary>
        /// -value
        /// </summary>
        Standard,

        /// <summary>
        /// value
        /// </summary>
        None,

        /// <summary>
        /// (value)
        /// </summary>
        Parenthesis,

        /// <summary>
        /// [value]
        /// </summary>
        Brackets
    }
}
