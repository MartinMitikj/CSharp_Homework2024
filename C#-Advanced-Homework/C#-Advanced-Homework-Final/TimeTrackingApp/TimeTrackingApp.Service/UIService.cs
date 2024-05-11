using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class UIService<T> : IUIService<T> where T : BaseEntity
    {
        public void AccountManagement(User user)
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("1.Change password\n2.Change First Name\n3.Change Last Name\n4.Deactivate account\n5.Back to Menu", ConsoleColor.Blue);
                string choiceInput = Console.ReadLine();
                UserService userService = new UserService();
                if (choiceInput == "1")
                {
                    userService.ChangePassword();
                }
                else if (choiceInput == "2")
                {
                    userService.ChangeFirstName();

                }
                else if (choiceInput == "3")
                {
                    userService.ChangeLastName();
                }
                else if (choiceInput == "4")
                {
                    userService.DeactivateAccount(user);
                }
                else if (choiceInput == "5")
                {
                    BackToMainMenu(user);
                }
                else
                {
                    ConsoleHelper.PrintError("ENTER A VALID KEY!");
                }
            }
        }

        public void BackToMainMenu(User user)
        {
            MainMenu(user);
        }

        public void EndMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n              *** THANK YOU FOR USING OUR APP ***");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void MainMenu(User user)
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("1.AccountManagement ", ConsoleColor.Blue);
                ConsoleHelper.PrintInColor("2.Track Activity ", ConsoleColor.Blue);
                ConsoleHelper.PrintInColor("3.User Statistics ", ConsoleColor.Blue);
                ConsoleHelper.PrintInColor("4.LogOut", ConsoleColor.Blue);
                string choiceInput = Console.ReadLine();
                if (choiceInput == "1")
                {
                    AccountManagement(user);
                }
                else if (choiceInput == "2")
                {
                    Track(user);
                }
                else if (choiceInput == "3")
                {
                    UserStatistics(user);
                }
                else if (choiceInput == "4")
                {
                    StartMenu();
                }
                else
                {
                    ConsoleHelper.PrintError("ENTER A VALID KEY!");
                }
            }
        }

        public void StartMenu()
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("Welcome to Time Tracking App!", ConsoleColor.DarkCyan);
                ConsoleHelper.PrintInColor("1. Login");
                ConsoleHelper.PrintInColor("2. Register");
                ConsoleHelper.PrintInColor("3. Exit");
                string choiceInput = Console.ReadLine();
                UserService userService = new UserService();
                if (choiceInput == "1")
                {
                    userService.Login();
                    break;
                }
                else if (choiceInput == "2")
                {
                    userService.Register();
                }
                else if (choiceInput == "3")
                {
                    EndMenu();
                }
                else
                {
                    ConsoleHelper.PrintError("ENTER A VALID KEY!");
                }
            }
        }

        public void Track(User user)
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("1.Reading\n2.Exercising\n3.Working\n4.Other Hobbies\n5.Back to User Menu", ConsoleColor.Blue);
                string choiceInput = Console.ReadLine();
                ReadingService readingService = new ReadingService();
                ExercisingService exercisingService = new ExercisingService();
                WorkingService workingService = new WorkingService();
                HobbiesService hobbiesService = new HobbiesService();
                if (choiceInput == "1")
                {
                    readingService.TrackReading(user);
                }
                else if (choiceInput == "2")
                {
                    exercisingService.ExercisingTrack(user);
                }
                else if (choiceInput == "3")
                {
                    workingService.WorkingTrack(user);
                }
                else if (choiceInput == "4")
                {
                    hobbiesService.HobbiesTrack(user);
                }
                else if (choiceInput == "5")
                {
                    BackToMainMenu(user);
                }
                else
                {
                    ConsoleHelper.PrintError("ENTER A VALID KEY!");
                }
            }
        }

        public void UserStatistics(User user)
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("1.Reading Stats\n2.Exercising Stats\n3.Working Stats\n4.Hobbies Stats\n5.Global Stats\n6.Back to User Menu", ConsoleColor.Blue);
                string choiceInput = Console.ReadLine();
                Stats stats = new();
                if (choiceInput == "1")
                {
                    stats.ReadingStats(user);
                }
                else if (choiceInput == "2")
                {
                    stats.ExercisingStats(user);
                }
                else if (choiceInput == "3")
                {
                    stats.WorkingStats(user);
                }
                else if (choiceInput == "4")
                {
                    stats.HobbiesStats(user);
                }
                else if (choiceInput == "5")
                {
                    stats.GlobalStats(user);
                }
                else if (choiceInput == "6")
                {
                    BackToMainMenu(user);
                }
                else
                {
                    ConsoleHelper.PrintError("ENTER VALID KEY!");
                }
            }
        }
    }
}
