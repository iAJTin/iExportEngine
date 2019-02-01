
namespace iTinExportEngineSamples
{
    using System;
    using System.Diagnostics;

    using EPPlusSamples;

    class Program
    {
        private const string LastStepText = " Finished Without Errors. Press Any Key...";

        private static readonly Stopwatch Watch = new Stopwatch();

        private static TimeSpan sample01Time;
        private static TimeSpan sample02Time;
        private static TimeSpan sample03Time;
        private static TimeSpan sample04Time;
        private static TimeSpan sample05Time;
        private static TimeSpan sample06Time;
        private static TimeSpan sample07Time;
        private static TimeSpan sample01CodeTime;

        static void Main(string[] args)
        {
            #region EPPlus Samples

            #region Sample 1 - Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List
            // From configuration File 
            Watch.Start();
            EPPlusSample01.RunFromConfigurationFileSample();
            sample01Time = Watch.Elapsed;
            Watch.Stop();

            // From code
            Watch.Start();
            Console.WriteLine();
            EPPlusSample01FromCode.RunFromCodeSample();
            sample01CodeTime = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #region Sample 2 - Equals To Sample 1 And Adds 2 New Rows And A Piechart
            Watch.Start();
            Console.WriteLine();
            EPPlusSample02.RunFromConfigurationFileSample();
            sample02Time = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #region Sample 3 - Use stacked charts
            Watch.Start();
            Console.WriteLine();
            EPPlusSample03.RunFromConfigurationFileSample();
            sample03Time = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #region Sample 4 - Use Charts With More Than One Chart Type And Secondary Axis
            Watch.Start();
            Console.WriteLine();
            EPPlusSample04.RunFromConfigurationFileSample();
            sample04Time = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #region Sample 5 - Use Pivot Tables
            Watch.Start();
            Console.WriteLine();
            EPPlusSample05.RunFromConfigurationFileSample();
            sample05Time = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #region Sample 6 - Use Mini Charts
            Watch.Start();
            Console.WriteLine();
            EPPlusSample06.RunFromConfigurationFileSample();
            sample06Time = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #region Sample 7 - Creates A New Workbook From Custom Enumerated Data Type
            Watch.Start();
            Console.WriteLine();
            EPPlusSample07.RunFromCodeSample(1000);
            sample07Time = Watch.Elapsed;
            Watch.Stop();
            #endregion

            #endregion

            #region iTinExportEngine Samples
            #endregion

            #region Writes Output
            WriteElapsedTime(sample01Time, sample01CodeTime, sample02Time, sample03Time, sample04Time, sample05Time, sample06Time, sample07Time);
            Console.WriteLine(LastStepText);
            Console.ReadKey();
            #endregion
        }

        private static void WriteElapsedTime(TimeSpan ts1, TimeSpan ts1c, TimeSpan ts2, TimeSpan ts3, TimeSpan ts4, TimeSpan ts5, TimeSpan ts6, TimeSpan ts7)
        {
            var configurationTotalTime = ts1 + ts2 + ts3 + ts4 + ts5 + ts6 + ts7;
            var codeTotalTime = ts1c;

            Console.WriteLine();
            Console.WriteLine(@"                        Elapsed Time");
            Console.WriteLine(@"            From Configuration      From Code");
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
            Console.WriteLine();
        }
    }
}
