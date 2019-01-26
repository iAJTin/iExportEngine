
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample01
    {
        private const string EpplusHeader = " · Running Sample 1 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Settings.Default.Sample01Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
