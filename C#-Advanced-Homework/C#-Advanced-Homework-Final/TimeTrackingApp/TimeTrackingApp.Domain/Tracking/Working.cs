using TimeTrackingApp.Domain.Enums;

namespace TimeTrackingApp.Domain.Tracking
{
    public class Working : ActivityTime
    {
        public WorkingRole Type { get; set; }
        public double TimeSpentOnActivity { get; set; }

        public Working(WorkingRole workingRole)
        {
            Type = workingRole;
        }
    }
}
