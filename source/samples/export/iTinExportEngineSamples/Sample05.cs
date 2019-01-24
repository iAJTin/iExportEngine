
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    public class Sample05
    {
        private const string EpplusHeader = " · Running sample 5 (From configuration file)";
        private const string FirstSampleStepText   = "  - Equals to Sample 1 and add 2 new rows and a Piechart";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Properties.Settings.Default.ProductsXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Properties.Settings.Default.Sample05Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
