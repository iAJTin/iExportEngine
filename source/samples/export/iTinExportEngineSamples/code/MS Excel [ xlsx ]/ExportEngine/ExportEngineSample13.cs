
namespace iTinExportEngineSamples.ExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class ExportEngineSample13
    {
        private const string Header = " · Running Sample 13 (From Configuration File)";
        private const string FirstSampleStepText = "  - How to change the width of the fields";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.ExportEngineSample13Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
