using System.Data;
using System.Text;

namespace iTin.Export
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="System.Data" />.
    /// </summary>
    static class DataExtensions
    {
        /// <summary>
        /// To the HTML table.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string ToHtmlTable(this DataTable input)
        {
            var html = new StringBuilder();
            html.Append("<table>");

            // add header row
            html.Append("<tr>");
            for (var i = 0; i < input.Columns.Count; i++)
            {
                html.AppendFormat("<td>{0}</td>", input.Columns[i].ColumnName);
            }

            html.Append("/<tr>");

            // add rows
            for (var i = 0; i < input.Rows.Count; i++)
            {
                html.Append("<tr>");
                for (var j = 0; j < input.Columns.Count; j++)
                {
                    html.AppendFormat("<td>{0}</td>", input.Rows[i][j]);
                }

                html.Append("/<tr>");
            }

            html.Append("/<table>");

            return html.ToString();
        }
    }
}
