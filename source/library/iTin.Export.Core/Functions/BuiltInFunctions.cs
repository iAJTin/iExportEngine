
namespace iTin.Export
{
    using System;

    using ComponentModel;

    /// <summary>
    /// Specifies a set of built-in functions availables for static resources.
    /// </summary>
    public static class BuiltInFunctions
    {
        /// <summary>
        /// Gets the get current date time.
        /// </summary>
        /// <value>
        /// The get current date time.
        /// </value>
        public static DateTime CurrentDatetime => DateTime.Now;

        /// <summary>
        /// Gets the get timespan.
        /// </summary>
        /// <value>
        /// The get timespan.
        /// </value>
        public static TimeSpan CurrentTimeSpan => DateTime.Now.TimeOfDay;

        /// <summary>
        /// Gets the get current machine name
        /// </summary>
        /// <value>
        /// Machine name.
        /// </value>
        public static string MachineName => Environment.MachineName;

        /// <summary>
        /// Gets the get current user name
        /// </summary>
        /// <value>
        /// User name.
        /// </value>
        public static string UserName => Environment.UserName;


        /// <summary>
        /// Gets total defined-styles.
        /// </summary>
        /// <value>
        /// Total defined-styles
        /// </value>
        public static string CurrentTableName => ModelService.Instance.CurrentModel.Table.Name;

        /// <summary>
        /// Gets total fields for current model.
        /// </summary>
        /// <value>
        /// Total fields for current model
        /// </value>
        public static int TotalFields => ModelService.Instance.CurrentModel.Table.Fields.Count;

        /// <summary>
        /// Gets total defined-styles
        /// </summary>
        /// <value>
        /// Total defined-styles.
        /// </value>
        public static int TotalStyles => ModelService.Instance.Resources.Styles.Count;
    }
}
