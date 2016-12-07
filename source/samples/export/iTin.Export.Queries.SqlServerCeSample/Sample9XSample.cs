using System;

using iTin.Export.Inputs;
using iTin.Export.Model;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    public class Sample9XSample
    {
        private const string EpplusHeader = " 9 - EPPlus samples";
        private const string OneStepText = " a. Read data from file";
        private const string TwoStepText = " b. Export data";
        private const string ThreeStepText = "   . MS Excel (xlsx)";
        private const string FourStepText = "     - From code";
        private const string FiveStepText = "     - From configuration file";

        public static void RunSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(new string('-', 52));

            Console.WriteLine(OneStepText);
            var inputUri = new Uri(Properties.Settings.Default.ProductXmlInput, UriKind.Relative);
            var export = new XmlInput(inputUri);

            Console.Write(TwoStepText);
            Console.WriteLine();
            Console.WriteLine(ThreeStepText);
            Console.WriteLine(FourStepText);
            //var sample90Configuration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90Configuration, "sample90"));

            //var sample90ChartConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90ChartConfiguration, "sample90-chart"));

            Console.WriteLine(FiveStepText);
            //var sample90Configuration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90Configuration, "sample90"));

            //var sample90ChartConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90ChartConfiguration, "sample90-chart"));

            //var sample90BannerConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90BannerConfiguration, "sample90-banner"));

            var sample90HeaderInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90HeaderInfoConfiguration, "sample90-headerinfo"));
        }
    }
}
