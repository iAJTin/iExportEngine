
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Base class for the different types of lines supported by <strong><c>iTin Export Engine</c></strong>.<br/>
    /// Which acts as the base class for different types of lines.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows different types of lines.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.EmptyLineModel"/></term>
    ///       <description>Represents a data field.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.TextLineModel"/></term>
    ///       <description>Represents a piece of a field fixed-width data.</description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public abstract partial class BaseLineModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultRepeat = 0;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultStyle = "Default";
        
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LinesModel _owner;
        #endregion

        #region constructor/s

        #region [protected] BaseLineModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseLineModel" /> class.
        /// </summary>
        protected BaseLineModel()
        {
            Show = DefaultShow;
            Style = DefaultStyle;
            Repeat = DefaultRepeat;
        }
        #endregion

        #endregion

        #region public abstract properties

        #region [public] {override} (KnownLineType) LineType: Gets a value indicating line type
        /// <summary>
        /// Gets a value indicating line type.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownLineType" /> values.
        /// </value>
        public abstract KnownLineType LineType { get; }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Key: Gets or sets 
        [XmlAttribute]
        public string Key { get; set; }
        #endregion

        #region [public] (int) Repeat: Gets or sets 
        [XmlAttribute]
        [DefaultValue(DefaultRepeat)]
        public int Repeat { get; set; }
        #endregion

        #region [public] (LinesModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this data field.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.LinesModel" /> that owns this data field.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public LinesModel Owner
        {
            get { return _owner; }
        }
        #endregion

        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get
            {
                return _show;
            }
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }

        #region [public] (string) Style: Gets or sets one of the styles defined in the element styles
        [XmlAttribute]
        [DefaultValue(DefaultStyle)]
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
        public override bool IsDefault => Show.Equals(DefaultShow) &&
                                          Style.Equals(DefaultStyle) &&
                                          Repeat.Equals(DefaultRepeat);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(LinesModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this data field.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(LinesModel reference)
        {
            _owner = reference;
        }
        #endregion

        #region [public] (StyleModel) GetStyle(): Gets a reference to the style
        /// <summary>
        /// Gets a reference to the <see cref="T:iTin.Export.Model.StyleModel" /> from global resources.
        /// </summary>
        /// <returns>
        /// <strong>true</strong> if returns the style from resource; otherwise, <strong>false</strong>.
        /// </returns>
        public StyleModel GetStyle()
        {
            var hasStyle = TryGetStyle(out var tempStyle);

            return hasStyle ? tempStyle : StyleModel.Default;
        }
        #endregion

        #region [public] (bool) TryGetResourceInformation(out StyleModel): Gets a reference to the image resource information.
        /// <summary>
        /// Gets a reference to the image resource information.
        /// </summary>
        /// <param name="resource">Resource information.</param>
        /// <returns>
        /// <strong>true</strong> if exist available information about resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetResourceInformation(out StyleModel resource)
        {
            bool result;

            resource = StyleModel.Empty;
            if (string.IsNullOrEmpty(Style))
            {
                return false;
            }

            try
            {
                if (Style == "Default")
                {
                    resource = StyleModel.Default;
                }
                else
                {
                    var globalresources = _owner.Parent;
                    var export = globalresources.Parent;
                    resource = export.Resources.GetStyleResourceByName(Style);
                }

                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
        #endregion

        #region [public] (bool) TryGetStyle(out Style): Gets a reference to the style from resource.
        /// <summary>
        /// Gets a reference to the <see cref="T:iTin.Export.Model.StyleModel" /> from global resources.
        /// </summary>
        /// <param name="style">A <see cref="T:iTin.Export.Model.StyleModel" /> resource.</param>
        /// <returns>
        /// <strong>true</strong> if returns the style from resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetStyle(out StyleModel style)
        {
            style = StyleModel.Empty;

            var foudResource = TryGetResourceInformation(out var resource);
            if (!foudResource)
            {
                return true;
            }

            ////var logo = this.parent;
            ////var table = logo.Parent;
            ////var export = table.Parent;
            style = resource;

            return true;
        }
        #endregion

        #endregion                   

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object.
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="BaseLineModel.ToString()"/> returns a string that includes field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"Key=\"{Key}\"";
        }
        #endregion

        #endregion
    }
}
