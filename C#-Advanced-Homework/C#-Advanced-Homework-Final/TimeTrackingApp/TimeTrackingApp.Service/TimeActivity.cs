using System.Diagnostics;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class TimeActivity : ITime
    {
        public double Time()
        {
            Stopwatch stopwatch = new Stopwatch();
            ConsoleHelper.PrintSuccess($"Activity started at {DateTime.Now.TimeOfDay}");
            while (true)
            {
                stopwatch.Start();
                ConsoleHelper.PrintInColor("Press Enter to stop tracking...",ConsoleColor.Blue);
                Console.ReadLine();
                stopwatch.Stop();
                break;
            }
            ConsoleHelper.PrintSuccess($"Activity finished at {DateTime.Now.TimeOfDay}");
            double totalTime = stopwatch.Elapsed.TotalMinutes;
            ConsoleHelper.PrintSuccess($"Total time {totalTime} minutes");
            return totalTime;
        }
    }
}
