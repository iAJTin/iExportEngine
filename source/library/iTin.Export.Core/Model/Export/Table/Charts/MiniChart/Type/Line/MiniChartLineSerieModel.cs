
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class MiniChartLineSerieModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultWidth = "0.75";
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartLineTypeModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _with;
        #endregion

        #region constructor/s

        #region [public] MiniChartLineSerieModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MiniChartLineSerieModel" /> class.
        /// </summary>
        public MiniChartLineSerieModel() => Width = DefaultWidth;
        #endregion

        #endregion

        #region public properties

        #region [public] (MiniChartLineTypeModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MiniChartLineTypeModel Parent => _parent;
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the chart or mini-chart
        [XmlAttribute]
        [DefaultValue(DefaultWidth)]
        public string Width
        {
            get => GetStaticBindingValue(_with);
            set => _with = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault && Width.Equals(DefaultWidth);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(MiniChartLineTypeModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MiniChartLineTypeModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
