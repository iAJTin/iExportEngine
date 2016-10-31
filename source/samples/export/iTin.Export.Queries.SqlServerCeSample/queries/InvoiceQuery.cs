using System.Data;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Queries.SqlServerCe.Query" /> class.<br/>
    /// Applies logic into data received prior to export.
    /// </summary>
    public class InvoiceQuery : Query
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceQuery"/> class.
        /// </summary>
        /// <param name="cn">Connection to use.</param>
        public InvoiceQuery(Connection cn)
            : base(cn)
        {
        }

        /// <summary>
        /// Apply logic to the <see cref="T:System.Data.DataSet" /> object after call to execute method.
        /// In this case, are performed some arithmetic operations on some column of datase.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Data.DataSet" /> that contains the results of query.
        /// </returns>
        protected override DataSet ApplyBusinessLogic()
        {

            return this.DataSet;
        }
    }
}
