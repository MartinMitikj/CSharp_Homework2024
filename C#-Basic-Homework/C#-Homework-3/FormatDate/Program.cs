// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");


    static void DateFormat()
    {
        Console.Write("Enter the date you would like to enter here (yyyy/MM/dd HH:mm:ss): ");
        string dateString = Console.ReadLine();
        DateTime theDate = DateTime.Parse(dateString);



        Console.Write("Input the format you would like the date to be printed in:\n\"MM/dd/yyyy\"\n\"MM/dd/yyyy hh:mm:ss\"\n\"dddd, dd MMMM yyyy HH:mm:ss\"\n\"MM.dd.yyyy\"\n");
        string theFormatInput = Console.ReadLine().ToLower();

        string formattedDate;

        switch (theFormatInput)
        {
            case "mm/dd/yyyy":
                formattedDate = theDate.ToString("MM/dd/yyyy");
                break;
            case "mm/dd/yyyy hh:mm:ss":
                formattedDate = theDate.ToString("MM/dd/yyyy hh:mm:ss");
                break;
            case "dddd, dd MMMM yyyy HH:mm:ss":
                formattedDate = theDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                break;
            case "mm.dd.yyyy":
                formattedDate = theDate.ToString("MM.dd.yyyy");
                break;
            default:
                Console.WriteLine("Invalid format input!");
                return;
        }

        Console.WriteLine("Formatted date: " + formattedDate);
    }

DateFormat();