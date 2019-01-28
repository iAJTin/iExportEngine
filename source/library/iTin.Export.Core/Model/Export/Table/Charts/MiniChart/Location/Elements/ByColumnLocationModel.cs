
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class ByColumnLocationModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultOffset = 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownMiniChartLocation DefaultLocation = KnownMiniChartLocation.Bottom;
        #endregion

        #region private field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _offset;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownMiniChartLocation _location;
        #endregion

        #region constructor/s

        #region [public] ByColumnLocationModel(): Initializes a new instance of this class
        public ByColumnLocationModel()
        {
            Offset = DefaultOffset;
            Location = DefaultLocation;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownMiniChartLocation) Location: Gets or sets preferred location in which to add the minichart
        [XmlAttribute]
        [DefaultValue(DefaultLocation)]
        public KnownMiniChartLocation Location
        {
            get => _location;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _location = value;
            }
        }
        #endregion

        #region [public] (int) Offset: Gets or sets preferred location in which to add the minichart
        [XmlAttribute]
        [DefaultValue(DefaultOffset)]
        public int Offset
        {
            get => _offset;
            set
            {
                _offset = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => Offset.Equals(DefaultOffset) &&
                                          Location.Equals(DefaultLocation);
        #endregion

        #endregion

        #region public methods

        #region [public] (ByRowLocationModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public ByColumnLocationModel Clone()
        {
            var clonned = (ByColumnLocationModel) MemberwiseClone();
            clonned.Properties = Properties.Clone();

            return clonned;
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
