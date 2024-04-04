

using Domain.Interface;

namespace Domain.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public User(int id, string name, string username)
        {
            Id = id;
            Name = name;
            Username = username;
        }
        public virtual void PrintUser()
        {
            Console.WriteLine($"Id:{Id} Name: {Name} Username: {Username}");
        }
    }
}
