﻿using Cars.Domain.Models;
namespace Cars.Domain.Helpers
{
    public static class ConsoleHelper
    {
        public static void PrintInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}