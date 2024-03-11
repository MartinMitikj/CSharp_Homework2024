// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] intArray = new int[6];
string[] numbers = new string[6] { "First", "Second", "Third", "Fourth", "Fifth", "Sixth" };
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Enter {numbers[i]} number:");
    intArray[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] % 2 == 0)
    {
        sum += intArray[i];
    }

}
Console.WriteLine("The sum of all the even numbers is: " + sum);