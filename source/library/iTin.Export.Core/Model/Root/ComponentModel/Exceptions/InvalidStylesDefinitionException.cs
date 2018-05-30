
namespace iTin.Export.Model
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Text;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// This class represents the exception that is thrown when the style identifier in export model is invalid.
    /// </summary>
    [Serializable]
    public class InvalidStylesDefinitionException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidStylesDefinitionException" /> class.
        /// </summary>
        public InvalidStylesDefinitionException()
            : base(string.Format(CultureInfo.CurrentCulture, Resources.ErrorMessage.InvalidStyleDefinitionListText))
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidStylesDefinitionException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidStylesDefinitionException(string message)
            : base(message)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidStylesDefinitionException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidStylesDefinitionException(StringBuilder message)
            : base(SentinelHelper.PassThroughNonNull(SentinelHelper.PassThroughNonNull(message).ToString()))
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidStylesDefinitionException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<strong>Nothing</strong> in Visual Basic) if no inner exception is specified.</param>
        public InvalidStylesDefinitionException(string message, Exception innerException)
            : base(message, innerException)
          {
          }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.InvalidStylesDefinitionException" /> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected InvalidStylesDefinitionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { 
        }
    }
}
