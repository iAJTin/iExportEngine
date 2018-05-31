
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable]
    //[DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlInclude(typeof(FixedFieldModel))]
    [XmlInclude(typeof(GapFieldModel))]
    [XmlInclude(typeof(DataFieldModel))]
    [XmlInclude(typeof(GroupFieldModel))]
    [XmlInclude(typeof(PacketFieldModel))]
    [GeneratedCode("System.Xml", "4.0.30319.18033")]
    [XmlType(Namespace = "http://schemas.itin.com/export/engine/2014/configuration/v1.0")]
    public abstract partial class BaseDataFieldModel : BaseModel<BaseDataFieldModel>
    {
    }
}
