using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Domain.Tracking;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class WorkingService : IWorking
    {
        public void WorkingTrack(User user)
        {
            Console.Clear();
            ConsoleHelper.PrintInColor("Track Working", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Select Place of Working: \n1.{WorkingRole.Office}\n2.{WorkingRole.Home}", ConsoleColor.Blue);
            WorkingRole workingRole = new WorkingRole();
            string choiceInput = Console.ReadLine();
            TimeActivity timeActivity = new TimeActivity();
            if (choiceInput == "1")
            {
                workingRole = WorkingRole.Office;
            }
            else if (choiceInput == "2")
            {
                workingRole = WorkingRole.Home;
            }
            else
            {
                ConsoleHelper.PrintError("ENTER VALID KEY!");
            }
            Working activity = new(workingRole);
            activity.TimeSpentOnActivity = timeActivity.Time();
            user.Working.Add(activity);
            FileDB<User> fileDB = new FileDB<User>();
            fileDB.Update(user);
        }
    }
}
