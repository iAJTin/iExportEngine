
using System;

using iTin.Export;
using iTin.Export.Inputs;

using iTinExportEngineSamples.Properties;

namespace iTinExportEngineSamples.Writers.Xlsx
{
    public class EPPlusSample03
    {
        private const string Header = " · Running sample 3 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Stacked Charts";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.SalesXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample03Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
