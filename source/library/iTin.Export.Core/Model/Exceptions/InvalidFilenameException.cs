using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// This class represents the exception that is thrown when the filename in export model is invalid.
    /// </summary>
    [Serializable]
    public class InvalidFileNameException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidFileNameException" /> class.
        /// </summary>
        public InvalidFileNameException()
            : base(string.Format(CultureInfo.CurrentCulture, Resources.ErrorMessage.InvalidIdentifierName))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidFileNameException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidFileNameException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidFileNameException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidFileNameException(StringBuilder message)
            : base(SentinelHelper.PassThroughNonNull(message).ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidFileNameException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<strong>Nothing</strong> in Visual Basic) if no inner exception is specified.</param>
        public InvalidFileNameException(string message, Exception innerException)
            : base(message, innerException)
          {
          }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidFileNameException" /> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected InvalidFileNameException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { 
        }
    }
}
