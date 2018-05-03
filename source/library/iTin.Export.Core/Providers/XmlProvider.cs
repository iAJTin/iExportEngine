
namespace iTin.Export.Providers
{
    using System;
    using System.ComponentModel.Composition;
    using System.Diagnostics;

    using ComponentModel.Provider;
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.BaseAdapter" /> than represents a source object based on the <c>Xml</c>.
    /// </summary>
    [Export(typeof(IProvider))]
    [ProviderOptions(Name = "XmlProvider", Author = "iTin", Company = "iTin", Version = 1, Description = "Allow export inputs of type Xml")]
    public class XmlProvider : BaseProvider
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly char[] _monarchSpecialChars = { '#', '*', '@' };

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Providers.XmlProvider" /> class.
        /// </summary>
        /// <param name="constructorParams">The constructor parameters.</param>
        [ImportingConstructor]
        public XmlProvider(ProviderParameters constructorParams)
                 : this((Uri)SentinelHelper.PassThroughNonNull(constructorParams).Data)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Providers.XmlProvider" /> class.
        /// </summary>
        /// <param name="inputUri">Target uri</param>
        public XmlProvider(Uri inputUri)
        {
            InputUri = inputUri;
            SpecialChars = _monarchSpecialChars;
        }
    }
}
