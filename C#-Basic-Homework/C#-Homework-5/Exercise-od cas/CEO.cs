using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_od_cas
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int SharesProperty { get; set; }
        private double SharesPrice { get; set; }


        public CEO(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + SharesProperty * SharesPrice;
        }
    }

}
