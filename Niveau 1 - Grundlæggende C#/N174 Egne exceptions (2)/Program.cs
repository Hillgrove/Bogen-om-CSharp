﻿
// Setting up variables
string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
string fullBaseDirectory = Path.GetFullPath(baseDirectory);
string file = "numbers.txt";
string filePath = Path.Combine(fullBaseDirectory, file);
string fileContent;

// Opening file
if (!File.Exists(filePath))
{
    throw new ApplicationException($"The file {filePath} does not exist!");
}

// Changing content and saving file
try
{
    fileContent = File.ReadAllText(filePath);
    int number = Convert.ToInt32(fileContent);
    number ++;
    File.WriteAllText(filePath, number.ToString());
    Console.WriteLine($"Number in file is now {number}");
}
catch (FormatException)
{
    throw new ApplicationException("Content cannot be converted to an integer");
}

catch (Exception)
{
    throw;
}

