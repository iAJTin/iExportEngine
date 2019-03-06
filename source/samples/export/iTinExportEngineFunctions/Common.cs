
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
        public static DateTime GetCurrentDatetime => DateTime.Now;

        /// <summary>
        /// Gets the timespan.
        /// </summary>
        /// <value>
        /// The timespan.
        /// </value>
        public static TimeSpan GetCurrentTimeSpan => DateTime.Now.TimeOfDay;

        /// <summary>
        /// Gets sample12 filename
        /// </summary>
        /// <value>
        /// Sample12 filename
        /// </value>
        public static string GetSample12Filename => "sample12-custom-file-name-from-binding";

        /// <summary>
        /// Gets sample12 path
        /// </summary>
        /// <value>
        /// Sample12 path
        /// </value>
        public static string GetSample12Path => @"~\output\writer\xlsx\ExportEngine\";
    }
}
