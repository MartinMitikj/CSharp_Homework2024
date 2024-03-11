// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] intArray = new int[5];
Console.WriteLine("Enter five numbers:");
for (int i = 0; i < 5; i++)
{
    intArray[i] = int.Parse(Console.ReadLine());
}

int total = 0;
foreach (int sum in intArray)
{
    total += sum;
}
Console.WriteLine($"Sum of all numbers is: {total}");