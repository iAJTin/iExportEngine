using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Class[@name="info"]/*'/>
    public partial class BlockLineModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel location;
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
            get
            {
                return location ?? (location = new LocationModel());
            }
            set
            {
                location = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get
            {
                return show;
            }
            set
            {
                SentinelHelper.IsEnumValid(value);

                show = value;
            }
        }

        [XmlElement]
        public BlockLineItemModel Items { get; set; }

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default.
            /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
            public override bool IsDefault
            {
                get
                {
                    return
                        Items.IsDefault &&
                        Location.IsDefault &&
                        Show.Equals(DefaultShow);
                }
            }
            #endregion

        #endregion
    }
}
