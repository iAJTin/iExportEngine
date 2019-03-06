
namespace iTinExportEngineSamples.Templates.Docx
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class DocxTemplateSample01
    {
        private const string Header = " · Running Sample 1 (From Configuration File)";
        private const string FirstSampleStepText = "  - Simply Creates docx mailing";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(Header);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.PacketXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.DocxTemplateSample01Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
