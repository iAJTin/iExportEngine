
namespace iTinExportEngineSamples.Writers.Xlsx
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class EPPlusSample04
    {
        private const string Header = " · Running sample 4 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Charts With More Than One Chart Type And Secondary Axis";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.StockProducts, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample04Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
