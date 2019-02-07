
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    public partial class ColumnHeaderModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultText = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultStyle = "Default";
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _from;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _to;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _text;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnHeaderGroup _group;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnHeadersModel _owner;
        #endregion

        #region constructor/s

        #region [public] ColumnHeaderModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ColumnHeaderModel"/> class.
        /// </summary>
        public ColumnHeaderModel()
        {
            Show = DefaultShow;
            Text = DefaultText;
            Style = DefaultStyle;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) From: Gets or sets begin column name
        [XmlAttribute]
        public string From
        {
            get => _from;
            set => _from = value;
        }
        #endregion

        #region [public] (string) To: Gets or sets end column name
        [XmlAttribute]
        public string To
        {
            get => _to;
            set => _to = value;
        }
        #endregion

        #region [public] (string) Style: Gets or sets style name
        [XmlAttribute]
        public string Style
        {
            get => _style;
            set => _style = value;
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value indicating whether show column header
        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => GetStaticBindingValue(_show.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (string) Text: Gets or sets text of column header
        [XmlAttribute]
        [DefaultValue(DefaultText)]
        public string Text
        {
            get => _text;
            set => _text = value;
        }
        #endregion

        #region [public] (ColumnHeaderGroup) Group: Gets the group header information
        [XmlElement]
        public ColumnHeaderGroup Group
        {
            get
            {
                if (_group != null)
                {
                    return _group;
                }

                _group = new ColumnHeaderGroup();
                _group.SetParent(this);

                return _group;
            }
            set => _group = value;
        }
        #endregion

        #region [public] (ColumnHeadersModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.ColumnHeaderModel"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ColumnHeadersModel"/> that owns this <see cref="T:iTin.Export.Model.ColumnHeaderModel"/>.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public ColumnHeadersModel Owner => _owner;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => Text.Equals(DefaultText) &&
                                          Show.Equals(DefaultShow) &&
                                          Style.Equals(DefaultStyle);
        #endregion

        #endregion

        #region public methods

        #region [public] (StyleModel) GetStyle(): Return the StyleModel for this column
        /// <summary>
        /// Return the <see cref="T:iTin.Export.Model.StyleModel"/> for this column.
        /// </summary>
        /// <returns>
        /// A <see cref="T:iTin.Export.Model.StyleModel"/> for this column.
        /// </returns>
        public StyleModel GetStyle()
        {
            var columns = Owner;
            var table = columns.Parent;
            var export = table.Parent;
            var exports = export.Owner;
            var resources = exports.Resources;
            var styles = resources.Styles;

            return styles[Style];
        }
        #endregion

        #region [public] (void) SetOwner(ColumnHeadersModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ColumnHeaderModel"/>.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(ColumnHeadersModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
