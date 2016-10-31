using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;
using iTin.Export.Helper;

namespace iTin.Export.Model
{
    public partial class ReferencesModel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportsModel _parent;

        public ReferencesModel(ExportsModel parent) : base(parent)
        {
        }

        [Browsable(false)]
        public ExportsModel Parent
        {
            get { return _parent; }
        }

        internal void SetParent(ExportsModel reference)
        {
            _parent = reference;
        }

        protected override void SetOwner(ReferenceModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
    }
}
