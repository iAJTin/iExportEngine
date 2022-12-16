﻿
using System;

using iTin.Export;
using iTin.Export.Inputs;

using iTinExportEngineSamples.Properties;

namespace iTinExportEngineSamples.Writers.Markdown
{
    public class MDSample01
    {
        private const string Header = " · Running Sample 1 (From Configuration File)";
        private const string FirstSampleStepText = "  - Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.MDSample01Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
