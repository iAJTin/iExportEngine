
namespace iTinExportEngineSamples
{
    using System;
    using System.Diagnostics;

    class Program
    {
        private const string LastStepText = " Finished without errors. Press any key...";

        private static readonly Stopwatch Watch = new Stopwatch();

        private static TimeSpan sample01Time;
        private static TimeSpan sample05Time;
        private static TimeSpan sample09Time;

        static void Main(string[] args)
        {
            // Sample 1 - Simply creates a new workbook from scratch. The workbook contains one worksheet with a simple invertory list.
            Watch.Start();
            Sample01.RunFromConfigurationFileSample();
            sample01Time = Watch.Elapsed;
            Watch.Stop();

            // Sample 5 - Equals to Sample 1 and add 2 new rows and a Piechart.
            Watch.Start();
            Console.WriteLine();
            Sample05.RunFromConfigurationFileSample();
            sample05Time = Watch.Elapsed;
            Watch.Stop();

            // Sample 9 - Use charts with more than one charttype and secondary axis.
            Watch.Start();
            Console.WriteLine();
            Sample09.RunFromConfigurationFileSample();
            sample09Time = Watch.Elapsed;
            Watch.Stop();

            // Writes output
            WriteElapsedTime(sample01Time, sample05Time, sample09Time);
            Console.WriteLine(LastStepText);
            Console.ReadKey();
        }

        private static void WriteElapsedTime(TimeSpan ts1, TimeSpan ts2, TimeSpan ts3)
        {
            var totalTime = ts1 + ts2 + ts3;

            Console.WriteLine();
            Console.WriteLine(@" Summary");
            Console.WriteLine(@" From Configuration File	Elapsed Time");
            Console.WriteLine(new string('=', 45));
            Console.WriteLine(@" Sample1                            {0:00}:{1:00}.{2:00}", ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            Console.WriteLine(@" Sample5                            {0:00}:{1:00}.{2:00}", ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
            Console.WriteLine(@" Sample9                            {0:00}:{1:00}.{2:00}", ts3.Minutes, ts3.Seconds, ts3.Milliseconds / 10);
            Console.WriteLine(new string('-', 45));
            Console.WriteLine(@"                                    {0:00}:{1:00}.{2:00}", totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds / 10);
            Console.WriteLine();
        }
    }
}
