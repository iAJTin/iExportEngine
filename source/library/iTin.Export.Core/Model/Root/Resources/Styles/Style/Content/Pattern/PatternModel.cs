
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;

    /// <summary>
    /// </summary>
    public partial class PatternModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultColor = "Transparent";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownPatternType DefaultPatternType = KnownPatternType.Solid;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownPatternType _type;
        #endregion

        #region constructor/s

        #region [public] PatternModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.PatternModel"/> class.
        /// </summary>
        public PatternModel()
        {
            Color = DefaultColor;
            PatternType = DefaultPatternType;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Color: Gets or sets preferred of content color
        [XmlAttribute]
        [DefaultValue(DefaultColor)]
        public string Color { get; set; }
        #endregion

        #region [public] (KnownPatternType) PatternType: Gets or sets pattern type
        [XmlAttribute]
        [DefaultValue(DefaultPatternType)]
        public KnownPatternType PatternType
        {
            get => _type;
            set
            {
                SentinelHelper.IsEnumValid(value);
                _type = value;
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
        public override bool IsDefault => Color.Equals(DefaultColor) && PatternType.Equals(DefaultPatternType);
        #endregion

        #endregion

        #region public methods

        #region [public] (PatternModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public PatternModel Clone()
        {
            var patternCloned = (PatternModel)MemberwiseClone();
            patternCloned.Properties = Properties.Clone();

            return patternCloned;
        }
        #endregion

        #region [public] (void) Combine(PatternModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(PatternModel reference)
        {
            if (Color.Equals(DefaultColor))
            {
                Color = reference.Color;
            }

            if (PatternType.Equals(DefaultPatternType))
            {
                PatternType = reference.PatternType;
            }
        }
        #endregion

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this pattern
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this content.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        /// </returns> 
        public Color GetColor()
        {
            return ColorHelper.GetColorFromString(Color);
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
