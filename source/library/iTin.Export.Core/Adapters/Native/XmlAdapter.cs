using System;
using System.ComponentModel.Composition;
using System.Diagnostics;

using iTin.Export.ComponentModel;
using iTin.Export.Helper;

namespace iTin.Export.Adapters.Native
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.BaseAdapter" /> than represents a source object based on the <c>XML</c>.
    /// </summary>
    [Export(typeof(IAdapter))]
    [AdapterOptions(Name = "XmlAdapter", Author = "iTin", Company = "iTin", Version = 1, Description = "Allow export inputs of type XML")]
    public class XmlAdapter : BaseAdapter
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly char[] _monarchSpecialChars = { '#', '*', '@' };

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Targets.XmlTarget" /> class.
        /// </summary>
        /// <param name="constructorParams">The constructor parameters.</param>
        [ImportingConstructor]
        public XmlAdapter(AdapterParameters constructorParams)
                 : this((Uri)SentinelHelper.PassThroughNonNull(constructorParams).Data)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Targets.XmlTarget" /> class.
        /// </summary>
        /// <param name="inputUri">Target uri</param>
        public XmlAdapter(Uri inputUri)
        {
            InputUri = inputUri;
            SpecialChars = _monarchSpecialChars;
        }
    }
}
