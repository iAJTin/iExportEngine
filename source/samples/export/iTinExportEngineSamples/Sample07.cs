
namespace iTinExportEngineSamples
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using iTin.Export;
    using iTin.Export.ComponentModel.Input;
    using iTin.Export.Inputs;

    using Properties;

    public class Sample07
    {
        private const string EpplusHeader = " · Running Sample 7 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Creates A New Workbook From Custom Enumerated Data Type (1000 rows)";

        /// <summary>
        /// Custom data definition.
        /// </summary>
        private class CustomData
        {
            public int Index { get; set; }

            public string Text { get; set; }

            public DateTime Date { get; set; }

            public double Number { get; set; }
        }

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromCodeSample(int rows)
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var input = new Uri(Settings.Default.SEKRatesXmlInput, UriKind.Relative);
            BaseInput export = new EnumerableInput<CustomData>(BuildCustomData(rows), "Sample7");

            var configuration = new Uri(Settings.Default.Sample07Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(configuration));
        }

        private static IEnumerable<CustomData> BuildCustomData(int rows)
        {
            var rnd = new Random();
            var collection = new Collection<CustomData>();

            for (int row = 1; row <= rows; row++)
            {
                collection.Add(new CustomData
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
