
using System;
using System.Diagnostics;
using System.Linq;

namespace iTin.Export.ComponentModel.Provider
{
    /// <summary>
    /// Defines a value that contains the detailed information of a <see cref="T:iTin.Export.ComponentModel.Provider.IProvider" />.
    /// </summary>
    public struct ProviderOptionsMetadata : IProviderOptions, IEquatable<ProviderOptionsMetadata>
    {
        #region private readonly members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ProviderOptionsAttribute _optionsAttributeInformation;

        #endregion

        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsMetadata"/> struct.
        /// </summary>
        /// <param name="provider">The target.</param>
        public ProviderOptionsMetadata(IProvider provider)
        {
            var attributes = provider.GetType().GetCustomAttributes(false);
            _optionsAttributeInformation = (ProviderOptionsAttribute)attributes.SingleOrDefault(attr => attr is ProviderOptionsAttribute);
        }

        #endregion

        #region public properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than identify to creator of this provider
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's author.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute.Author" /> property of the <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute" /> attribute.
        /// </remarks>
        public string Author => _optionsAttributeInformation.Author;

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than represents the name of the company that created of this provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's company
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute.Company" /> property of the <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute" /> attribute.
        /// </remarks>
        public string Company => _optionsAttributeInformation.Company;

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than represents the description of this provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's description.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute.Description" /> property of the <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute" /> attribute.
        /// </remarks>
        public string Description => _optionsAttributeInformation.Description;

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than represents the name of the company that created the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's company name.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute.Name" /> property of the <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute" /> attribute.
        /// </remarks>
        public string Name => _optionsAttributeInformation.Name;

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than represents the version of this provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> than contains the provider's version.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute.Version" /> property of the <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsAttribute" /> attribute.
        /// </remarks>
        public int Version => _optionsAttributeInformation.Version;

        #endregion

        #region public static methods

        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Left member</param>
        /// <param name="right">Right member</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool operator ==(ProviderOptionsMetadata left, ProviderOptionsMetadata right) => left.Equals(right);

        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Left member</param>
        /// <param name="right">Right member</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="left"/> not is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool operator !=(ProviderOptionsMetadata left, ProviderOptionsMetadata right) => !left.Equals(right);

        #endregion

        #region public methdods

        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">The object to compare with this object.</param>
        /// <returns>
        /// Returns <stromg>true</stromg> if the current object is equal to the parameter <paramref name="other" />; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(ProviderOptionsMetadata other) => other.Equals((object)this);

        #endregion

        #region public override methods

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        /// <strong>true</strong> if the specified <see cref="T:System.Object" /> is equal to this instance; otherwise, <strong>false</strong>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is ProviderOptionsMetadata))
            {
                return false;
            }

            var other = (ProviderOptionsMetadata)obj;
            return other.GetHashCode() == GetHashCode();
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"Name=\"{Name}\", Author=\"{Author}\", Version={Version}, Company=\"{Company}\"";

        #endregion
    }
}
