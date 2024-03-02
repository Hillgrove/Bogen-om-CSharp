
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

for (int i = 1; i <= 20; i += 2)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{i} ");
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{i} ");
    }
}

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine();

Console.WriteLine("testing color");