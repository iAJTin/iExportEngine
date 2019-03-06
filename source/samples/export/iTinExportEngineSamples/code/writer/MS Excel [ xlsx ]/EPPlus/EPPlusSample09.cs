
namespace iTinExportEngineSamples.Writers.Xlsx
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class EPPlusSample09
    {
        private const string Header = " · Running Sample 9 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Create a spreadsheet where the value of a field is not displayed";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample09Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
