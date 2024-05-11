using System.Data;
using System.Linq;
using TimeTrackingApp.DataAccess;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Helpers;
using TimeTrackingApp.Service.Interfaces;

namespace TimeTrackingApp.Service
{
    public class UserService : ServiceBase<User>, IUser
    {
        public User CurrentUser { get; set; }

        public void ChangeFirstName()
        {
            while (true)
            {
                Console.Clear();
                FileDB<User> userDb = new FileDB<User>();
                List<User> users = userDb.GetAll();
                string newFirstName = FirstName();
                if (users.Any(u => u.FirstName == newFirstName))
                {
                    ConsoleHelper.PrintError("ENTERED THE SAME NAME!");
                    continue;
                }
                User currentUser = users.FirstOrDefault();
                currentUser.FirstName = newFirstName;
                userDb.Update(currentUser);

                ConsoleHelper.PrintSuccess("Successfully changed the First Name");
                break;
            }
        }


        public void ChangeLastName()
        {
            while (true)
            {
                Console.Clear();
                FileDB<User> userDb = new FileDB<User>();
                List<User> users = userDb.GetAll();
                string newLastName = LastName();
                if (users.Any(u => u.LastName == newLastName))
                {
                    ConsoleHelper.PrintError("ENTERED THE SAME NAME!");
                    continue;
                }
                User currentUser = users.FirstOrDefault();
                currentUser.LastName = newLastName;
                userDb.Update(currentUser);

                ConsoleHelper.PrintSuccess("Successfully changed the First Name");
                break;
            }
        }
        public bool ChangePassword()
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("Enter Old Password: ", ConsoleColor.Blue);
                string oldPassword = Console.ReadLine();
                string newPassword = Password();
                FileDB<User> fileDB = new FileDB<User>();
                if (!fileDB.GetAll().Any(u => u.Password == oldPassword))
                {
                    ConsoleHelper.PrintError("ENTER VALID PASSWORD");
                    continue;
                }
                else if (oldPassword == newPassword)
                {
                    ConsoleHelper.PrintError("PLEASE ENTER DIFFRENT PASSWORD!");
                }
                else
                {
                    try
                    {
                        FileDB<User> userDb = new FileDB<User>();
                        User userToUpdate = userDb.GetAll().FirstOrDefault(u => u.Password == oldPassword);
                        userToUpdate.Password = newPassword;
                        bool updated = userDb.Update(userToUpdate);
                        if (updated)
                        {
                            ConsoleHelper.PrintSuccess("Password updated successfully");
                        }
                        else
                        {
                            ConsoleHelper.PrintError("Failed to update password");
                        }
                        return updated;
                    }
                    catch (Exception ex)
                    {
                        ConsoleHelper.PrintError($"An error occurred: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public void DeactivateAccount(User user)
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("Are you sure you want to Deactivate your accout", ConsoleColor.Blue);
                ConsoleHelper.PrintInColor("1.Deactivate\n2.Exit", ConsoleColor.Blue);
                string choiceInput = Console.ReadLine();
                UIService<User> uIService = new UIService<User>();
                FileDB<User> userDb = new FileDB<User>();
                if (choiceInput == "1")
                {
                    userDb.RemoveById(user.Id);
                    ConsoleHelper.PrintSuccess("Your account has been deactivated successfully.");
                    uIService.StartMenu();
                }
                else if (choiceInput == "2")
                {
                    uIService.AccountManagement(user);
                }
                else
                {
                    ConsoleHelper.PrintError("ENTER A VALID KEY!");
                }
            }
        }

        public User Login()
        {
            int attempts = 0;
            while (attempts < 3)
            {
                Console.Clear();
                ConsoleHelper.PrintInColor("Enter your username: ", ConsoleColor.Blue);
                string username = Console.ReadLine();
                ConsoleHelper.PrintInColor("Enter your password: ", ConsoleColor.Blue);
                string password = Console.ReadLine();
                FileDB<User> users = new FileDB<User>();
                User userDb = GetAll().SingleOrDefault(u => u.Username == username && u.Password == password);
                if (userDb is null)
                {
                    ConsoleHelper.PrintError("ENTER VALID USERNAME OR PASSWORD!");
                    attempts++;
                    continue;
                }
                else
                {
                    Console.Clear();
                    CurrentUser = userDb;
                    ConsoleHelper.PrintSuccess($"WELCOME! {CurrentUser.FirstName} {CurrentUser.LastName}");
                    Console.Clear();
                    UIService<User> uIService = new UIService<User>();
                    uIService.MainMenu(CurrentUser);
                    return new User
                    {
                        Username = username,
                        Password = password
                    };
                }
            }
            Console.Clear();
            ConsoleHelper.PrintError("You have exceeded the maximum number of login attempts. Goodbye!");
            Environment.Exit(0);
            return null;
        }

        public void Register()
        {
            Console.Clear();
            Console.WriteLine("======= INSERT NEW USER =======");

            string firstName = FirstName();
            string lastName = LastName();
            int age = Age();
            string username = Username();
            string password = Password();

            User newUser = new User(firstName, lastName, age, username, password);
            FileDB<User> userDB = new FileDB<User>();
            userDB.Add(newUser);
            ConsoleHelper.PrintSuccess("Successfully created a new User!");
        }

        public string FirstName()
        {
            while (true)
            {
                ConsoleHelper.PrintInColor("Enter First Name: ", ConsoleColor.Blue);
                string firstName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    ConsoleHelper.PrintError("ENTER A VALUE!");
                    continue;
                }
                if (firstName.Any(char.IsDigit))
                {
                    ConsoleHelper.PrintError("SHOULDN'T HAVE NUMBERS IN NAME!");
                    continue;
                }
                if (firstName.Length < 2)
                {
                    ConsoleHelper.PrintError("MUST CONTAIN AT MIN 2 LETTERS!");
                    continue;
                }
                return firstName;
            }
        }
        public string LastName()
        {
            while (true)
            {
                ConsoleHelper.PrintInColor("Enter Last Name: ", ConsoleColor.Blue);
                string lastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    ConsoleHelper.PrintError("ENTER A VALUE!");
                    continue;
                }
                if (lastName.Any(char.IsDigit))
                {
                    ConsoleHelper.PrintError("SHOULDN'T HAVE NUMBERS IN NAME!");
                    continue;
                }
                if (lastName.Length < 2)
                {
                    ConsoleHelper.PrintError("MUST CONTAIN AT MIN 2 LETTERS!");
                    continue;
                }
                return lastName;
            }
        }
        public int Age()
        {
            while (true)
            {
                ConsoleHelper.PrintInColor("Enter Age: ", ConsoleColor.Blue);
                string ageInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ageInput))
                {
                    ConsoleHelper.PrintError("ENTER A VALUE!");
                    continue;
                }
                if (!int.TryParse(ageInput, out int age) || age < 18 || age > 120)
                {
                    ConsoleHelper.PrintError("AGE LIMIT IS FROM 18 TO 120 YEARS!");
                    continue;
                }
                return age;
            }
        }
        public string Username()
        {
            while (true)
            {
                ConsoleHelper.PrintInColor("Enter Username: ", ConsoleColor.Blue);
                string username = Console.ReadLine();
                FileDB<User> users = new FileDB<User>();
                if (string.IsNullOrWhiteSpace(username))
                {
                    ConsoleHelper.PrintError("ENTER A VALUE!");
                    continue;
                }
                if (username.Length < 5)
                {
                    ConsoleHelper.PrintError("USERNAME MUST HAVE MIN 5 CHARACTERS!");
                    continue;
                }
                if (users.GetAll().Any(u => u.Username == username))
                {
                    ConsoleHelper.PrintError("USERNAME ALREADY TAKEN!");
                    continue;
                }
                return username;
            }
        }

        public string Password()
        {
            while (true)
            {
                ConsoleHelper.PrintInColor("Enter new Password: ", ConsoleColor.Blue);
                string password = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(password))
                {
                    ConsoleHelper.PrintError("ENTER A VALUE!");
                    continue;
                }
                if (password.Length < 6)
                {
                    ConsoleHelper.PrintError("PASSWORD MUST HAVE MIN 6 CHARACTERS!");
                    continue;
                }
                if (!password.Any(char.IsDigit))
                {
                    ConsoleHelper.PrintError("MUST CONTAIN NUMBER!");
                    continue;
                }
                if (!password.Any(char.IsUpper))
                {
                    ConsoleHelper.PrintError("MUST CONTAIN UPPERCASED LETTER!");
                    continue;
                }
                return password;
            }
        }
    }
}
