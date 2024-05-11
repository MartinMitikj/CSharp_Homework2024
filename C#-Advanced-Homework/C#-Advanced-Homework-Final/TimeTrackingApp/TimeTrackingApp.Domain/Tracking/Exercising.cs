using TimeTrackingApp.Domain.Enums;

namespace TimeTrackingApp.Domain.Tracking
{
    public class Exercising : ActivityTime
    {
        public ExercisingRole Type { get; set; }
        public double TimeSpentOnActivity { get; set; }

        public Exercising(ExercisingRole exercisingRole)
        {
            Type = exercisingRole;
        }
    }
}
