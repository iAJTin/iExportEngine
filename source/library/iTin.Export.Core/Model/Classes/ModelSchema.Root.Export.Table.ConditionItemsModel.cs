
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class ConditionsItemModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableModel _parent;
        #endregion

        #region public properties

        #region [public] (string[]) Names: Gets or sets
        [XmlAttribute]
        public List<string> Names { get; set; }
        #endregion

        #region [public] (TableModel) Parent: Gets the parent container of the exporter
        [XmlIgnore]
        [Browsable(false)]
        public TableModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default

        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Names.Count == 0;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(TableModel): Sets the parent element of the element
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Internal/Methods/Method[@name="SetParent"]/*'/>
        internal void SetParent(TableModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
