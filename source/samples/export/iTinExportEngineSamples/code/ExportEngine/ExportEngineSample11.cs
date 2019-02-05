
namespace iTinExportEngineSamples.ExportEngineSamples
{
    using System;
    using System.Linq;

    using iTin.Export;
    using iTin.Export.Helpers;
    using iTin.Export.Inputs;
    using iTin.Export.Model;

    using Properties;

    public class ExportEngineSample11
    {
        private const string EpplusHeader = " · Running Sample 11 (From Configuration File)";
        private const string FirstSampleStepText = "  - Custom output filename";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configurationFile = PathHelper.ResolveRelativePath(Settings.Default.ExportEngineSample11Configuration);
            var models = ExportsModel.LoadFromFile(configurationFile);
            var model = models.Items.FirstOrDefault();
            model.Table.Output.File = "sample11-custom-file-name-from-code";
            model.Table.Output.Path = @"~\output\ExportEngine\";

            input.Export(ExportSettings.CreateFromModels(models, "Sample11"));
        }
    }
}
