using System;

using iTin.Export.Adapters.Native;
using iTin.Export.ComponentModel;

namespace iTin.Export.Inputs
{
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Uri" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(XmlAdapter))]
    public class XmlInput : BaseInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.XmlInput" /> class.
        /// </summary>
        /// <param name="xml">The XML.</param>
        public XmlInput(Uri xml)
            : base(xml)
        {
        }
    }
}
