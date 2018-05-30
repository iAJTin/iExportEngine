
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Specifies the known writer search criteria.
    /// </summary>
    [Flags]
    [SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    public enum KnownWriterFilter
    {
        /// <summary>
        /// The name
        /// </summary>
        Name = 0,

        /// <summary>
        /// The author
        /// </summary>
        Author = 1,

        /// <summary>
        /// The version
        /// </summary>
        Version = 2,

        /// <summary>
        /// The company
        /// </summary>
        Company = 4
    }
}
