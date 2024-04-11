using Print.Domain;

PrintInConsole<string> printString = new PrintInConsole<string>();
printString.Print("2332131");
printString.Print("Hello");
PrintInConsole<int> printInt = new PrintInConsole<int>();
printInt.PrintCollection(new List<int> { 1, 2, 3, 4, 5, 6, 7 });