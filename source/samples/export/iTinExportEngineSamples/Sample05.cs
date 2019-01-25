﻿
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample05
    {
        private const string EpplusHeader = " · Running sample 5 (From configuration file)";
        private const string FirstSampleStepText   = "  - Use pivottables";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.SalesDataXmlInput, UriKind.Relative);
            var export = new XmlInput(input);

            var configuration = new Uri(Settings.Default.Sample05Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
