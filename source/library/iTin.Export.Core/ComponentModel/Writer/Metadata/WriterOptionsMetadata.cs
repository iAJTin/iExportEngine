
using System;
using System.Diagnostics;
using System.Linq;

namespace iTin.Export.ComponentModel.Writer
{
    /// <summary>
    /// Defines a value that contains the detailed information of a <see cref="T:iTin.Export.ComponentModel.Writer.IWriter" />.
    /// </summary>
    public struct WriterOptionsMetadata : IWriterOptions, IEquatable<WriterOptionsMetadata>
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WriterOptionsAttribute _optionsAttributeInformation;
        #endregion

        #region constructor/s

        #region [public] WriterOptionsMetadata(IWriter): Initializes a new instance of the struct
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsMetadata"/> struct.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public WriterOptionsMetadata(IWriter writer)
        {
            var attributes = writer.GetType().GetCustomAttributes(false);
            _optionsAttributeInformation = (WriterOptionsAttribute)attributes.SingleOrDefault(attr => attr is WriterOptionsAttribute);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Author: Gets a value than identify to creator of writer
        /// <summary>
        /// Gets a value than identify to creator of writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> than contains the writer's author.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute.Author" /> property of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute" /> attribute.
        /// </remarks>
        public string Author => _optionsAttributeInformation.Author;
        #endregion

        #region [public] (string) Company: Gets a value than represents the name of the company that created the writer
        /// <summary>
        /// Gets a value than represents the name of the company that created the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> than contains the writer company's
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute.Company" /> property of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute" /> attribute.
        /// </remarks>
        public string Company => _optionsAttributeInformation.Company;
        #endregion

        #region [public] (string) Description: Gets a value than represents the description of the writer
        /// <summary>
        /// Gets a value than represents the description of the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> than contains the writer's description.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute.Description" /> property of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute" /> attribute.
        /// </remarks>
        public string Description => _optionsAttributeInformation.Description;
        #endregion

        #region [public] (string) Extension: Gets a value than represents extension output file created by writer
        /// <summary>
        /// Gets a value than represents extension output file created by writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the writer's output file extension without dot.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute.Extension" /> property of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute" /> attribute.
        /// </remarks>
        public string Extension => _optionsAttributeInformation.Extension.Replace(".", string.Empty);
        #endregion

        #region [public] (string) Name: Gets a value that represents the name of the company that created the writer
        /// <summary>
        /// Gets a value than represents the name of the company that created the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> than contains the writer's name.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute.Name" /> property of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute" /> attribute.
        /// </remarks>
        public string Name => _optionsAttributeInformation.Name;
        #endregion

        #region [public] (int) Version: Gets a value than represents the version of the writer
        /// <summary>
        /// Gets a value than represents the version of the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32"/> than contains the writer's version.
        /// </value>
        /// <remarks>
        /// This value is recovered using reflection the <see cref="P:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute.Version" /> property of the <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsAttribute" /> attribute.
        /// </remarks>
        public int Version => _optionsAttributeInformation.Version;
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (bool) operator ==(WriterOptionsMetadata, WriterOptionsMetadata): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Left member</param>
        /// <param name="right">Right member</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool operator ==(WriterOptionsMetadata left, WriterOptionsMetadata right)
        {
            return left.Equals(right);
        }
        #endregion

        #region [public] {static} (bool) operator !=(WriterOptionsMetadata, WriterOptionsMetadata): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Left member</param>
        /// <param name="right">Right member</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="left"/> not is equal to <paramref name="right"/>; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool operator !=(WriterOptionsMetadata left, WriterOptionsMetadata right)
        {
            return !left.Equals(right);
        }
        #endregion

        #endregion

        #region public methdods

        #region [public] (bool) Equals(WriterOptionsMetadata): Indicates whether the current object is equal to another object of the same type
        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">The object to compare with this object.</param>
        /// <returns>
        /// Returns <stromg>true</stromg> if the current object is equal to the parameter <paramref name="other" />; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(WriterOptionsMetadata other)
        {
            return other.Equals((object)this);
        }
        #endregion

        #endregion

        #region public override methods

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object" /> to compare with this instance.</param>
        /// <returns>
        /// <strong>true</strong> if the specified <see cref="T:System.Object" /> is equal to this instance; otherwise, <strong>false</strong>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is WriterOptionsMetadata))
            {
                return false;
            }

            var other = (WriterOptionsMetadata)obj;

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
        public override string ToString() => $"Name=\"{Name}\", Author=\"{Author}\", Company=\"{Company}\", Version={Version}";

        #endregion
    }
}
