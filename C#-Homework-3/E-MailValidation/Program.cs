// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("Enter the email you want to validate: ");
string inputEmail = Console.ReadLine();
static bool EmailValidation(string email)
{
    if (!email.Contains("@") || !email.Contains("."))
    {
        return false;
    }
    int atIndex = email.IndexOf("@");
    if (atIndex == 0)
    {
        return false;
    }
    int dotIndex = email.LastIndexOf(".");
    if (dotIndex < atIndex + 2 || dotIndex == email.Length - 1)
        return false;
    if (email.LastIndexOf(".") == email.Length - 1)
    {
        return false;
    }
    return true;

}
string emailValidation = $"The input email after evaluation has returned: {EmailValidation(inputEmail)}";
Console.WriteLine(emailValidation);