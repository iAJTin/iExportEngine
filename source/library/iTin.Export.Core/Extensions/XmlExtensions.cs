
namespace iTin.Export
{
    using System.Collections.Generic;
    using System.Xml.Linq;

    using Helpers;

    /// <summary>
    /// Static class than contains extension methods for <b>Xml</b> elements and attributes.
    /// </summary>
    public static class XmlExtensions
    {
        /// <summary>
        /// Gets attribute index into attributes array
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="attribute">The attribute.</param>
        /// <returns>
        /// System.Int32.
        /// </returns>
        public static int IndexOfAttribute(this IEnumerable<XAttribute> attributes, string attribute)
        {
            SentinelHelper.ArgumentNull(attributes);

            int i = 0;
            foreach (var attr in attributes)
            {
                if (attr.Name != attribute)
                {
                    i++;
                    continue;
                }

                break;
            }

            return i;
        }
    }
}
