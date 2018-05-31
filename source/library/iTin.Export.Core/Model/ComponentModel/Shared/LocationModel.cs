
namespace iTin.Export.Model
{
    using System;
    using System.Xml.Serialization;

    /// <inheritdoc />
    /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Location/Class[@name='Location']/*" />
    public partial class LocationModel
    {
        #region constructor/s

        #region [public] LocationModel(): Initializes a new instance of this class
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Location/Public/Constructors/Constructor[@name="ctor1"]/*'/>
        public LocationModel()
        {
            Mode = new CoordenatesModel();
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownElementLocation) LocationType: Gets a value indicating table position type
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Location/Public/Properties/Property[@name="LocationType"]/*'/>
        public KnownElementLocation LocationType
        {
            get
            {
                var positionTypeValue = Mode.GetType().Name;

                switch (positionTypeValue)
                {
                    case "AlignmentModel":
                        return KnownElementLocation.ByAlignment;

                    case "CoordenatesModel":
                        return KnownElementLocation.ByCoordenates;

                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        #endregion

        #region [public] (object) Mode: Gets or sets a reference to the location mode used in the host
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Location/Public/Properties/Property[@name="Mode"]/*'/>
        [XmlElement("ByAlignment", typeof(AlignmentModel))]
        [XmlElement("ByCoordenates", typeof(CoordenatesModel))]
        public object Mode { get; set; }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*' />
        public override bool IsDefault => LocationType.Equals(KnownElementLocation.ByCoordenates);
        #endregion

        #endregion     
    }
}
