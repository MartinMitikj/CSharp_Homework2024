// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the First number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number:");
int num3 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the four number:");
int num4 = Convert.ToInt32(Console.ReadLine());

int averageNumber = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine("The average number of " + num1 + "," + num2 + "," + num3 + "," + num4 + " is " + averageNumber);
 