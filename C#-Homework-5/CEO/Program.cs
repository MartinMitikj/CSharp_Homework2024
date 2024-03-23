

using Exercise_od_cas;
using System.Reflection.Metadata;

Manager viktor = new Manager("Viktor", "Zdravevski", 1232.32, "HR");
Manager nikola = new Manager("Nikola", "Johnsky", 1450, "HR");
Employee[] company = new Employee[]
{
    new Contractor()
{
    FirstName = "Andrej",
    LastName = "Jankovikj",
    WorkHours = 45,
    PayPerHour = 20,
    Responsible = viktor
},
    new Contractor()
{
    FirstName = "Mario",
    LastName = "Gulic",
    WorkHours = 40,
    PayPerHour = 25,
    Responsible = nikola
},
    new SalesPerson("Blagojce", "Jovanov")
};

CEO martin = new CEO("Martin", "Mitic", 50000)
{
    Employees = company,
};

martin.PrintInfo();
martin.PrintEmployees();
martin.GetSalary();
