
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;

    /// <summary>
    /// Specifies the known mini-chart types.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.17929")]
    public enum KnownMiniChartType
    {
        /// <summary>
        /// Column mini-chart type
        /// </summary>
        Column,

        /// <summary>
        /// Line mini-chart type
        /// </summary>        
        Line,

        /// <summary>
        /// Win-Loss mini-chart type
        /// </summary>        
        WinLoss
    }
}
