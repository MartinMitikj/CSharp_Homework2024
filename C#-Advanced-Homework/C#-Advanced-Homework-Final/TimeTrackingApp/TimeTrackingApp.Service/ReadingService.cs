using Newtonsoft.Json;
using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Domain.Tracking;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class ReadingService : IReading
    {

        public void TrackReading(User user)
        {
            Console.Clear();
            ConsoleHelper.PrintInColor("Track Reading", ConsoleColor.Blue);
            int pages = BookPages();
            ReadingRole bookGanre = Book();
            Reading activity = new(pages, bookGanre);
            TimeActivity timeActivity = new TimeActivity();
            activity.TimeSpentOnActivity = timeActivity.Time();
            user.Reading.Add(activity);
            FileDB<User> fileDB = new FileDB<User>();
            fileDB.Update(user);
        }
        public int BookPages()
        {
            while (true)
            {
                while (true)
                {
                    ConsoleHelper.PrintInColor("Enter number of Pages", ConsoleColor.Blue);
                    string inputPages = Console.ReadLine();
                    bool isValid = int.TryParse(inputPages, out int pages);
                    if (string.IsNullOrWhiteSpace(inputPages))
                    {
                        ConsoleHelper.PrintError("ENTER VALUE!");
                    }
                    if (!isValid || pages < 0 || pages > 10000)
                    {
                        ConsoleHelper.PrintError("ENTER VALID NUMBER!");
                    }
                    return pages;
                }
            }
        }
        public ReadingRole Book()
        {
            ReadingRole book = new ReadingRole();
            ConsoleHelper.PrintInColor("Select book genre", ConsoleColor.DarkCyan);
            ConsoleHelper.PrintInColor($"1.{ReadingRole.BellesLettres}\n2.{ReadingRole.Fiction}\n3.{ReadingRole.ProfessionalLiterature}");
            string choiceInput = Console.ReadLine();
            if (choiceInput == "1")
            {
                book = ReadingRole.BellesLettres;
            }
            else if (choiceInput == "2")
            {
                book = ReadingRole.Fiction;
            }
            else if (choiceInput == "3")
            {
                book = ReadingRole.ProfessionalLiterature;
            }
            else
            {
                ConsoleHelper.PrintError("ENTER VALID KEY!");
            }
            return book;
        }
    }
}
