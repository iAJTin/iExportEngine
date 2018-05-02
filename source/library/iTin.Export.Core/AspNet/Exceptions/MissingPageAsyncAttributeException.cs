
namespace iTin.Export.AspNet
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Web;
    using System.Web.UI;

    /// <summary>
    /// This class represents the exception that is thrown when the async attribute in a ASP page does not exist or is false.
    /// </summary>
    [Serializable]
    public class MissingPageAsyncAttributeException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Web.MissingPageAsyncAttributeException" /> class. Default is current ASP page.
        /// </summary>
        public MissingPageAsyncAttributeException()
            : base(string.Format(CultureInfo.CurrentCulture, Resources.ErrorMessage.MarkPageAsSync, GetPageNameFromContext()))
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Web.MissingPageAsyncAttributeException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<strong>Nothing</strong> in Visual Basic) if no inner exception is specified.</param>
        public MissingPageAsyncAttributeException(string message, Exception innerException)
            : base(message, innerException)
          {
          }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Web.MissingPageAsyncAttributeException" /> class.
        /// </summary>
        /// <param name="page">Page name.</param>
        public MissingPageAsyncAttributeException(string page) 
            : base(string.Format(CultureInfo.CurrentCulture, Resources.ErrorMessage.MarkPageAsSync, page))
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Web.MissingPageAsyncAttributeException" /> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected MissingPageAsyncAttributeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { 
        }

        /// <summary>
        /// Gets the name of the context page.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> than contains current ASP page name.
        /// </returns>
        private static string GetPageNameFromContext()
        {
            return ((Page)HttpContext.Current.CurrentHandler).AppRelativeVirtualPath;
        }
    }
}
