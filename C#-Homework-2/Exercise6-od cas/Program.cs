// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] stringArray = new string[10];

Console.WriteLine("Enter name: ");
string addName = Console.ReadLine();
stringArray[0] = addName;


for (int i = 1; i < 10; i++)
{
    Console.Write("Do you want to enter another name type ' Y '. If you want to finish type ' N ' ");
    char input = Convert.ToChar(Console.ReadLine());
    if (input == 'Y')
    {
        stringArray[i] = Console.ReadLine();
    }
    else if (input == 'N')
    {
        break;
    }
}


Console.WriteLine("Entered names:");
foreach (string names in stringArray)
{
    Console.WriteLine(names);
}

