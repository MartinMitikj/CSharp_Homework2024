

namespace Exercise_od_cas
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }


        

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return $"The manager responsible for {FirstName} {LastName} is {Responsible.FirstName} {Responsible.LastName} and is working in {Responsible.Department}";
        }
    }
}
