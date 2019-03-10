
namespace iTinExportEngineSamples.Writers.Markdown
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class MDSample02
    {
        private const string Header = " · Running Sample 2 (From Configuration File)";
        private const string FirstSampleStepText = "  - Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InvoiceXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.MDSample02Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
