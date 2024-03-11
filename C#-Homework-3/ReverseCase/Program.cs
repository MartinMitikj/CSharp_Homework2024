// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static string ReverseCase()
{
    Console.WriteLine("Write something");
    string input = Console.ReadLine();

    char[] charInput = input.ToCharArray();
    for (int i = 0; i < charInput.Length; i++)
    {
        if (char.IsLower(charInput[i]))
        {
            charInput[i] = char.ToUpper(charInput[i]);
        }
        else if (char.IsUpper(charInput[i]))
        {
            charInput[i] = char.ToLower(charInput[i]);
        }
    }
    string reversed = new string(charInput);
    return $"The reversed string: {reversed}";
}

Console.WriteLine(ReverseCase());