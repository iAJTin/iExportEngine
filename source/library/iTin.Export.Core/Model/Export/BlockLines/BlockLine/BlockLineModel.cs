
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Table/Class[@name='info']/*" />
    public partial class BlockLineModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel _location;
        #endregion

        public BlockLineModel()
        {
            Show = DefaultShow;
            Items = new BlockLineItemModel();
        }

        [XmlAttribute]
        public string Key { get; set; }

        public LocationModel Location
        {
            get => _location ?? (_location = new LocationModel());
            set => _location = value;
        }

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

        [XmlElement]
        public BlockLineItemModel Items { get; set; }

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Items.IsDefault &&
                                          Location.IsDefault &&
                                          Show.Equals(DefaultShow);
        #endregion

        #endregion
    }
}
