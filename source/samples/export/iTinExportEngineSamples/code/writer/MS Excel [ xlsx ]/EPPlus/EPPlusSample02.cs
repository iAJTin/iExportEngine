
using System;

using iTin.Export;
using iTin.Export.Inputs;

using iTinExportEngineSamples.Properties;

namespace iTinExportEngineSamples.Writers.Xlsx
{
    public class EPPlusSample02
    {
        private const string Header = " · Running Sample 2 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Equals To Sample 1 And Adds 2 New rows And A Piechart";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.ProductsXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample02Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
