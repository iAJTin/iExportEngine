
namespace iTinExportEngineSamples.EPPlusSamples
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Models;
    using Properties;

    public class EPPlusSample07
    {
        private const string EpplusHeader = " · Running Sample 7 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Creates A New Workbook From Custom Enumerated Data Type (1000 rows)";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromCodeSample(int rows)
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new EnumerableInput<CustomDataModel>(BuildCustomData(rows), "Sample7");

            var configuration = new Uri(Settings.Default.EPPlusSample07Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }

        private static IEnumerable<CustomDataModel> BuildCustomData(int rows)
        {
            var rnd = new Random();
            var collection = new Collection<CustomDataModel>();

            for (int row = 1; row <= rows; row++)
            {
                collection.Add(new CustomDataModel
                {
                    Index = row,
                    Text = $"Row {row}",
                    Date = DateTime.Today.AddDays(row),
                    Number = rnd.NextDouble() * 10000
                });
            }

            return collection;
        }
    }
}
