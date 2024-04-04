// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the First numer");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Operation (+, -, *, /)");
char operation = Convert.ToChar(Console.ReadLine());

if (operation == '+')
{
    Console.WriteLine("The result is: " + (num1 + num2));
}
else if (operation == '-')
{
    Console.WriteLine("The result is: " + (num1 - num2));
}
else if (operation == '*')
{
    Console.WriteLine("The result is: " + (num1 * num2));
}
else if (operation == '/')
{
    Console.WriteLine("The result is: " + (num1 / num2));
}

