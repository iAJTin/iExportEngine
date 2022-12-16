
using System;

namespace iTin.Export.ComponentModel.Input
{
    /// <inheritdoc />
    /// <summary>
    /// Declares input attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class InputOptionsAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets a value that represents the adapter type
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Type"/> that contains the adapter's type.
        /// </value>
        public Type AdapterType { get; set; }
    }
}
