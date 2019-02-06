
namespace iTinExportEngineFunctions
{
    using System;

    public static class Common
    {
        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <value>
        /// The current date time.
        /// </value>
        public static DateTime GetCurrentDatetime
        {
            get
            {
                return DateTime.Now;                
            }
        }

        /// <summary>
        /// Gets the timespan.
        /// </summary>
        /// <value>
        /// The timespan.
        /// </value>
        public static TimeSpan GetCurrentTimeSpan
        {
            get
            {
                return DateTime.Now.TimeOfDay;
            }
        }

        /// <summary>
        /// Gets sample12 filename
        /// </summary>
        /// <value>
        /// Sample12 filename
        /// </value>
        public static string GetSample12Filename
        {
            get
            {
                return "sample12-custom-file-name-from-binding";
            }
        }

        /// <summary>
        /// Gets sample12 path
        /// </summary>
        /// <value>
        /// Sample12 path
        /// </value>
        public static string GetSample12Path
        {
            get
            {
                return @"~\output\xlsx\ExportEngine\";
            }
        }
    }
}
