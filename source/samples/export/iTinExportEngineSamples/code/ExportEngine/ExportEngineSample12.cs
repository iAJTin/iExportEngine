﻿
namespace iTinExportEngineSamples.ExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class ExportEngineSample12
    {
        private const string EpplusHeader = " · Running Sample 12 (From Configuration File)";
        private const string FirstSampleStepText = "  - Custom output filename from binding";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.ExportEngineSample12Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
