
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    public partial class ColumnHeaderGroup
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultCollapsed = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultLevel = 1;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _collapsed;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _level;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnHeaderModel _parent;
        #endregion

        #region constructor/s

        #region [public] ColumnHeaderModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ColumnHeaderGroup"/> class.
        /// </summary>
        public ColumnHeaderGroup()
        {
            Show = DefaultShow;
            Level = DefaultLevel;
            Collapsed = DefaultCollapsed;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Collpased: Gets or sets a value indicating whether group its show as collapsed.
        [XmlAttribute]
        [DefaultValue(DefaultCollapsed)]
        public YesNo Collapsed
        {
            get => GetStaticBindingValue(_collapsed.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _collapsed = value;
            }
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value indicating whether show column header
        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => GetStaticBindingValue(_show.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (int) Level: 
        [XmlAttribute]
        public int Level
        {
            get => _level;
            set => _level = value;
        }
        #endregion

        #region [public] (ColumnHeaderModel) Parent: Gets the element that parent this
        [XmlIgnore]
        [Browsable(false)]
        public ColumnHeaderModel Parent => _parent;
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
        public override bool IsDefault =>
            base.IsDefault &&
            Collapsed.Equals(DefaultCollapsed) &&
            Level.Equals(DefaultLevel) &&
            Show.Equals(DefaultShow);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetParent(ColumnHeaderModel): Sets the element that owns this
        public void SetParent(ColumnHeaderModel parent)
        {
            _parent = parent;
        }
        #endregion

        #endregion
    }
}
