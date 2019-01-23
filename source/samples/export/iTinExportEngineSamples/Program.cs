
namespace iTinExportEngineSamples
{
    using System;
    using System.Diagnostics;

    class Program
    {
        private const string LastStepText = " Finished without errors. Press any key...";

        private static readonly Stopwatch Watch = new Stopwatch();

        private static TimeSpan _sample9XTime;

        static void Main(string[] args)
        {
            Watch.Start();
            // Sample 1 - simply creates a new workbook from scratch
            // containing a worksheet that adds a few numbers together 
            Sample01.RunFromConfigurationFileSample();
            _sample9XTime = Watch.Elapsed;
            Watch.Stop();

            WriteElapsedTime(_sample9XTime);
            Console.WriteLine(LastStepText);
            Console.ReadKey();
        }

        private static void WriteElapsedTime(TimeSpan ts1)
        {
            var totalTime = ts1;
            Console.WriteLine();
            Console.WriteLine(@"					Elapsed Time");
            Console.WriteLine(new string('=', 52));
            Console.WriteLine(@" Samples 9x				{0:00}:{1:00}.{2:00}", ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            Console.WriteLine(new string('-', 52));
            Console.WriteLine(@"					{0:00}:{1:00}.{2:00}", totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds / 10);
            Console.WriteLine(new string('=', 52));
            Console.WriteLine();
        }
    }
}
