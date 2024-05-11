using Newtonsoft.Json;
using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Domain.Tracking;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class ExercisingService : IExercising
    {
        public void ExercisingTrack(User user)
        {
            Console.Clear();
            ConsoleHelper.PrintInColor("Track Exercising", ConsoleColor.DarkCyan);
            ConsoleHelper.PrintInColor($"Select Type of Exercising: \n1.{ExercisingRole.General}\n2.{ExercisingRole.Running}\n3.{ExercisingRole.Sport}", ConsoleColor.Blue);
            ExercisingRole exercisingRole = new ExercisingRole();
            string choiceInput = Console.ReadLine();
            if (choiceInput == "1")
            {
                exercisingRole = ExercisingRole.General;
            }
            else if (choiceInput == "2")
            {
                exercisingRole = ExercisingRole.Running;
            }
            else if (choiceInput == "3")
            {
                exercisingRole = ExercisingRole.Running;
            }
            else
            {
                ConsoleHelper.PrintError("ENTER VALID KEY!");
            }
            Exercising activity = new(exercisingRole);
            TimeActivity timeActivity = new TimeActivity();
            activity.TimeSpentOnActivity = timeActivity.Time();
            user.Exercising.Add(activity);
            FileDB<User> userDb = new FileDB<User>();
            userDb.Update(user);
        }
    }
}
