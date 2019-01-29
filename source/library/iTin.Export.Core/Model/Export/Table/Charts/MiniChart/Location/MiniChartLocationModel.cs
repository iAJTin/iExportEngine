
namespace iTin.Export.Model
{
    using System;
    using System.Xml.Serialization;

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
        public object Mode { get; set; }

        public override bool IsDefault => LocationType.Equals(KnownMiniChartElementPosition.ByColumn);
    }
}
