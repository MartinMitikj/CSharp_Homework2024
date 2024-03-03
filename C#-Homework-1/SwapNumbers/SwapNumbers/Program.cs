// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + "," + num2);
int swapNum = num1;
num1 = num2;
num2 = swapNum;
Console.WriteLine(num1 + "," + num2);
