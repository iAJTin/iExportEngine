
using System;

using iTin.Export;
using iTin.Export.Inputs;

using iTinExportEngineSamples.Properties;

namespace iTinExportEngineSamples.Writers.Xlsx
{
    public class ExportEngineSample07
    {
        private const string Header = " · Running Sample 7 (From Configuration File)";
        private const string FirstSampleStepText = "  - How to add block lines";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InvoiceXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.ExportEngineSample07Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
