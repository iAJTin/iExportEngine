
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;

    /// <summary>
    /// Describes the position of labels on the axis.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.18034")]
    public enum KnownLabelPosition
    {
        /// <summary>
        /// No labels.
        /// </summary>
        None,

        /// <summary>
        /// Top or right side of the chart.
        /// </summary>
        High,

        /// <summary>
        /// Bottom or left side of the chart.
        /// </summary>
        Low,

        /// <summary>
        /// Next to axis.
        /// </summary>
        NextToAxis
    }
}
