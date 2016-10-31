using System;

namespace iTin.Export.Queries.SqlServerCe.Functions
{
    public static class Common
    {
        /// <summary>
        /// Gets the get current date time.
        /// </summary>
        /// <value>
        /// The get current date time.
        /// </value>
        public static DateTime GetCurrentDatetime
        {
            get
            {
                return DateTime.Now.AddDays(2);
            }
        }

        /// <summary>
        /// Gets the get timespan.
        /// </summary>
        /// <value>
        /// The get timespan.
        /// </value>
        public static TimeSpan GetCurrentTimeSpan
        {
            get
            {
                return DateTime.Now.TimeOfDay;
            }
        }

        public static string GetXlsxExportDescription
        {
            get
            {
                return "Employee query sample";
            }
        }

        public static string GetEmployeeIdFieldName
        {
            get
            {
                return "EmployeeId";
            }
        }

        public static string GetEmailFieldName
        {
            get
            {
                return "Email";
            }
        }

        public static string GetEmployeeIdHeaderStyleName
        {
            get
            {
                return "HeaderStyle";
            }
        }
    }
}
