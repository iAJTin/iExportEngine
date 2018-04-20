
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    public partial class TextModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultMerge = 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextLineModel _owner;
        #endregion

        #region constructor/s

        #region [public] TextModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="TextModel" /> class.
        /// </summary>
        public TextModel()
        {
            Merge = DefaultMerge;
            Show = DefaultShow;
            //Style = "Default";
            Value = string.Empty;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int) Merge: Gets or sets
        [XmlAttribute]
        [DefaultValue(DefaultMerge)]
        public int Merge { get; set; }
        #endregion

        #region [public] (TextLineModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this data field.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.TextLineModel" /> that owns this data field.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public TextLineModel Owner => _owner;
        #endregion

        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => _show;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }

        #region [public] (string) Style: Gets or sets one of the styles defined in the element styles
        [XmlAttribute]
        //[DefaultValue("Default")]
        public string Style
        {
            get => _style;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Header", "Style", value)));

                _style = value;
            }
        }
        #endregion

        #region [public] (string) Value: Gets or sets
        [XmlText]
        public string Value { get; set; }
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
        public override bool IsDefault => Merge.Equals(DefaultMerge) &&
                                            Show.Equals(DefaultShow) &&
                                            string.IsNullOrEmpty(Value);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(TextLineModel): Sets a reference to the owner object that contains this instance
        /// <summary>
        /// Sets a reference to the owner object that contains this instance.
        /// </summary>
        /// <param name="reference">Owner reference.</param>
        public void SetOwner(TextLineModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
