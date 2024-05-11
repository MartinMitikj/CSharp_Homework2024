using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Service.Interfaces
{
    public interface IUIService<T> where T : BaseEntity
    {
        void MainMenu(User user);
        void BackToMainMenu(User user);
        void Track(User user);
        void AccountManagement(User user);
        void UserStatistics(User user);
        void EndMenu();
        void StartMenu();

    }
}
