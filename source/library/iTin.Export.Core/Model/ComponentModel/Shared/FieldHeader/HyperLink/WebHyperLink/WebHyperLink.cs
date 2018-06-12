
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class WebHyperLink
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultAddress = "";
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _address;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldHeaderHyperLink _parent;
        #endregion

        #region constructor/s

        #region [public] WebHyperLink(): Initializes a new instance of this class
        public WebHyperLink()
        {
            Address = DefaultAddress;
        }
        #endregion

        #endregion

        #region public properties

        [XmlAttribute]
        [DefaultValue(DefaultAddress)]
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        #region [public] (FieldHeaderHyperLink) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public FieldHeaderHyperLink Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        [Browsable(false)]
        public override bool IsDefault => base.IsDefault && Address.Equals(DefaultAddress);

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(FieldHeaderHyperLink): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(FieldHeaderHyperLink reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
