
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    using Helper;

    public partial class ReferencesModel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportsModel _parent;

        public ReferencesModel(ExportsModel parent) : base(parent)
        {
        }

        [Browsable(false)]
        public ExportsModel Parent => _parent;

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
