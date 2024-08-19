
int[] salaries = { 10000, 20000, 15000, 20000, 30000, 15000 };
double averageSalary = (double)salaries.Sum() / salaries.Length;

void PrintSalaries()
{
    for (int i = 0; i < salaries.Length; i++)
    {
        Console.WriteLine($"Salary {i + 1}: {salaries[i]:N0}");
    }
}


PrintSalaries();
Console.WriteLine($"Average: {averageSalary:N2}");