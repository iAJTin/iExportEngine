
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class DocumentFooterModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultData = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownHeaderFooterAlignment DefaultAlignment = KnownHeaderFooterAlignment.Center;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownHeaderFooterAlignment _alignment;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentModel _parent;
        #endregion

        #region constructor/s

        #region [public] ExportModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.DocumentFooterModel" /> class.
        /// </summary>
        public DocumentFooterModel()
        {
            Data = DefaultData;
            Alignment = DefaultAlignment;
        }
        #endregion

        #endregion

        #region public properties

        [XmlAttribute]
        [DefaultValue(DefaultData)]
        public string Data {get; set; }

        [XmlAttribute]
        [DefaultValue(DefaultAlignment)]
        public KnownHeaderFooterAlignment Alignment
        {
            get => _alignment;
            set
            {
                _alignment = value;
            }
        }

        #region [public] (DocumentModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public DocumentModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault =>
            base.IsDefault &&
            Data.Equals(DefaultData) &&
            Alignment.Equals(DefaultAlignment);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(DocumentModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(DocumentModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
