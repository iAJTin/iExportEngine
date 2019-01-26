
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample04
    {
        private const string EpplusHeader = " · Running sample 4 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Charts With More Than One Chart Type And Secondary Axis";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.StockProducts, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Settings.Default.Sample04Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
