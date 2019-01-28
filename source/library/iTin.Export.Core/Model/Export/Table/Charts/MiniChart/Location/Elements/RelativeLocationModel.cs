
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Xml.Serialization;

    using Helpers;

    public partial class RelativeLocationModel : ICloneable
    {
        #region private static readonly
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly int[] DefaultCoordenates = { 0, 0 };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int[] _coordenates;
        #endregion

        #region constructor/s

        #region [public] RelativeLocationModel(): Initializes a new instance of this class
        public RelativeLocationModel()
        {
            Coordenates = DefaultCoordenates;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int[]) Coordenates: Gets or sets an array of integers that represent the table location
        [XmlAttribute]
        [CLSCompliant(false)]
        [DefaultValue(new[] { 1, 1 })]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int[] Coordenates
        {
            get => _coordenates ?? (_coordenates = DefaultCoordenates);
            set
            {
                if (value != null)
                {
                    SentinelHelper.IsTrue(value.Length > 2, "Máximo 2 valores");
                    SentinelHelper.IsTrue(value[0] < 0, "La coordenada horizontal no puede ser menor que cero");
                    SentinelHelper.IsTrue(value[1] < 0, "La coordenada vertical no puede ser menor que cero");

                    _coordenates = value;
                }
            }
        }
        #endregion

        #region [public] (Point) TableCoordenates: Gets coordenates of table
        public Point TableCoordenates => new Point(Coordenates[0], Coordenates[1]);
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        [Browsable(false)]
        public override bool IsDefault => Coordenates.SequenceEqual(DefaultCoordenates);
        #endregion

        #endregion

        #region public methods

        #region [public] (CoordenatesModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public CoordenatesModel Clone()
        {
            var coordenatesCloned = (CoordenatesModel) MemberwiseClone();
            coordenatesCloned.Properties = Properties.Clone();

            return coordenatesCloned;
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
