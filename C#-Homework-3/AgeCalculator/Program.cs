// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;  
    --age;
    return age;
}


Console.WriteLine("Please enter your birthdate in the format MM/dd/yyyy:");
string birthdayInput = Console.ReadLine();

DateTime birthday;
if (DateTime.TryParse(birthdayInput, out birthday))
{
    int age = AgeCalculator(birthday);
    Console.WriteLine($"Your age is: {age}");
}
else
{
    Console.WriteLine("Invalid date format. Please enter your birthdate in the format MM/dd/yyyy.");
}