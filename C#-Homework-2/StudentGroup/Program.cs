// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[5] { "Martin", "Andrej", "Mario", "Nikola", "Blagojce" };

Console.Write("Would you like the names of students from G1 or G2(Enter 1 or 2): ");
int witchClass = int.Parse(Console.ReadLine());
if (witchClass == 1)
{
    Console.WriteLine("The Students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (witchClass == 2)
{
    Console.WriteLine("The Students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}