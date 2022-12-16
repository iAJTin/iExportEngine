﻿
using System;

using iTin.Export;
using iTin.Export.Inputs;

namespace iTinExportEngineSamples.Writers.Xlsx
{
    using Properties;

    public class EPPlusSample06
    {
        private const string Header = " · Running Sample 6 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Mini Charts";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.SEKRatesXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.EPPlusSample06Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
