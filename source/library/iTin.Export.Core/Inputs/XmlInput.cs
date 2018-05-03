
namespace iTin.Export.Inputs
{
    using System;

    using ComponentModel.Input;
    using Providers;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Uri" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(XmlProvider))]
    public class XmlInput : BaseInput
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Inputs.XmlInput" /> class.
        /// </summary>
        /// <param name="xml">The XML.</param>
        public XmlInput(Uri xml)
            : base(xml)
        {
        }
    }
}
