using System;
using System.CodeDom.Compiler;

namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies the known aggregate types.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.17929")]
    public enum KnownAggregateType
    {
        /// <summary>
        /// None aggregate
        /// </summary>
        None,

        /// <summary>
        /// Average aggregate
        /// </summary>        
        Average,

        /// <summary>
        /// Count aggregate
        /// </summary>        
        Count,

        /// <summary>
        /// Max aggregate
        /// </summary>        
        Max,

        /// <summary>
        /// Min aggregate
        /// </summary>        
        Min,

        /// <summary>
        /// Sum aggregate
        /// </summary>
        Sum,

        /// <summary>
        /// Custom text
        /// </summary>
        Text
    }
}
