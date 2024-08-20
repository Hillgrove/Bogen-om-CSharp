
string[,] names = new string[4, 2];

names[0, 0] = "1";
names[0, 1] = "name1";
names[1, 0] = "2";
names[1, 1] = "name2";
names[2, 0] = "3";
names[2, 1] = "name3";
names[3, 0] = "4";
names[3, 1] = "name4";

static string FindName(string[,] nameArray, string id)
{
    string name = string.Empty;

    for (int row = 0; row < nameArray.GetLength(0); row++)
    {
        if (nameArray[row, 0] == id)
        {
            name = nameArray[row, 1];
        }
    }

    return name;
}

static void PrintArray(string[,] array)
{
    Console.WriteLine("The array: ");
    for (int row = 0; row < array.GetLength(0) ; row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write(array[row, col] + " ");
        }
        Console.WriteLine();
    }
}


PrintArray(names);
string name = FindName(names, "8");
Console.WriteLine($"The name at index 8: {name}");
