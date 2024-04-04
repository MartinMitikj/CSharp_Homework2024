

using Domain.Models;

Teacher teacher1 = new Teacher(1, "Danilo", "Danilo123", new List<string>
{
    "C#",
    "JavaScript",
    "Python"
});
Teacher teacher2 = new Teacher(2, "Ilija", "Ilija123", new List<string>
{
    "Java",
    "C++",
    "React"
});
Student student1 = new Student(3, "Martin", "Martin123", new List<int>
{
    3,5,4,6,7,8,9
});
Student student2 = new Student(4, "Andrej", "Andrej123", new List<int>
{
    5,6,7,8,9,10,1
});

teacher1.PrintUser();
teacher1.PrintSubjects();
Console.WriteLine();
teacher2.PrintUser();
teacher2.PrintSubjects();
Console.WriteLine();
student1.PrintUser();
student1.PrintGrades();
Console.WriteLine();
student2.PrintUser();
student2.PrintGrades();