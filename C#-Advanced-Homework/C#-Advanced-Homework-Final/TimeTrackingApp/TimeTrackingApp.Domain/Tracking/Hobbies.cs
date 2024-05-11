using TimeTrackingApp.Domain.Enums;

namespace TimeTrackingApp.Domain.Tracking
{
    public class Hobbies : ActivityTime
    {
        public Enums.HobbiesRole Type { get; set; }
        public double TimeSpentOnActivity { get; set; }

        public Hobbies(Enums.HobbiesRole otherHobbies)
        {
            Type = otherHobbies;
        }
    }
}
