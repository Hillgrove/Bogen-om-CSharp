
string filePath = @"C:\Temp\test.txt";

try
{
    string fileContent = File.ReadAllText(filePath);
    Console.WriteLine(fileContent);
}

catch (IOException e)
{
    Console.WriteLine("An IO exception was thrown!");
    Console.WriteLine(e.Message);
}

var file = new System.IO.FileInfo(filePath);

Console.WriteLine(file.FullName);
Console.WriteLine(file.LastAccessTime);
Console.WriteLine(file.Extension);