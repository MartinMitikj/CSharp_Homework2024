using System.Diagnostics;
using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Domain.Tracking;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class Stats : IStats
    {
        public Dictionary<Activities, double> TotalTime(User user)
        {
            Dictionary<Activities, double> totalTimeActivites = new()
            {
                { Activities.Reading, user.Reading.Sum(x => x.TimeSpentOnActivity) },
                { Activities.Exercising, user.Exercising.Sum(x => x.TimeSpentOnActivity) },
                { Activities.Working, user.Working.Sum(x => x.TimeSpentOnActivity) },
                { Activities.Hobbies, user.Hobbies.Sum(x => x.TimeSpentOnActivity) }
            };

            return totalTimeActivites;
        }

        public Dictionary<Activities, double> AverageTime(User user)
        {
            double reading = user.Reading.Any() ? user.Reading.Average(x => x.TimeSpentOnActivity) : 0;
            double exercising = user.Exercising.Any() ? user.Exercising.Average(x => x.TimeSpentOnActivity) : 0;
            double working = user.Working.Any() ? user.Working.Average(x => x.TimeSpentOnActivity) : 0;
            double hobbies = user.Hobbies.Any() ? user.Hobbies.Average(x => x.TimeSpentOnActivity) : 0;
            Dictionary<Activities, double> averageTimeActivites = new()
            {
                { Activities.Reading, reading },
                { Activities.Exercising, exercising },
                { Activities.Working, working },
                { Activities.Hobbies, hobbies }
            };

            return averageTimeActivites;
        }

        public void FavoriteAvtivity(User user)
        {
            var activities = TotalTime(user);
            double bestTime = activities.Select(x => x.Value).Max();
            var activity = activities.FirstOrDefault(x => x.Value == bestTime);
            Console.WriteLine(activity);
        }

        public void ReadingStats(User user)
        {
            var activities = TotalTime(user);
            double totalTime = 0;
            double averageTime = 0;
            if (activities.TryGetValue(Activities.Reading, out double totalTimeReading))
            {
                totalTime = totalTimeReading;
            }
            var activitiesAverage = AverageTime(user);
            if (activitiesAverage.TryGetValue(Activities.Reading, out double averageTimeReading))
            {
                averageTime = averageTimeReading;
            }
            int totalPages = user.Reading.Sum(x => x.Pages);
            var favoriteGanre = user.Reading.GroupBy(r => r.Type).MaxBy(g => g.Count()).FirstOrDefault();

            Console.Clear();
            ConsoleHelper.PrintInColor("Reading Stats", ConsoleColor.DarkCyan);
            ConsoleHelper.PrintInColor($"Total time spent on reading {totalTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Average time spent on reading {averageTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Total pages readed: {totalPages}.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Favorite ganre: {favoriteGanre.Type}.", ConsoleColor.Blue);
            Console.ReadLine();
            UIService<User> uIService = new();
            uIService.UserStatistics(user);
        }
        public void ExercisingStats(User user)
        {
            var activities = TotalTime(user);
            double totalTime = 0;
            double averageTime = 0;
            if (activities.TryGetValue(Activities.Exercising, out double totalTimeReading))
            {
                totalTime = totalTimeReading;
            }
            var activitiesAverage = AverageTime(user);
            if (activitiesAverage.TryGetValue(Activities.Exercising, out double averageTimeReading))
            {
                averageTime = averageTimeReading;
            }
            var favoriteGanre = user.Exercising.GroupBy(r => r.Type).MaxBy(g => g.Count()).FirstOrDefault();
            Console.Clear();
            ConsoleHelper.PrintInColor("Exercising Stats", ConsoleColor.DarkCyan);
            ConsoleHelper.PrintInColor($"Total time spent on reading {totalTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Average time spent on reading {averageTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Favorite ganre: {favoriteGanre.Type}.", ConsoleColor.Blue);
            Console.ReadLine();
            UIService<User> uIService = new();
            uIService.UserStatistics(user);
        }

        public void WorkingStats(User user)
        {
            Console.Clear();
            var activities = TotalTime(user);
            double totalTime = 0;
            double averageTime = 0;
            if (activities.TryGetValue(Activities.Working, out double totalTimeReading))
            {
                totalTime = totalTimeReading;
            }
            var activitiesAverage = AverageTime(user);
            if (activitiesAverage.TryGetValue(Activities.Working, out double averageTimeReading))
            {
                averageTime = averageTimeReading;
            }
            var workingHome = user.Working.Where(x => x.Type == WorkingRole.Home).Sum(x => x.TimeSpentOnActivity);
            var workingOffice = user.Working.Where(x => x.Type == WorkingRole.Office).Sum(x => x.TimeSpentOnActivity);
            ConsoleHelper.PrintInColor("Working Stats", ConsoleColor.DarkCyan);
            ConsoleHelper.PrintInColor($"Total time spent on reading {totalTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Average time spent on reading {averageTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Home: {workingHome:0.0} VS Office: {workingOffice:0.0}", ConsoleColor.Blue);
            Console.ReadLine();
            UIService<User> uIService = new();
            uIService.UserStatistics(user);
        }

        public void HobbiesStats(User user)
        {
            Console.Clear();
            var total = TotalTime(user);
            double totalTime = 0;
            if (total.TryGetValue(Activities.Hobbies, out double totalTimeReading))
            {
                totalTime = totalTimeReading;
            }
            ConsoleHelper.PrintInColor("Hobbies Stats", ConsoleColor.DarkCyan);
            ConsoleHelper.PrintInColor($"Total time spent on reading {totalTime:0.0} minutes.", ConsoleColor.Blue);
            foreach (var hobby in user.Hobbies)
            {
                ConsoleHelper.PrintInColor(hobby.Type.ToString(), ConsoleColor.Blue);
            }
            Console.ReadLine();
            UIService<User> uIService = new();
            uIService.UserStatistics(user);

        }

        public void GlobalStats(User user)
        {
            var totalTime = TotalTime(user);
            var globalTime = totalTime.Values.Sum();
            var activities = TotalTime(user);
            double bestTime = activities.Select(x => x.Value).Max();
            var activity = activities.FirstOrDefault(x => x.Value == bestTime);
            Console.Clear();
            ConsoleHelper.PrintInColor($"Total time spent on all tracking {globalTime:0.0} minutes.", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Favorite activity: {activity}", ConsoleColor.Blue);
            Console.ReadLine();
            UIService<User> uIService = new();
            uIService.UserStatistics(user);
        }








    }

}

