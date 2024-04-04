

namespace Exercise_od_cas
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }


        
        public void PrintInfo()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName} Salary: {GetSalary()}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
