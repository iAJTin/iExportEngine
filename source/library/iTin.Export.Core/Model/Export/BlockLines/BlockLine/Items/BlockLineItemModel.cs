
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
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
