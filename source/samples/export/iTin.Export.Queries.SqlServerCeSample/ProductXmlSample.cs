using System;

using iTin.Export.Inputs;
using iTin.Export.Model;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    public class ProductXmlSample
    {
        private const string ProductQueryHeader = " 1 - Product query from xml";
        private const string OneStepText = " a. Read data from file";
        private const string TwoStepText = " b. Export data";
        private const string ThreeStepText = "   . MS Excel (xlsx)";
        private const string FourStepText = "     - From code";
        private const string FiveStepText = "     - From configuration file";

        public static void RunSample()
        {
            Console.WriteLine(ProductQueryHeader);
            Console.WriteLine(new string('-', 52));

            Console.WriteLine(OneStepText);
            //var invoiceXmlInputUri = new Uri(Properties.Settings.Default.ProductXmlInput, UriKind.Relative);
            var invoiceXmlInputUri = new Uri(Properties.Settings.Default.SalesXmlInput, UriKind.Relative);
            var export = new XmlInput(invoiceXmlInputUri);

            Console.Write(TwoStepText);
            Console.WriteLine();
            Console.WriteLine(ThreeStepText);

            Console.WriteLine(FiveStepText);
            //var configuration = new Uri(Properties.Settings.Default.ProductExportConfigurationFile, UriKind.Relative);
            var configuration = new Uri(Properties.Settings.Default.Sample91ExportConfigurationFile, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration, "epplus-xlsx"));
        }
    }
}
