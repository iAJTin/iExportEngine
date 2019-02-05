
namespace iTinExportEngineSamples.EPPlusSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class EPPlusSample01
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

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample01Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
