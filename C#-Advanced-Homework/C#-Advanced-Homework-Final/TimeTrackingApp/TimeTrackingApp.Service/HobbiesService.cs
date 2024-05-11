using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Domain.Tracking;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class HobbiesService : IHobbies
    {
        public void HobbiesTrack(User user)
        {
            Console.Clear();
            ConsoleHelper.PrintInColor("Track Hobbies", ConsoleColor.Blue);
            ConsoleHelper.PrintInColor($"Select type of hobbie: \n1.{HobbiesRole.Football}\n2.{HobbiesRole.VideoGame}\n3.{HobbiesRole.Basketball}", ConsoleColor.Blue);
            HobbiesRole otherHobbiesRole = new HobbiesRole();
            string choiceInput = Console.ReadLine();
            TimeActivity timeActivity = new TimeActivity();
            if (choiceInput == "1")
            {
                otherHobbiesRole = HobbiesRole.Football;
            }
            else if (choiceInput == "2")
            {
                otherHobbiesRole = HobbiesRole.VideoGame;
            }
            else if (choiceInput == "3")
            {
                otherHobbiesRole = HobbiesRole.Basketball;
            }
            else
            {
                ConsoleHelper.PrintError("ENTER VALID KEY!");
            }
            Hobbies activity = new(otherHobbiesRole);
            activity.TimeSpentOnActivity = timeActivity.Time();
            user.Hobbies.Add(activity);
            FileDB<User> fileDB = new FileDB<User>();
            fileDB.Update(user);
        }
    }
}
