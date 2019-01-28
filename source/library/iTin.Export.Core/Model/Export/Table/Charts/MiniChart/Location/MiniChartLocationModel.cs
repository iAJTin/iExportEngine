
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class MiniChartLocationModel
    {
        public MiniChartLocationModel()
        {
            Mode = new ByColumnLocationModel();
        }

        public KnownMiniChartElementPosition LocationType
        {
            get
            {
                var positionTypeValue = Mode.GetType().Name;

                switch (positionTypeValue)
                {
                    case "ByColumnLocationModel":
                        return KnownMiniChartElementPosition.ByColumn;

                    case "ByRowLocationModel":
                        return KnownMiniChartElementPosition.ByRow;

                    case "CoordenatesModel":
                        return KnownMiniChartElementPosition.ByCoordenates;

                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsAbosulte
        {
            get
            {
                switch (LocationType)
                {
                    case KnownMiniChartElementPosition.ByColumn:
                    case KnownMiniChartElementPosition.ByRow:
                        return false;

                    case KnownMiniChartElementPosition.ByCoordenates:
                        return true;

                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        [XmlElement("ByColumn", typeof(ByColumnLocationModel))]
        [XmlElement("ByCoordenates", typeof(CoordenatesModel))]
        [XmlElement("ByRow", typeof(ByRowLocationModel))]
        [XmlElement("Relative", typeof(RelativeLocationModel))]
        public object Mode { get; set; }

        public override bool IsDefault => LocationType.Equals(KnownMiniChartElementPosition.ByColumn);
    }
}
