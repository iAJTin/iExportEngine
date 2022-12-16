
using System.Collections.Generic;

namespace iTin.Export.ComponentModel.Writer
{
    /// <summary>
    /// Represents <see cref="T:iTin.Export.ComponentModel.Writer.WritersCache" /> settings.
    /// </summary>
    internal sealed class WritersCacheSettings
    {
        /// <summary>
        /// Gets the container's path.
        /// </summary>
        /// <value>
        /// A enumerable of strings than contains the containers' paths.
        /// </value>
        public IEnumerable<string> Items { get; internal set; }
    }
}
