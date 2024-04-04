

namespace Exercise_od_cas
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public string Department { get; set; }

        public Manager(string firstName, string lastName, double salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Bonus = 0;
            Salary = salary;
            Role = Role.Manager;
            Department = department;
        }



        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
