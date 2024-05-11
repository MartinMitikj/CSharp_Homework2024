using TimeTrackingApp.Domain.Enums;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Service.Interfaces
{
    public interface IReading
    {
        void TrackReading(User user);
        int BookPages();
        ReadingRole Book();

    }
}
