using TimeTrackingApp.Domain.Enums;

namespace TimeTrackingApp.Domain.Tracking
{
    public class Reading : ActivityTime
    {
        public int Pages { get; set; }
        public ReadingRole Type { get; set; }
        public double TimeSpentOnActivity { get; set; }

        public Reading(int pages,ReadingRole readingRole)
        {
            Pages = pages;
            Type = readingRole;
        }
    }
}
