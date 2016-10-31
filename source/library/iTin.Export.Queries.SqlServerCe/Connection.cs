using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text;

using System.Data.SqlServerCe;

namespace iTin.Export.Queries.SqlServerCe
{
    /// <summary>
    /// Class that encapsulates a connection.
    /// </summary>
    public class Connection : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isOpen;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool disposed;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDbConnection connection;

        public string ConnectionString { get; set; }

        ///// <summary>
        ///// Gets or sets name of the data source to connect to.
        ///// </summary>
        ///// <value>
        ///// A <see cref="T:System.String" /> that contains name of the data source to connect to.
        ///// </value>
        //public string DataSource { get; set; }

        ///// <summary>
        ///// Gets or sets user Id for the connection.
        ///// </summary>
        ///// <value>
        ///// A <see cref="T:System.String" /> that contains user Id for the connection.
        ///// </value>
        //public string User { get; set; }

        ///// <summary>
        ///// Gets or sets password used to connect to the data source.
        ///// </summary>
        ///// <value>
        ///// A <see cref="T:System.String" /> that contains password used to connect to the data source.
        ///// </value>
        //public string Pwd { get; set; }

        ///// <summary>
        ///// Gets or sets a value which Indicates whether large data streams are compressed when going to and from the data source.
        ///// </summary>
        ///// <value>
        ///// <c>true</c> if large data streams are compressed; otherwise, <c>false</c>.
        ///// </value>
        //public bool DataCompression { get; set; }

        ///// <summary>
        ///// Gets or sets name of the schema used for unqualified <c>SQL</c> requests.
        ///// </summary>
        ///// <value>
        ///// A <see cref="T:System.String" /> that contains name of the schema used for unqualified <c>SQL</c> requests.
        ///// </value>
        //public string DefaultCollection { get; set; }

        /// <summary>
        /// Close the connection to the data source.
        /// </summary>
        public void Close()
        {
            Dispose();
        }

        /// <summary>
        /// Implement IDisposable. Clean managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            // Take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Opens a connection to the iSeries using the settings specified.
        /// </summary>
        /// <returns>
        /// An <see cref="T:IBM.Data.DB2.iSeries.iDB2Connection"/> object which contains a reference to the connection to an <c>IBM DB2</c> data source.
        /// </returns>
        public IDbConnection Open()
        {
            if (isOpen)
            {
                return connection;
            }

            try
            {
                var cnnStringBuilder = new StringBuilder();
                cnnStringBuilder.AppendFormat(CultureInfo.InvariantCulture, ConnectionString);

                connection = new SqlCeConnection(cnnStringBuilder.ToString());
                connection.Open();
                isOpen = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }

        /// <summary>
        /// Releasing managed and unmanaged resources.
        /// </summary>
        /// <param name="disposing">
        ///   <strong>true</strong> to release both managed and unmanaged resources; 
        ///   <strong>false</strong> to release only unmanaged resources.
        /// </param>
        /// <remarks>
        ///   <para>
        ///     If disposing equals <strong>true</strong>, the method has been called directly
        ///     or indirectly by a user's code. Managed and unmanaged resources
        ///     can be disposed.
        ///   </para>
        ///   <para>
        ///     If disposing equals <strong>false</strong>, the method has been called by the
        ///     runtime from inside the finalize and you should not reference
        ///     other objects. Only unmanaged resources can be disposed.
        ///   </para>
        /// </remarks>
        private void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (disposed)
            {
                return;
            }

            // If disposing equals true, dispose all managed and unmanaged resources.
            if (disposing)
            {
                // Dispose managed resources.
                if (connection != null)
                {
                    if (isOpen)
                    {
                        connection.Close();
                        isOpen = false;
                    }
                }
            }

            // Note disposing has been done.
            disposed = true;
        }
    }
}

//    /// <summary>
//    /// Logs the DB2 exception.
//    /// </summary>
//    /// <param name="ex">The exception.</param>
//    private static void LogDb2Exception(iDB2Exception ex)
//    {
//        var exceptionNumber = "Exception Number : " + ex.MessageCode + "(" + ex.MessageDetails + ") has occurred";
//        Console.WriteLine(exceptionNumber);
//        foreach (iDB2Error er in ex.Errors)
//        {
//            var message = "Message : " + er.Message + " Code : " + er.MessageCode + " State : " + er.SqlState;
//            Console.WriteLine(message);
//        }
//    }
//    #endregion
