

using Domain.Interface;

namespace Domain.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }
        public Student(int id, string name, string username, List<int> grades) : base(id, name, username)
        {
            Grades = grades;
        }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine($"Students average grades is : {Grades.Average()}");
        }
        public void PrintGrades()
        {
            Console.WriteLine("Grades:");
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
