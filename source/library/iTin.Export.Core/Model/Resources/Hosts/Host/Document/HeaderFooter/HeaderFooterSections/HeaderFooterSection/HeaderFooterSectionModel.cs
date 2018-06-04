
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class HeaderFooterSectionModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownHeaderFooterSectionType DefaultType = KnownHeaderFooterSectionType.Odd;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultText = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownHeaderFooterAlignment DefaultAlignment = KnownHeaderFooterAlignment.Center;
        #endregion

        #region private members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HeaderFooterSectionsModel _owner;
        #endregion

        #region constructor/s

        #region [public] HeaderFooterSectionModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.HeaderFooterSectionModel"/> class.
        /// </summary>
        public HeaderFooterSectionModel()
        {
            Text = DefaultText;
            Type = DefaultType;
            Alignment = DefaultAlignment;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (HeaderFooterSectionsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.HeaderFooterSectionModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.HeaderFooterSectionsModel" /> that owns this <see cref="T:iTin.Export.Model.HeaderFooterSectionModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public HeaderFooterSectionsModel Owner => _owner;
        #endregion

        [XmlAttribute]
        [DefaultValue(DefaultText)]
        public string Text { get; set; }

        [XmlAttribute]
        [DefaultValue(DefaultType)]
        public KnownHeaderFooterSectionType Type { get; set; }

        [XmlAttribute]
        [DefaultValue(DefaultAlignment)]
        public KnownHeaderFooterAlignment Alignment { get; set; }

        #endregion

        #region public methods

        #region [public] (HeaderFooterSectionModel) Clone(): Clones this instance.
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public HeaderFooterSectionModel Clone()
        {
            return CopierHelper.DeepCopy(this);
        }
        #endregion

        #region [public] (void) SetOwner(HeaderFooterSectionsModel):
        /// <summary>
        /// </summary>
        /// <param name="reference"></param>
        public void SetOwner(HeaderFooterSectionsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion

        #endregion
    }
}


