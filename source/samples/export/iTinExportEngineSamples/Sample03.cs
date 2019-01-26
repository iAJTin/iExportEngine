
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample03
    {
        private const string EpplusHeader = " · Running sample 3 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Stacked Charts";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.SalesXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Settings.Default.Sample03Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
