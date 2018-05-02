
namespace iTin.Export.ComponentModel.Inputs
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Helpers;

    /// <summary>
    /// Defines a value that contains the metadata information of a <see cref="T:iTin.Export.ComponentModel.BaseInput" />.
    /// </summary>
    public struct InputOptionsMetadata : IEquatable<InputOptionsMetadata>
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly InputOptionsAttribute _optionsAttributeInformation;
        #endregion

        #region constructor/s

        #region [public] InputOptionsMetadata(BaseInput): Initializes a new instance of the struct
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.Inputs.InputOptionsMetadata"/> struct.
        /// </summary>
        /// <param name="input">The input.</param>
        public InputOptionsMetadata(BaseInput input)
        {
            SentinelHelper.ArgumentNull(input);

            var attributes = input.GetType().GetCustomAttributes(false);
            _optionsAttributeInformation = (InputOptionsAttribute)attributes.SingleOrDefault(attr => attr is InputOptionsAttribute);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (Type) AdapterType: Gets a value that contains which adapter will be used to export this input
        /// <summary>
        /// Gets a value that contains which adapter will be used to export this input.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that contains the adapter will be used to export this input.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.InputOptionsAttribute.AdapterName" /> property of the <see cref="T:iTin.Export.ComponentModel.InputOptionsAttribute" /> attribute.
        /// </remarks>
        public Type AdapterType => _optionsAttributeInformation.AdapterType;
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (bool) operator ==(InputOptionsMetadata, InputOptionsMetadata): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Left member</param>
        /// <param name="right">Right member</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool operator ==(InputOptionsMetadata left, InputOptionsMetadata right)
        {
            return left.Equals(right);
        }
        #endregion

        #region [public] {static} (bool) operator !=(InputOptionsMetadata, InputOptionsMetadata): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Left member</param>
        /// <param name="right">Right member</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="left"/> not is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool operator !=(InputOptionsMetadata left, InputOptionsMetadata right)
        {
            return !left.Equals(right);
        }
        #endregion

        #endregion

        #region public methdods

        #region [public] (bool) Equals(InputOptionsMetadata): Indicates whether the current object is equal to another object of the same type
        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">The object to compare with this object.</param>
        /// <returns>
        /// Returns <stromg>true</stromg> if the current object is equal to the parameter <paramref name="other" />; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(InputOptionsMetadata other)
        {
            return other.Equals((object)this);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (bool) Equals(object obj): Determines whether the specified object is equal to this instance
        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        /// <strong>true</strong> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <strong>false</strong>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is InputOptionsMetadata))
            {
                return false;
            }

            var other = (InputOptionsMetadata)obj;
            return other.GetHashCode() == GetHashCode();
        }
        #endregion

        #region [public] {override} (int) GetHashCode(): Returns a hash code for this instance
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Adapter=\"{AdapterType.Name}\"";
        }
        #endregion

        #endregion
    }
}
