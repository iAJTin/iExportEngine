
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;

    /// <summary>
    /// Specifies the known plot grid lines.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.17929")]
    public enum KnownPlotGridLine
    {
        /// <summary>
        /// Do not draw major and minor grid lines.
        /// </summary>
        None,

        /// <summary>
        /// Draws major and minor grid lines.
        /// </summary>
        Both,

        /// <summary>
        /// Draws major grid lines.
        /// </summary>
        Major,

        /// <summary>
        /// Draws minor grid lines.
        /// </summary>
        Minor
    }
}
