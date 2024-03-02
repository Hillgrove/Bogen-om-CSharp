
/*
 * Multiplication Table Color Coded
 * 
 * This program prints a 10x10 multiplication table to the console.
 * It changes the color of the output based on the product value:
 * - Green for products less than 25,
 * - Yellow for products between 25 and 49, inclusive,
 * - Red for products 50 and above.
 * 
 * Purpose: Demonstrate the use of nested loops, conditional statements,
 * and console color manipulation in C#.
 * 
 * Author: Jesper Højlund
 * Date: 02/03/2024
 */

for (int row = 1; row <= 10; row++)
{
    for (int col = 1; col <= 10; col++)
    {
        int number = row * col;

        Console.ForegroundColor = number switch
        {
            < 25 => ConsoleColor.Green,
            >= 25 and < 50 => ConsoleColor.Yellow,
            _ => ConsoleColor.Red,
        };
        
        Console.Write($"{number, 5}");
    }

    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Gray;