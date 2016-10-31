using System;
using System.Diagnostics;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    class Program
    {
        private const string LastStepText = " Finished without errors. Press any key...";

        private static readonly Stopwatch Watch = new Stopwatch();

        private static TimeSpan _xmlTime;
        private static TimeSpan _datasetTime;
        private static TimeSpan _arraylistTime;
        private static TimeSpan _enumerableTime;

        static void Main(string[] args)
        {
            Watch.Start();
            InvoiceXmlSample.RunSample();
            _xmlTime = Watch.Elapsed;
            Watch.Stop();

            Console.WriteLine();

            Watch.Reset();
            Watch.Start();
            InvoiceArrayListSample.RunSample();
            _arraylistTime = Watch.Elapsed;
            Watch.Stop();

            Console.WriteLine();

            Watch.Reset();
            Watch.Start();
            InvoiceDataSetSample.RunSample();
            _datasetTime = Watch.Elapsed;
            Watch.Stop();

            Console.WriteLine();

            Watch.Reset();
            Watch.Start();
            InvoiceEnumerableSample.RunSample();
            _enumerableTime = Watch.Elapsed;
            Watch.Stop();

            WriteElapsedTime(_xmlTime, _arraylistTime, _datasetTime, _enumerableTime);
            Console.WriteLine(LastStepText);
            Console.ReadKey();
        }

        private static void WriteElapsedTime(TimeSpan ts1, TimeSpan ts2, TimeSpan ts3, TimeSpan ts4)
        {
            var totalTime = ts1 + ts2 + ts3 + ts4;
            Console.WriteLine();
            Console.WriteLine(@"					Elapsed Time");
            Console.WriteLine(new string('=', 52));
            Console.WriteLine(@" 1 - Xml				{0:00}:{1:00}.{2:00}", ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            Console.WriteLine(@" 2 - ArrayList				{0:00}:{1:00}.{2:00}", ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
            Console.WriteLine(@" 3 - DataSet				{0:00}:{1:00}.{2:00}", ts3.Minutes, ts3.Seconds, ts3.Milliseconds / 10);
            Console.WriteLine(@" 4 - Enumerable				{0:00}:{1:00}.{2:00}", ts4.Minutes, ts4.Seconds, ts4.Milliseconds / 10);
            Console.WriteLine(new string('-', 52));
            Console.WriteLine(@"					{0:00}:{1:00}.{2:00}", totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds / 10);
            Console.WriteLine(new string('=', 52));
            Console.WriteLine();
        }
    }
}
