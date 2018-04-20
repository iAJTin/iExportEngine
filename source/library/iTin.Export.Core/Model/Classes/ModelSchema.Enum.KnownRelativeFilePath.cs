
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;

    /// <summary>
    /// Specifies the known relative item path.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.18034")]
    public enum KnownRelativeFilePath
    {
        /// <summary>
        /// Template file.
        /// </summary>
        Template,

        /// <summary>
        /// Transform file.
        /// </summary>
        Transform,

        /// <summary>
        /// Transform file behavior directory.
        /// </summary>
        TransformFileBehaviorDir,

        /// <summary>
        /// Writer Filter file.
        /// </summary>
        WriterFilter,

        /// <summary>
        /// Output file.
        /// </summary>
        Output,
    }
}
