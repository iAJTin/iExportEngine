
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace iTin.Export.ComponentModel.Input
{
    using Helpers;
    using Model;
    using Provider;

    /// <inheritdoc />
    /// <summary>
    /// Base class for the different input types.
    /// Which acts as the base class for the different input types.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different input types.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.ArraListInput" /></term>
    ///       <description>Represents an input for array of <see cref="T:System.Collections.ArrayList" /> types. For more information please see <see cref="T:iTin.Export.Inputs.ArraListInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.DataRowInput" /></term>
    ///       <description>Represents an input for array of <see cref="T:System.Data.DataRow" /> types. For more information please see <see cref="T:iTin.Export.Inputs.DataRowInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.DataSetInput" /></term>
    ///       <description>Represents an input for <see cref="T:System.Data.DataSet" /> types. For more information please see <see cref="T:iTin.Export.Inputs.DataSetInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.DataTableInput" /></term>
    ///       <description>Represents an input for <see cref="T:System.Data.DataTable" /> types. For more information please see <see cref="T:iTin.Export.Inputs.DataTableInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.EnumerableInput" /></term>
    ///       <description>Represents an input for <see cref="T:System.Collections.Generic.IEnumerable{DataRow}" /> types. For more information please see <see cref="T:iTin.Export.Inputs.EnumerableInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.XmlInput" /></term>
    ///       <description>Represents an input for <c>Xml</c> type. For more information please see <see cref="T:iTin.Export.Inputs.XmlInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Inputs.JsonInput" /></term>
    ///       <description>Represents an input for <c>Json</c> type. For more information please see <see cref="T:iTin.Export.Inputs.JsonInput" /></description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public abstract class BaseInput : IInput
    {
        #region private readonly members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly InputOptionsMetadata _optionsMetadataInformation;

        #endregion

        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.Inputs.BaseInput" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        protected BaseInput(object data)
        {
            Data = data;
            _optionsMetadataInformation = new InputOptionsMetadata(this);
        }

        #endregion

        #region public properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference that contains the input data to export.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Object" /> that contains the input data to export.
        /// </value>
        public object Data
        {
            get; protected set;
        }

        #region [public] (InputOptionsMetadata) InputMetadata: Gets a reference that contains the metadata information about this input
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference that contains the metadata information about this input.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.TargetExtendedInformation" /> that contains the metadata information about this input.
        /// </value>
        public InputOptionsMetadata InputMetadata => _optionsMetadataInformation;
        #endregion

        #endregion

        #region public methods

        /// <inheritdoc />
        /// <summary>
        /// Exports the input data using the specified configuration in xml configuration file.
        /// </summary>
        /// <remarks>
        /// If <see cref="P:iTin.Export.ExportSettings.From" /> is <c>null</c> or <see cref="F:System.String.Empty" />, 
        /// always use the first section with <see cref="P:iTin.Export.Model.ExportModel.Current" /> attribute sets to <see cref="F:iTin.Export.Model.YesNo.Yes" />.
        /// </remarks>
        /// <param name="settings">Export settings</param>
        public void Export(ExportSettings settings)
        {
            SentinelHelper.ArgumentNull(settings);

            bool hasConfiguration = ExportSettings.TryGetConfigurationFile(settings, out Uri configuration);
            if (!hasConfiguration)
            {
                return;
            }

            ExportsModel root = LoadModelFrom(configuration);
            if (root == null)
            {
                return;
            }

            string candidateModelName = settings.From;
            ExportModel model = string.IsNullOrEmpty(candidateModelName)
                ? root.Items.FirstOrDefault(e => e.Current == YesNo.Yes)
                : root.Items.SingleOrDefault(e => e.Name.Equals(candidateModelName));

            if (model == null)
            {
                return;
            }

            //exportModel.Table.Fields.Validate();
            //exportModel.Table.Charts.Validate();

            ProvidersCache providers = ProvidersCache.Instance(this);
            IProvider provider = providers.GetProvider(InputMetadata);
            InputDataModel inputDataModel = new InputDataModel { Model = model, Resources = root.Resources, References = root.References };
            provider.SetInputDataModel(inputDataModel);
            provider.Export(settings);

            //// Proceso de validación.
            ////var aaa = root.Items[0].BlockLines[0];
            ////ValidationContext validationContext = new ValidationContext(aaa, null, null);
            ////List<ValidationResult> errors = new List<ValidationResult>();
            ////Validator.TryValidateObject(aaa, validationContext, errors, true);
            
            //// Si hay errores, los recorremos y los mostramos (versión demo).            
            ////if (errors.Any())
            ////{
            ////    string errorMessages = string.Empty;
            ////    foreach (var error in errors)
            ////    {
            ////        errorMessages += error.ErrorMessage + Environment.NewLine;
            ////    }
            ////    //MessageBox.Show(errorMessages);
            ////}
            ////else
            ////{
            ////    var ss = "OK";
            ////    //MessageBox.Show("Entidad correcta");
            ////}

            ////var s = ((TextLineModel)root.Resources.Lines[1]).GetStyle();
        }

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
    }
}
