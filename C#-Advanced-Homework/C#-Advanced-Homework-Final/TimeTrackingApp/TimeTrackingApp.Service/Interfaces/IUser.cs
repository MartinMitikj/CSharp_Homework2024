using System.Data;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Service.Interfaces
{
    public interface IUser : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        User Login();
        void Register();
        bool ChangePassword();
        void ChangeFirstName();
        void ChangeLastName();
        void DeactivateAccount(User user);
        string FirstName();
        string LastName();
        int Age();
        string Username();
        string Password();
    }
}
