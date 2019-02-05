
namespace iTinExportEngineSamples
{
    using System;
    using System.Diagnostics;

    using EPPlusSamples;
    using ExportEngineSamples;

    class Program
    {
        private const string LastStepText = " Finished Without Errors. Press Any Key...";

        private static readonly Stopwatch Watch = new Stopwatch();

        private static TimeSpan eppSample01Time;
        private static TimeSpan eppSample02Time;
        private static TimeSpan eppSample03Time;
        private static TimeSpan eppSample04Time;
        private static TimeSpan eppSample05Time;
        private static TimeSpan eppSample06Time;
        private static TimeSpan eppSample07Time;
        private static TimeSpan eppSample01CodeTime;

        private static TimeSpan engineSample01Time;
        private static TimeSpan engineSample02Time;
        private static TimeSpan engineSample03Time;
        private static TimeSpan engineSample04Time;
        private static TimeSpan engineSample05Time;
        private static TimeSpan engineSample06Time;
        private static TimeSpan engineSample07Time;
        private static TimeSpan engineSample08Time;
        private static TimeSpan engineSample09Time;
        private static TimeSpan engineSample10Time;
        private static TimeSpan engineSample11Time;
        private static TimeSpan engineSample12Time;

        static void Main(string[] args)
        {
            #region EPPlus Samples

            #region Header
            Console.WriteLine();
            Console.WriteLine(@"Run EPPlus Samples");
            Console.WriteLine(new string('=', 90));
            Console.WriteLine();
            #endregion

            #region Sample 1 - Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List
            // From configuration File 
            Watch.Start();
            EPPlusSample01.RunFromConfigurationFileSample();
            eppSample01Time = Watch.Elapsed;
            Watch.Reset();

            // From code
            Watch.Start();
            Console.WriteLine();
            EPPlusSample01FromCode.RunFromCodeSample();
            eppSample01CodeTime = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 2 - Equals To Sample 1 And Adds 2 New Rows And A Piechart
            Watch.Start();
            Console.WriteLine();
            EPPlusSample02.RunFromConfigurationFileSample();
            eppSample02Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 3 - Use stacked charts
            Watch.Start();
            Console.WriteLine();
            EPPlusSample03.RunFromConfigurationFileSample();
            eppSample03Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 4 - Use Charts With More Than One Chart Type And Secondary Axis
            Watch.Start();
            Console.WriteLine();
            EPPlusSample04.RunFromConfigurationFileSample();
            eppSample04Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 5 - Use Pivot Tables
            Watch.Start();
            Console.WriteLine();
            EPPlusSample05.RunFromConfigurationFileSample();
            eppSample05Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 6 - Use Mini Charts
            Watch.Start();
            Console.WriteLine();
            EPPlusSample06.RunFromConfigurationFileSample();
            eppSample06Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 7 - Creates A New Workbook From Custom Enumerated Data Type (5000 rows)
            Watch.Start();
            Console.WriteLine();
            EPPlusSample07.RunFromCodeSample(5000);
            eppSample07Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Summary
            WriteEPPlusElapsedTime(
                eppSample01Time, 
                eppSample01CodeTime, 
                eppSample02Time, 
                eppSample03Time, 
                eppSample04Time, 
                eppSample05Time, 
                eppSample06Time, 
                eppSample07Time);
            #endregion

            #endregion

            #region ExportEngine Samples

            #region Header
            Console.WriteLine();
            Console.WriteLine(@"Run ExportEngine Samples");
            Console.WriteLine(new string('=', 90));
            Console.WriteLine();
            #endregion

            #region Sample 1 - Equals to EPPlus sample 1 with an image banner with effects and custom data table location
            // From configuration File 
            Watch.Start();
            ExportEngineSample01.RunFromConfigurationFileSample();
            engineSample01Time = Watch.Elapsed;
            Watch.Reset();
            #endregion

            #region Sample 2 - How to use group fields, Creates a new customer field

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample02.RunFromConfigurationFileSample();
            engineSample02Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 3 - How to creates a column header fields

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample03.RunFromConfigurationFileSample();
            engineSample03Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 4 - Sample with groups, headers, banner and aggregate's functions

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample04.RunFromConfigurationFileSample();
            engineSample04Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 5 - How to use simple filters

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample05.RunFromConfigurationFileSample();
            engineSample05Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 6 - How to use conditions

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample06.RunFromConfigurationFileSample();
            engineSample06Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 7 - How to add block lines

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample07.RunFromConfigurationFileSample();
            engineSample07Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 8 - How to use gap field type

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample08.RunFromConfigurationFileSample();
            engineSample08Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 9 - How to use fixed width field type

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample09.RunFromConfigurationFileSample();
            engineSample09Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 10 - How to use binded functions

            // From configuration File 
            Watch.Start();
            Console.WriteLine();
            ExportEngineSample10.RunFromConfigurationFileSample();
            engineSample10Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 11 - Custom output filename from code

            Watch.Start();
            Console.WriteLine();
            ExportEngineSample11.RunFromConfigurationFileSample();
            engineSample11Time = Watch.Elapsed;
            Watch.Reset();

            #endregion

            #region Sample 12 - Custom output filename from binding

            Watch.Start();
            Console.WriteLine();
            ExportEngineSample12.RunFromConfigurationFileSample();
            engineSample12Time = Watch.Elapsed;
            Watch.Stop();

            #endregion

            #region Summary
            WriteExportEngineElapsedTime(
                engineSample01Time,
                engineSample02Time,
                engineSample03Time,
                engineSample04Time,
                engineSample05Time,
                engineSample06Time,
                engineSample07Time,
                engineSample08Time,
                engineSample09Time,
                engineSample10Time,
                engineSample11Time,
                engineSample12Time);
            #endregion

            #endregion

            #region Exit app
            Console.WriteLine(LastStepText);
            Console.ReadKey();
            #endregion
        }

        private static void WriteEPPlusElapsedTime(TimeSpan ts1, TimeSpan ts1c, TimeSpan ts2, TimeSpan ts3, TimeSpan ts4, TimeSpan ts5, TimeSpan ts6, TimeSpan ts7)
        {
            var configurationTotalTime = ts1 + ts2 + ts3 + ts4 + ts5 + ts6 + ts7;
            var codeTotalTime = ts1c;

            Console.WriteLine();
            Console.WriteLine(@"                    Elapsed Time");
            Console.WriteLine(@"            ----------------------------");
            Console.WriteLine(@" EPPlus     From                From");
            Console.WriteLine(@" Summary    Configuration       Code");
            Console.WriteLine(new string('=', 46));
            Console.WriteLine(@" Sample1    {0:00}:{1:00}.{2:00}                {3:00}:{4:00}.{5:00}", ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10, ts1c.Minutes, ts1c.Seconds, ts1c.Milliseconds / 10);
            Console.WriteLine(@" Sample2    {0:00}:{1:00}.{2:00}", ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
            Console.WriteLine(@" Sample3    {0:00}:{1:00}.{2:00}", ts3.Minutes, ts3.Seconds, ts3.Milliseconds / 10);
            Console.WriteLine(@" Sample4    {0:00}:{1:00}.{2:00}", ts4.Minutes, ts4.Seconds, ts4.Milliseconds / 10);
            Console.WriteLine(@" Sample5    {0:00}:{1:00}.{2:00}", ts5.Minutes, ts5.Seconds, ts5.Milliseconds / 10);
            Console.WriteLine(@" Sample6    {0:00}:{1:00}.{2:00}", ts6.Minutes, ts6.Seconds, ts6.Milliseconds / 10);
            Console.WriteLine(@" Sample7    {0:00}:{1:00}.{2:00}", ts7.Minutes, ts7.Seconds, ts7.Milliseconds / 10);
            Console.WriteLine(new string('-', 46));
            Console.WriteLine(@"            {0:00}:{1:00}.{2:00}                {3:00}:{4:00}.{5:00}", configurationTotalTime.Minutes, configurationTotalTime.Seconds, configurationTotalTime.Milliseconds / 10, codeTotalTime.Minutes, codeTotalTime.Seconds, codeTotalTime.Milliseconds / 10);
        }

        private static void WriteExportEngineElapsedTime(TimeSpan ts1, TimeSpan ts2, TimeSpan ts3, TimeSpan ts4, TimeSpan ts5, TimeSpan ts6, TimeSpan ts7, TimeSpan ts8, TimeSpan ts9, TimeSpan ts10, TimeSpan ts11, TimeSpan ts12)
        {
            var configurationTotalTime = ts1 + ts2 + ts3 + ts4 + ts5 + ts6 + ts7 + ts8 + ts9 + ts10 + ts11 + ts12;

            Console.WriteLine();
            Console.WriteLine(@"                        Elapsed Time");
            Console.WriteLine(@"                ---------------------------");
            Console.WriteLine(@" ExportEngine   From                From");
            Console.WriteLine(@" Summary        Configuration       Code");
            Console.WriteLine(new string('=', 46));
            Console.WriteLine(@" Sample1        {0:00}:{1:00}.{2:00}", ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10, ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            Console.WriteLine(@" Sample2        {0:00}:{1:00}.{2:00}", ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
            Console.WriteLine(@" Sample3        {0:00}:{1:00}.{2:00}", ts3.Minutes, ts3.Seconds, ts3.Milliseconds / 10, ts3.Minutes, ts3.Seconds, ts3.Milliseconds / 10);
            Console.WriteLine(@" Sample4        {0:00}:{1:00}.{2:00}", ts4.Minutes, ts4.Seconds, ts4.Milliseconds / 10, ts4.Minutes, ts4.Seconds, ts4.Milliseconds / 10);
            Console.WriteLine(@" Sample5        {0:00}:{1:00}.{2:00}", ts5.Minutes, ts5.Seconds, ts5.Milliseconds / 10, ts5.Minutes, ts5.Seconds, ts5.Milliseconds / 10);
            Console.WriteLine(@" Sample6        {0:00}:{1:00}.{2:00}", ts6.Minutes, ts6.Seconds, ts6.Milliseconds / 10, ts6.Minutes, ts6.Seconds, ts6.Milliseconds / 10);
            Console.WriteLine(@" Sample7        {0:00}:{1:00}.{2:00}", ts7.Minutes, ts7.Seconds, ts7.Milliseconds / 10, ts7.Minutes, ts7.Seconds, ts7.Milliseconds / 10);
            Console.WriteLine(@" Sample8        {0:00}:{1:00}.{2:00}", ts8.Minutes, ts8.Seconds, ts8.Milliseconds / 10, ts8.Minutes, ts8.Seconds, ts8.Milliseconds / 10);
            Console.WriteLine(@" Sample9        {0:00}:{1:00}.{2:00}", ts9.Minutes, ts9.Seconds, ts9.Milliseconds / 10, ts9.Minutes, ts9.Seconds, ts9.Milliseconds / 10);
            Console.WriteLine(@" Sample10       {0:00}:{1:00}.{2:00}", ts10.Minutes, ts10.Seconds, ts10.Milliseconds / 10, ts10.Minutes, ts10.Seconds, ts10.Milliseconds / 10);
            Console.WriteLine(@" Sample11       {0:00}:{1:00}.{2:00}", ts11.Minutes, ts11.Seconds, ts11.Milliseconds / 10, ts11.Minutes, ts11.Seconds, ts11.Milliseconds / 10);
            Console.WriteLine(@" Sample12       {0:00}:{1:00}.{2:00}", ts12.Minutes, ts12.Seconds, ts12.Milliseconds / 10, ts12.Minutes, ts12.Seconds, ts12.Milliseconds / 10);
            Console.WriteLine(new string('-', 46));
            Console.WriteLine(@"                {0:00}:{1:00}.{2:00}", configurationTotalTime.Minutes, configurationTotalTime.Seconds, configurationTotalTime.Milliseconds / 10);
            Console.WriteLine();
        }
    }
}
