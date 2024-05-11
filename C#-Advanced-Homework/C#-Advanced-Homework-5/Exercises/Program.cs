

string folderPath = @"..\..\..\Files";
string filePath = folderPath + @"\names.txt";

void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path);
    }
}

CreateFolder(folderPath);
CreateFile(filePath);

void Write(string text, string filePath)
{
    using (StreamWriter writer = new StreamWriter(filePath,true))
    {
        writer.WriteLine(text);
    }
}

void Read(string filePath)
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}

void WriteAndRead()
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Enter some name");
        string name = Console.ReadLine();
        Write(name, filePath);
    }
    Console.WriteLine("----------- Read -----------");
    Read(filePath);
}
WriteAndRead();


