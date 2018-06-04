
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class DocumentHeaderFooterModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HeaderFooterSectionsModel _sections;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentModel _parent;
        #endregion

        #region public properties

        #region [public] (HeaderFooterSectionsModel) Sections: Gets or sets a reference to 
        [XmlArrayItem("Section", typeof(HeaderFooterSectionModel), IsNullable = false)]
        public HeaderFooterSectionsModel Sections
        {
            get => _sections ?? (_sections = new HeaderFooterSectionsModel(this));
            set => _sections = value;
        }
        #endregion

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
            Sections.IsDefault;
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

