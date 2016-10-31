using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Defines a value that contains the detailed information of a <see cref="T:iTin.Export.ComponentModel.IAdapter" />.
    /// </summary>
    public struct AdapterExtendedInformation : IAdapterOptions, IEquatable<AdapterExtendedInformation>
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly AdapterOptionsAttribute _detailedInformation;
        #endregion

        #region constructor/s

            #region [public] TargetExtendedInformation(ITarget): Initializes a new instance of the struct.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.TargetExtendedInformation"/> struct.
            /// </summary>
            /// <param name="adapter">The target.</param>
            public AdapterExtendedInformation(IAdapter adapter)
            {
                var attributes = adapter.GetType().GetCustomAttributes(false);
                _detailedInformation = (AdapterOptionsAttribute)attributes.SingleOrDefault(attr => attr is AdapterOptionsAttribute);
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (string) Author: Gets a value than identify to creator of target.
            /// <summary>
            /// Gets a value than identify to creator of target.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String"/> than contains the target's author.
            /// </value>
            /// <remarks>
            /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.TargetOptionsAttribute.Author" /> property of the <see cref="T:iTin.Export.ComponentModel.TargetOptionsAttribute" /> attribute.
            /// </remarks>
            public string Author
            {
                get { return _detailedInformation.Author; }
            }
            #endregion

            #region [public] (string) Company: Gets a value than represents the name of the company that created the target.
            /// <summary>
            /// Gets a value than represents the name of the company that created the target.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String"/> than contains the target company's
            /// </value>
            /// <remarks>
            /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.TargetOptionsAttribute.Company" /> property of the <see cref="T:iTin.Export.ComponentModel.TargetOptionsAttribute" /> attribute.
            /// </remarks>
            public string Company
            {
                get { return _detailedInformation.Company; }
            }
            #endregion

            #region [public] (string) Description: Gets a value than represents the description of the target.
            /// <summary>
            /// Gets a value than represents the description of the target.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String"/> than contains the target's description.
            /// </value>
            /// <remarks>
            /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.TargetOptionsAttribute.Description" /> property of the <see cref="T:iTin.Export.ComponentModel.TargetOptionsAttribute" /> attribute.
            /// </remarks>
            public string Description
            {
                get { return _detailedInformation.Description; }
            }
            #endregion

            #region [public] (string) Name: Gets a value that represents the name of the company that created the target.
            /// <summary>
            /// Gets a value than represents the name of the company that created the target.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String"/> than contains the target's name.
            /// </value>
            /// <remarks>
            /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.TargetOptionsAttribute.Name" /> property of the <see cref="T:iTin.Export.ComponentModel.TargetOptionsAttribute" /> attribute.
            /// </remarks>
            public string Name
            {
                get { return _detailedInformation.Name; }
            }
            #endregion

            #region [public] (int) Version: Gets a value than represents the version of the target.
            /// <summary>
            /// Gets a value than represents the version of the target.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.Int32"/> than contains the target's version.
            /// </value>
            /// <remarks>
            /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.TargetOptionsAttribute.Version" /> property of the <see cref="T:iTin.Export.ComponentModel.TargetOptionsAttribute" /> attribute.
            /// </remarks>
            public int Version
            {
                get { return _detailedInformation.Version; }
            }
            #endregion

        #endregion

        #region public static methods

            #region [public] {static} (bool) operator ==(TargetExtendedInformation, TargetExtendedInformation): Implements the equality operator (==).
            /// <summary>
            /// Implements the equality operator (==).
            /// </summary>
            /// <param name="left">Left member</param>
            /// <param name="right">Right member</param>
            /// <returns>
            /// <strong>true</strong> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
            /// </returns>
            public static bool operator ==(AdapterExtendedInformation left, AdapterExtendedInformation right)
            {
                return left.Equals(right);
            }
            #endregion

            #region [public] {static} (bool) operator !=(TargetExtendedInformation, TargetExtendedInformation): Implements the inequality operator (!=).
            /// <summary>
            /// Implements the inequality operator (!=).
            /// </summary>
            /// <param name="left">Left member</param>
            /// <param name="right">Right member</param>
            /// <returns>
            /// <strong>true</strong> if <paramref name="left"/> not is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
            /// </returns>
            public static bool operator !=(AdapterExtendedInformation left, AdapterExtendedInformation right)
            {
                return !left.Equals(right);
            }
            #endregion

        #endregion

        #region public methdods

            #region [public] (bool) Equals(TargetExtendedInformation): Indicates whether the current object is equal to another object of the same type.
            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">The object to compare with this object.</param>
            /// <returns>
            /// Returns <stromg>true</stromg> if the current object is equal to the parameter <paramref name="other" />; otherwise, <strong>false</strong>.
            /// </returns>
            public bool Equals(AdapterExtendedInformation other)
            {
                return other.Equals((object)this);
            }
            #endregion

        #endregion

        #region public override methods

            #region [public] {override} (bool) Equals(object obj): Determines whether the specified object is equal to this instance.
            /// <summary>
            /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
            /// <returns>
            /// <strong>true</strong> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <strong>false</strong>.
            /// </returns>
            public override bool Equals(object obj)
            {
                if (!(obj is AdapterExtendedInformation))
                {
                    return false;
                }

                var other = (AdapterExtendedInformation)obj;
                return other.GetHashCode() == GetHashCode();
            }
            #endregion

            #region [public] {override} (int) GetHashCode(): Returns a hash code for this instance.
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

            #region [public] {override} (string) ToString(): Returns a string that represents the current object.
            /// <summary>
            /// Returns a <see cref="System.String" /> that represents this instance.
            /// </summary>
            /// <returns>
            /// A <see cref="System.String" /> that represents this instance.
            /// </returns>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Name=\"{0}\", Author=\"{1}\", Version={2}, Company=\"{3}\"", Name, Author, Version, Company);
            }
            #endregion

        #endregion
    }
}
