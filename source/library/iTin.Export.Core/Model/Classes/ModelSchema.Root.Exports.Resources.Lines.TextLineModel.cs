using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    public partial class TextLineModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TextModel> _items;
        #endregion

        #region public properties

            #region [public] (List<TextModel>) Items: Gets or sets lines list.
            [XmlElement("Text")]
            public List<TextModel> Items
            {
                get
                {
                    if (_items == null)
                    {
                        _items = new List<TextModel>();
                    }

                    foreach (var item in _items)
                    {
                        item.SetOwner(this);
                    }

                    return _items;
                }
                set
                {
                    _items = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {override} (KnownLineType) LineType: Gets a value indicating line type.
            /// <summary>
            /// Gets a value indicating line type.
            /// </summary>
            /// <value>
            /// One of the <see cref="T:iTin.Export.Model.KnownLineType" /> values.
            /// </value>
            public override KnownLineType LineType
            {
                get { return KnownLineType.TextLine; }
            }
            #endregion

        #endregion
    }
}
