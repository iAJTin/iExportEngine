using System;
using System.CodeDom.Compiler;

namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies trim mode for strings.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.18033")]
    public enum KnownTrimMode
    {
        /// <summary>
        /// Removes all blanks current <see cref="T:System.String"/>.
        /// </summary>
        All,

        /// <summary>
        /// Removes all white-space from the end of the current <see cref="T:System.String"/>.
        /// </summary>
        End,

        /// <summary>
        /// Removes all white-space from the beginning of the current <see cref="T:System.String"/>.
        /// </summary>
        Start
    }
}
