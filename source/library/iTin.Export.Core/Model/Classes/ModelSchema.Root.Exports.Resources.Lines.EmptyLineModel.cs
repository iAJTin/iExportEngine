using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    public partial class EmptyLineModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultMerge = 0;
        #endregion

        #region constructor/s

            #region [public] EmptyLineModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="EmptyLineModel" /> class.
            /// </summary>
            public EmptyLineModel()
            {
                Merge = DefaultMerge;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (int) Merge: Gets or sets
            [XmlAttribute]
            [DefaultValue(DefaultMerge)]
            public int Merge { get; set; }
            #endregion

        #endregion

        #region public override properties

            public override KnownLineType LineType
            {
                get { return KnownLineType.EmptyLine; }
            }

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return Merge.Equals(DefaultMerge);
                }
            }
            #endregion

        #endregion
    }
}
