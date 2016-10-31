using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace iTin.Export.Queries.SqlServerCe
{
    /// <summary>
    /// Class that defines a query. This class checks for <c>SQL</c> injection.
    /// </summary>
    public class Query
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private string text;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ASNA.Export.Queries.iSeries.Query" /> class.
        /// </summary>
        /// <param name="connection"><see cref="T:ASNA.Export.Queries.iSeries.Connection" /> to use.</param>
        public Query(Connection connection)
        {
            text = string.Empty;
            Connection = connection;
        }

        /// <summary>
        /// Gets a reference to connection to use.
        /// </summary>
        /// <value>
        /// <see cref="T:ASNA.Export.Queries.iSeries.Connection" /> containing reference to the connection to use.
        /// </value>
        public Connection Connection { get; private set; }

        /// <summary>
        /// Gets or sets query string to execute.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> containing the text of the query to be run on the active <see cref="T:ASNA.Export.Queries.iSeries.Connection" />.
        /// </value>
        /// <remarks>
        /// The instructions <c>ALTER</c>, <c>DELETE</c>, <c>INSERT</c>, <c>UPDATE</c> and <c>DROP</c> not are supported.
        /// </remarks>
        /// <exception cref="System.NotSupportedException">
        /// SQL ALTER instruction not is supported
        /// or
        /// SQL DELETE instruction not is supported
        /// or
        /// SQL DROP instruction not is supported
        /// or
        /// SQL INSERT instruction not is supported
        /// or
        /// SQL UPDATE instruction not is supported
        /// </exception>
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                SentinelHelper.IsTrue(value.Contains("ALTER"), new NotSupportedException("SQL ALTER instruction not is supported"));
                SentinelHelper.IsTrue(value.Contains("DELETE"), new NotSupportedException("SQL DELETE instruction not is supported"));
                SentinelHelper.IsTrue(value.Contains("DROP"), new NotSupportedException("SQL DROP instruction not is supported"));
                SentinelHelper.IsTrue(value.Contains("INSERT"), new NotSupportedException("SQL INSERT instruction not is supported"));
                SentinelHelper.IsTrue(value.Contains("UPDATE"), new NotSupportedException("SQL UPDATE instruction not is supported"));
                SentinelHelper.IsTrue(HasSqlInjection(value), new NotSupportedException("SQL injection not is supported"));

                text = value.ToUpperInvariant();
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.Data.DataSet" /> object created by <see cref="Query.Execute(string)" /> or <see cref="Query.Execute(string, object)" /> method.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Data.DataSet" /> object which was created by <see cref="Query.Execute(string)" /> or <see cref="Query.Execute(string, object)" /> method.
        /// </value>
        protected DataSet DataSet { get; private set; }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains name of table created by <see cref="Query.Execute(string)" /> or <see cref="Query.Execute(string, object)" /> method.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> containing name of table with results of query.
        /// </value>
        protected string TableName { get; private set; }

        /// <summary>
        /// Executes the query in the active connection.
        /// </summary>
        /// <param name="outTableName">Name of generated table.</param>
        /// <returns>
        /// <see cref="T:System.Data.DataSet" /> containing results of query.
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Revisar consultas SQL para comprobar si tienen vulnerabilidades de seguridad")]
        public DataSet Execute(string outTableName)
        {
            var ds = new DataSet();

            try
            {
                using (var cn = Connection)
                {
                    var db2Conn = (SqlCeConnection) cn.Open();

                    var cmd = new SqlCeCommand
                    {
                        Connection = db2Conn,
                        CommandText = Text
                    };

                    using (var da = new SqlCeDataAdapter(cmd.CommandText, db2Conn))
                    {
                        da.Fill(ds);
                        ds.Tables[0].TableName = outTableName;

                        DataSet = ds;
                        TableName = outTableName;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

            return ApplyBusinessLogic();
        }

        /// <summary>
        /// Executes the query in the active connection.
        /// </summary>
        /// <param name="outTableName">Name of generated table.</param>
        /// <param name="businessInfo">The business information.</param>
        /// <returns>
        /// A <see cref="T:System.Data.DataSet" /> containing results of query.
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Revisar consultas SQL para comprobar si tienen vulnerabilidades de seguridad")]
        public DataSet Execute(string outTableName, object businessInfo)
        {
            var ds = new DataSet();

            try
            {
                using (var cnn = (SqlCeConnection) Connection.Open())
                {
                    var cmd = new SqlCeCommand
                    {
                        Connection = cnn,
                        CommandText = Text
                    };

                    using (var da = new SqlCeDataAdapter(cmd.CommandText, cnn))
                    {
                        da.Fill(ds);
                        ds.Tables[0].TableName = outTableName;

                        DataSet = ds;
                        TableName = outTableName;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

            return ApplyBusinessLogic(businessInfo);
        }

        /// <summary>
        /// When you override this method, allows you to apply custom logic on the data set recovered after an <see cref="Query.Execute(string)" /> Execute method call.
        /// If you need additional information to apply logic, use overload of this method and in <c>data</c> parameter assign your additional information.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Data.DataSet" /> containing new result of query.
        /// </returns>
        protected virtual DataSet ApplyBusinessLogic()
        {
            return ApplyBusinessLogic(null);
        }

        /// <summary>
        /// When you override this method, allows you to apply custom logic on the data set recovered after an <see cref="Query.Execute(string, object)" /> method call with additional business information.
        /// </summary>
        /// <param name="data">Additional business information.</param>
        /// <returns>
        /// A <see cref="T:System.Data.DataSet" /> that contains the results of query.
        /// </returns>
        protected virtual DataSet ApplyBusinessLogic(object data)
        {
            return DataSet;
        }

        /// <summary>
        /// Determines whether the sql command contains sql injections.
        /// </summary>
        /// <param name="sql"><c>SQL</c> command to check.</param>
        /// <returns>
        /// <c>true</c> if exists <c>SQL</c> injection by '--' or by 'OR X=X'; Otherwise, <c>false</c>.
        /// </returns>
        private static bool HasSqlInjection(string sql)
        {
            if (sql.Contains("--"))
            {
                return true;
            }

            var items = sql.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var itemCount = items.Count(item => item.Equals("OR"));

            var start = -1;
            var indexOfOrItems = new List<int>();
            for (var i = 0; i <= itemCount; i++)
            {
                start++;
                var index = items.FindIndex(start, items.Count - start, item => item.Equals("OR"));

                if (index != -1)
                {
                    indexOfOrItems.Add(index);
                }

                start = index;
            }

            var exit = false;
            foreach (var index in indexOfOrItems)
            {
                if (items[index + 1].Equals(items[index + 3]) && items[index + 2].Equals("="))
                {
                    exit = true;
                    break;
                }

                var isAtomic = items[index + 1].Contains("=");
                if (!isAtomic)
                {
                    break;
                }

                var atomicItems = items[index + 1].Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (atomicItems[0].Equals(atomicItems[1]))
                {
                    exit = true;
                    break;
                }
            }

            return exit;
        }
    }
}

//#region [private] {static} (void) LogDB2Exception(iDB2Exception): Handles provider errors.
///// <summary>
///// Logs the DB2 exception.
///// </summary>
///// <param name="ex">The exception.</param>
//private static void LogDb2Exception(iDB2Exception ex)
//{
//    var exceptionNumber = "Exception Number : " + ex.MessageCode + "(" + ex.MessageDetails + ") has occurred";
//    Console.WriteLine(exceptionNumber);
//    foreach (iDB2Error er in ex.Errors)
//    {
//        var message = "Message : " + er.Message + " Code : " + er.MessageCode + " State : " + er.SqlState;
//        Console.WriteLine(message);
//    }
//}
//#endregion
