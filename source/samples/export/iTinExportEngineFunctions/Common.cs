using System;

namespace iTinExportEngineFunctions
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
                return DateTime.Now;                
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
    }
}
