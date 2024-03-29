
Queue<double> queueOfNumbers = new Queue<double>();
Console.Write("Enter the first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
double secondNumber = double.Parse(Console.ReadLine());
queueOfNumbers.Enqueue(firstNumber);
queueOfNumbers.Enqueue(secondNumber);

while (true)
{
    Console.WriteLine("Do you want to continue: Y/N");
    string input = Console.ReadLine();
    if (input == "Y".ToLower())
    {
        Console.Write("Enter another number: ");
        double anotherNumber = double.Parse(Console.ReadLine());
        queueOfNumbers.Enqueue(anotherNumber);
        continue;
    }
    else if (input == "N".ToLower())
    {
        foreach (var number in queueOfNumbers)
        {
            Console.WriteLine(number);
        }
        break;
    }
}
