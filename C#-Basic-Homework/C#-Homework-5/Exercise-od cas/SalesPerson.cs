

namespace Exercise_od_cas
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string fname, string lname) 
        {
            FirstName = fname;
            LastName = lname;
            
        }

        public void AddSuccessRevenue(double successSaleRavenue)
        {
            SuccessSaleRevenue = successSaleRavenue;
        }

        public override double GetSalary()
        {

            if (SuccessSaleRevenue <= 2000)
            {
                Salary = 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                Salary = 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                Salary = 1500;
            }

            return Salary;
        }
    }
}
