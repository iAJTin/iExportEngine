using System;
using iTin.Export;
using iTin.Export.Inputs;
using iTin.Export.Model;

namespace iTinExportEngineSamples
{
    public class Sample01
    {
        private const string EpplusHeader          = " 9 - EPPlus samples";
        private const string OneStepText           = " a. Read data from xml file";
        private const string TwoStepText           = " b. Export data";
        private const string ThreeStepText         = "   . MS Excel (xlsx)";
        private const string FourStepText          = "     - From code";
        private const string FiveStepText          = "     - From configuration file";
        private const string FirstSampleStepText   = "         -> Some data...                   -> [sample90.xlsx] <-";
        private const string SecondSampleStepText  = "         -> ... with chart ...             -> [sample90-chart.xlsx] <-";
        private const string ThirdSampleStepText   = "         -> ... and banner ...             -> [sample90-banner.xlsx] <-";
        private const string FourthSampleStepText  = "         -> ... and resume info ...        -> [sample90-headerinfo.xlsx] <-";
        private const string FifthSampleStepText   = "         -> ... and built-in functions ... -> [sample90-headerinfo-built-in-functions.xlsx] <-";
        private const string SixthSampleStepText   = "         -> ... and custom functions       -> [sample90-headerinfo-custom-functions.xlsx] <-";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(new string('-', 52));

            Console.WriteLine(OneStepText);
            //var inputUri = new Uri(Properties.Settings.Default.SEKRatesXmlInput, UriKind.Relative);
            //var export = new XmlInput(inputUri);

            var inputUri = new Uri(Properties.Settings.Default.InventoryXmlInput, UriKind.Relative);
            var export = new XmlInput(inputUri);

            //Console.WriteLine(OneStepText);
            //var inputUri = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //var export = new XmlInput(inputUri);

            Console.Write(TwoStepText);
            Console.WriteLine();
            Console.WriteLine(ThreeStepText);

            Console.WriteLine(FiveStepText);
            Console.WriteLine(FirstSampleStepText);
            //var sample90FileConfiguration = new Uri(Properties.Settings.Default.Sample16, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90FileConfiguration, "sample16"));

            var sample90FileConfiguration = new Uri(Properties.Settings.Default.Sample01Configuration, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90FileConfiguration));
        }
    }
}
