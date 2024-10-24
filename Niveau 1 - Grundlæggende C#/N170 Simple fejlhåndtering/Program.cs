﻿
class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    private static void Run()
    {
        int currentTries = 0;
        int maxTries = 3;
        bool completed = false;

        do
        { 
            try
            {
                Console.WriteLine("Indtast 1. tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2. tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int res = tal1 + tal2;
                Console.WriteLine("resultatet er " + res);
                completed = true;
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Der er sket en format-fejl: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Der er sket en ikke håndteret fejl: {ex.Message}");
            }
            finally
            {
                currentTries++;
            }
        }
        while (!completed && currentTries < maxTries);
    }
}