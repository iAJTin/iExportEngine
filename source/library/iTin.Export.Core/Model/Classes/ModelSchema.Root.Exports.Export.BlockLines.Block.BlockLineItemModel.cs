using System.Collections.Generic;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    public partial class BlockLineItemModel
    {
        public BlockLineItemModel()
        {
            Keys = new List<string>();
        }

        [XmlAttribute]
        public List<string> Keys { get; set; }
    }
}
