
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class DocumentFooterModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultData = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultMargin = 10f;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _margin;

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
            Margin = DefaultMargin;

        }
        #endregion

        #endregion

        #region public properties

        [XmlAttribute]
        [DefaultValue(DefaultData)]
        public string Data {get; set; }

        [XmlAttribute]
        [DefaultValue(DefaultMargin)]
        public float Margin
        {
            get => _margin;
            set
            {
                SentinelHelper.IsTrue(value < 0, "El margen no puede ser menor que cero");

                _margin = value;
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
        public override bool IsDefault => Data.Equals(DefaultData) && Margin.Equals(DefaultMargin);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="M:iTin.Export.Model.DocumentModel.ToString"/> returns a string that includes the size and orientation of document.
        /// </remarks>
        public override string ToString()
        {
            return $"Margin=\"{Margin}\"";
        }
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
