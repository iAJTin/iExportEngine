
namespace iTinExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.ComponentModel.Input;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample06
    {
        private const string EpplusHeader = " · Running Sample 6 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Mini Charts";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.SEKRatesXmlInput, UriKind.Relative);
            BaseInput export = new XmlInput(input);

            var configuration = new Uri(Settings.Default.Sample06Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
