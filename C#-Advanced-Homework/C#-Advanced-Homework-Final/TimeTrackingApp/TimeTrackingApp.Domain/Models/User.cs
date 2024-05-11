using TimeTrackingApp.Domain.Tracking;
namespace TimeTrackingApp.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Reading> Reading { get; set; } = new List<Reading> { };
        public List<Exercising> Exercising { get; set; } = new List<Exercising>();
        public List<Working> Working { get; set; } = new List<Working>();
        public List<Hobbies> Hobbies { get; set; } = new List<Hobbies>();

        public User() { }

        public User(string firstName, string lastName, int age, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Id} {FirstName} {LastName} has {Age} years old. Username: {Username} Password: {Password}");
        }

    }
}
