using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Service.Interfaces
{
    public interface IStats
    {
        void ReadingStats(User user);
        void ExercisingStats(User user);
        void WorkingStats(User user);
        void HobbiesStats(User user);
        void GlobalStats(User user);
        Dictionary<Activities, double> TotalTime(User user);
        Dictionary<Activities, double> AverageTime(User user);
    }
}
