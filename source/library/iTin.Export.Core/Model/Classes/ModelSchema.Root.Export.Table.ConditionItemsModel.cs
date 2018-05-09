
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Serialization;

    using ComponentModel;

    public partial class ConditionsItemModel
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly List<BaseConditionModel> _items;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> _keys;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableModel _parent;
        #endregion

        #region public constructor/s

        #region [public] ConditionsItemModel(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ConditionsItemModel"/> class.
        /// </summary>
        public ConditionsItemModel()
        {
            _items = new List<BaseConditionModel>();
        }
        #endregion

        #endregion

        #region internal properties

        #region [internal] (string[]) Keys: Gets or sets
        [XmlAttribute]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public List<string> Keys
        {
            get => _keys ?? (_keys = new List<string>());
            set => _keys = value;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (IEnumerable<BaseConditionModel>) Items: Gets or sets
        public IEnumerable<BaseConditionModel> Items
        {
            get
            {
                _items.Clear();

                var resourceConditions = ModelService.Instance.Resources.Conditions;
                var hasResourceConditions = resourceConditions.Any();
                if (!hasResourceConditions)
                {
                    return _items;
                }

                foreach (var key in Keys)
                {
                    var candidate = resourceConditions.GetBy(key);
                    if (candidate == null)
                    {
                        continue;
                    }

                    _items.Add(candidate);
                }

                return _items;
            }
        }
        #endregion

        #region [public] (TableModel) Parent: Gets the parent container of the exporter
        [XmlIgnore]
        [Browsable(false)]
        public TableModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault&quot;]/*" />
        public override bool IsDefault => Keys.Count == 0;
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
