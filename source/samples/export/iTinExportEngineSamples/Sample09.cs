
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    public class Sample09
    {
        private const string EpplusHeader = " · Running sample 9 (From configuration file)";
        private const string FirstSampleStepText   = "  - Use charts with more than one charttype and secondary axis";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Properties.Settings.Default.SalesXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Properties.Settings.Default.Sample09Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
