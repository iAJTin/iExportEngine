
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;

    public partial class BaseMiniChartPointModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _color;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;
        #endregion

        #region constructor/s

        #region [protected] BaseMiniChartPointModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseMiniChartPointModel" /> class.
        /// </summary>
        protected BaseMiniChartPointModel() => Show = DefaultShow;
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Color: Gets or sets preferred serie color
        /// <summary>
        /// Gets or sets preferred serie color.
        /// </summary>
        /// <value>
        /// Preferred font color.
        /// </value>
        [XmlAttribute]
        public string Color
        {
            get => GetStaticBindingValue(_color);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _color = value;
            }
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays this point on  mini-chart
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

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance contains the default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => base.IsDefault &&
                                          Show.Equals(DefaultShow) &&
                                          string.IsNullOrEmpty(Color);
        #endregion

        #endregion

        #region public methods

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this mini-chart serie
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this mini-chart serie.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        /// </returns>
        public Color GetColor()
        {
            return ColorHelper.GetColorFromString(Color);
        }
        #endregion

        #endregion

        #region internal methods

        #endregion

    }
}
