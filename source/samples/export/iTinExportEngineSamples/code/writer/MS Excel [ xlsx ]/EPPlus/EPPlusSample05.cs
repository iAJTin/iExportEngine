
namespace iTinExportEngineSamples.Writers.Xlsx
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class EPPlusSample05
    {
        private const string Header = " · Running Sample 5 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Pivot Tables";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.SalesDataXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample05Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
