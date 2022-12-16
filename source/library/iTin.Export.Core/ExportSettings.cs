
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Schema;

namespace iTin.Export
{
    using Helpers;
    using Model;

    /// <summary>
    /// Specifies a set of features supported on the object <see cref="T:iTin.Export.ExportSettings" />.
    /// </summary>
    public class ExportSettings
    {
        #region private field members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Uri _outputFile;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Uri _transformFile;

        #endregion

        #region public properties

        /// <summary>
        /// Gets or sets a value indicating name of the data model to use.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> which contains the name of the data model to use. 
        /// </value>        
        public string From { get; set; }

        /// <summary>
        /// Gets a value indicating whether this object is empty.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if empty; otherwise, <strong>false</strong>.
        /// </value>        
        public bool IsEmpty => OutputFile == null && TransformFile == null;
       
        /// <summary>
        /// Gets or sets a value that represents the path of the output file.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Uri"/> object that represents the path of the output file.
        /// </value>
        public Uri OutputFile
        {
            get => _outputFile;
            set
            {
                SentinelHelper.ArgumentNull(value, Resources.ErrorMessage.PathNotNull);
                _outputFile = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that represents the path of the transform file.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Uri" /> object that represents the path of the transform file.
        /// </value>
        public Uri TransformFile
        {
            get => _transformFile;
            set
            {
                SentinelHelper.ArgumentNull(value, Resources.ErrorMessage.PathNotNull);
                _transformFile = value;
            }
        }

        #endregion

        #region protected properties

        /// <summary>
        /// Gets or sets a value that represents the path of the configuration file.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Uri" /> object that represents the path of the configuration file.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Uri ConfigurationFile { get; set; }

        #endregion

        #region private properties

        /// <summary>
        /// Gets a value indicating whether this object is empty.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if empty; otherwise, <strong>false</strong>.
        /// </value>        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool HasConfiguration => ConfigurationFile != null;

        #endregion

        #region private static methods

        /// <summary>
        /// Import general properties from a configuration file.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <returns>
        /// RootModel object
        /// </returns>
        /// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Occurs if the model contains errors.</exception>
        /// <exception cref="T:System.InvalidOperationException">Occurs if a style assigned to a field is blank or does not exist.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">Occurs if not found the path to configuration file.</exception>
        private static ExportsModel LoadModelFrom(Uri configuration)
        {
            ExportsModel model;

            try
            {
                model = ExportsModel.LoadFromFile(configuration.OriginalString);
            }
            catch (InvalidOperationException ex)
            {
                var modelErrorMessage = new StringBuilder();
                modelErrorMessage.AppendLine(ex.Message);
                var inner = ex.InnerException;
                while (true)
                {
                    if (inner == null)
                    {
                        break;
                    }

                    modelErrorMessage.AppendLine(inner.Message);
                    inner = inner.InnerException;
                }

                throw new XmlSchemaValidationException(modelErrorMessage.ToString());
            }

            return model;
        }

        #endregion

        #region public static methods

        /// <summary>
        /// Returns a export settings object reference from a configuration file.
        /// </summary>
        /// <param name="configuration">Configuration file path.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        /// <exception cref="System.IO.FileNotFoundException">File exception</exception>
        public static ExportSettings ImportFrom(Uri configuration) => ImportFrom(configuration, string.Empty);

        /// <summary>
        /// Returns a reference which contains specified export data model from the specified configuration file
        /// </summary>
        /// <param name="configuration">Configuration file path.</param>
        /// <param name="from">Name of the data model to use.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        /// <exception cref="System.IO.FileNotFoundException">File exception</exception>
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

        /// <summary>
        /// Returns a export settings object reference from a data model.
        /// </summary>
        /// <param name="model">The data model.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        public static ExportSettings CreateFromModels(ExportsModel model) => CreateFromModels(model, string.Empty);

        /// <summary>
        /// Returns a reference which contains specified export data model from the specified data model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="from">Name of the data model to use.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ExportSettings" /> object that represents export settings.
        /// </returns>
        /// <exception cref="System.IO.FileNotFoundException">File exception</exception>
        public static ExportSettings CreateFromModels(ExportsModel model, string from)
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

        /// <summary>
        /// Try to get the configuration file from a <see cref="T:iTin.Export.ExportSettings" /> reference. Returns a value indicating if it was possible to obtain the configuration file.
        /// </summary>
        /// <param name="settings">Export settings reference.</param>
        /// <param name="configuration">Configuration file.</param>
        /// <returns>
        /// <strong>true</strong> if it was possible to obtain the configuration file; otherwise <strong>false</strong>.
        /// </returns>
        public static bool TryGetConfigurationFile(ExportSettings settings, out Uri configuration)
        {
            SentinelHelper.ArgumentNull(settings);

            var hasConfiguration = settings.HasConfiguration;
            if (hasConfiguration)
            {
                configuration = settings.ConfigurationFile;
                return true;
            }

            configuration = null;
            return false;
        }

        #endregion
    }
}
