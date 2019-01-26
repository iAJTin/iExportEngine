
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample02
    {
        private const string EpplusHeader = " · Running Sample 2 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Equals To Sample 1 And Adds 2 New rows And A Piechart";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.ProductsXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Settings.Default.Sample02Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
