
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// </summary>
    public partial class DocumentMetadataModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentModel _parent;
        #endregion

        #region public properties

        [XmlElement]
        public string Title { get; set; }

        [XmlElement]
        public string Subject { get; set; }

        [XmlElement]
        public string Author { get; set; }

        [XmlElement]
        public string Manager { get; set; }

        [XmlElement]
        public string Company { get; set; }

        [XmlElement]
        public string Category { get; set; }

        [XmlElement]
        public string Keywords { get; set; }

        [XmlElement]
        public string Comments { get; set; }

        [XmlElement]
        public string Url { get; set; }

        [XmlIgnore]
        [Browsable(false)]
        public DocumentModel Parent => _parent;

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault =>
            base.IsDefault &&
            string.IsNullOrEmpty(Title) &&
            string.IsNullOrEmpty(Subject) &&
            string.IsNullOrEmpty(Author) &&
            string.IsNullOrEmpty(Manager) &&
            string.IsNullOrEmpty(Company) &&
            string.IsNullOrEmpty(Category) &&
            string.IsNullOrEmpty(Keywords) &&
            string.IsNullOrEmpty(Comments) &&
            string.IsNullOrEmpty(Url);
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
