
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    public class Sample01
    {
        private const string EpplusHeader = " · Running sample 1 (From configuration file)";
        private const string FirstSampleStepText   = "  - Simply creates a new workbook from scratch. The workbook contains one worksheet with a simple invertory list";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Properties.Settings.Default.InventoryXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Properties.Settings.Default.Sample01Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
