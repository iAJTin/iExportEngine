
namespace iTin.Export
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    using Helper;
    using Model;

    /// <summary>
    /// Specifies a set of features supported on the object <see cref="T:iTin.Export.ExportSettings" />.
    /// </summary>
    public class ExportSettings
    {
        #region private field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Uri outputFile;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Uri transformFile;
        #endregion

        #region public properties

        #region [public] (string) From: Gets or sets a value indicating name of the data model to use
        /// <summary>
        /// Gets or sets a value indicating name of the data model to use.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> which contains the name of the data model to use. 
        /// </value>        
        public string From { get; set; }
        #endregion

        #region [public] (bool) IsEmpty: Gets a value indicating whether this object is empty
        /// <summary>
        /// Gets a value indicating whether this object is empty.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if empty; otherwise, <strong>false</strong>.
        /// </value>        
        public bool IsEmpty => (OutputFile == null) && (TransformFile == null);
        #endregion
       
        #region [public] (Uri) OutputFile: Gets or set a value that represents the path of the output file
        /// <summary>
        /// Gets or sets a value that represents the path of the output file.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Uri"/> object that represents the path of the output file.
        /// </value>
        public Uri OutputFile
        {
            get => outputFile;
            set
            {
                SentinelHelper.ArgumentNull(value, Resources.ErrorMessage.PathNotNull);
                outputFile = value;
            }
        }
        #endregion

        #region [public] (Uri) TransformFile: Gets or set a value that represents the path of the transform file
        /// <summary>
        /// Gets or sets a value that represents the path of the transform file.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Uri" /> object that represents the path of the transform file.
        /// </value>
        public Uri TransformFile
        {
            get => transformFile;
            set
            {
                SentinelHelper.ArgumentNull(value, Resources.ErrorMessage.PathNotNull);
                transformFile = value;
            }
        }
        #endregion

        #endregion

        #region protected properties

        #region [protected] {internal} (Uri) ConfigurationFile: Gets or sets a value that represents the path of the configuration file
        /// <summary>
        /// Gets or sets a value that represents the path of the configuration file.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Uri" /> object that represents the path of the configuration file.
        /// </value>
        private Uri ConfigurationFile { get; set; }
        #endregion

        #endregion

        #region private properties

        #region [private] (bool) HasConfiguration: Gets a value indicating whether this object is empty
        /// <summary>
        /// Gets a value indicating whether this object is empty.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if empty; otherwise, <strong>false</strong>.
        /// </value>        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool HasConfiguration => ConfigurationFile != null;
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (ExportSettings) ImportFrom(Uri): Returns a export settings object reference from a configuration file
        /// <summary>
        /// Returns a export settings object reference from a configuration file.
        /// </summary>
        /// <param name="configuration">Configuration file path.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        /// <exception cref="System.IO.FileNotFoundException">File exception</exception>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static ExportSettings ImportFrom(Uri configuration)
        {
            return ImportFrom(configuration, string.Empty);
        }
        #endregion

        #region [public] {static} (ExportSettings) ImportFrom(Uri, string): Returns a reference which contains specified export data model from the specified configuration file
        /// <summary>
        /// Returns a reference which contains specified export data model from the specified configuration file
        /// </summary>
        /// <param name="configuration">Configuration file path.</param>
        /// <param name="from">Name of the data model to use.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        /// <exception cref="System.IO.FileNotFoundException">File exception</exception>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static ExportSettings ImportFrom(Uri configuration, string from)
        {
            SentinelHelper.ArgumentNull(configuration);

            var config = configuration.OriginalString;
            var existConfiguration = File.Exists(config);
            if (!existConfiguration)
            {
                throw new FileNotFoundException(Resources.ErrorMessage.ConfigurationFileNotFound);
            }

            var settings = new ExportSettings
            {
                From = from,
                ConfigurationFile = configuration                    
            };

            return settings;
        }
        #endregion

        #region [public] {static} (ExportSettings) CreateFromModel(ExportsModel): Returns a export settings object reference from a data model
        /// <summary>
        /// Returns a export settings object reference from a data model.
        /// </summary>
        /// <param name="model">The data model.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static ExportSettings CreateFromModel(ExportsModel model)
        {
            return CreateFromModel(model, string.Empty);
        }
        #endregion

        #region [public] {static} (ExportSettings) CreateFromModel(ExportsModel, string): Returns a reference which contains specified export data model from the specified data model
        /// <summary>
        /// Returns a reference which contains specified export data model from the specified data model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="from">Name of the data model to use.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        /// <exception cref="System.IO.FileNotFoundException">File exception</exception>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static ExportSettings CreateFromModel(ExportsModel model, string from)
        {
            SentinelHelper.ArgumentNull(from);
            SentinelHelper.ArgumentNull(model);

            var configuration = FileHelper.GetUniqueTempRandomFile();
            var config = configuration.OriginalString;
            model.SaveToFile(config);

            var existConfiguration = File.Exists(config);
            if (!existConfiguration)
            {
                throw new FileNotFoundException(Resources.ErrorMessage.ConfigurationFileNotFound);
            }

            var settings = new ExportSettings
            {
                From = from,
                ConfigurationFile = configuration
            };

            return settings;
        }
        #endregion

        #region [public] {static} (bool) TryGetConfigurationFile(ExportSettings, out Uri): Try to get the configuration file from a ExportSettings reference. Returns a value indicating if it was possible to obtain the configuration file
        /// <summary>
        /// Try to get the configuration file from a <see cref="T:iTin.Export.ExportSettings" /> reference. Returns a value indicating if it was possible to obtain the configuration file.
        /// </summary>
        /// <param name="settings">Export settings reference.</param>
        /// <param name="configuration">Configuration file.</param>
        /// <returns>
        /// <strong>true</strong> if it was possible to obtain the configuration file; otherwise <strong>false</strong>.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        public static bool TryGetConfigurationFile(ExportSettings settings, out Uri configuration)
        {
            SentinelHelper.ArgumentNull(settings);

            if (!(settings is HttpExportSettings httpSettings))
            {
                var hasConfiguration = settings.HasConfiguration;
                if (hasConfiguration)
                {
                    configuration = settings.ConfigurationFile;
                    return true;
                }
            }
            else
            {
                var hasConfiguration = httpSettings.Settings.HasConfiguration;
                if (hasConfiguration)
                {
                    configuration = httpSettings.Settings.ConfigurationFile;
                    return true;
                }
            }

            configuration = null;
            return false;
        }
        #endregion

        #endregion
    }
}
