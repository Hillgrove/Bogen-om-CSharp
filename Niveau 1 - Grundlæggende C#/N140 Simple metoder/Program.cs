
int Addition(int a, int b) 
{ 
    return a + b; 
}

double CalcCircleArea(int radius)
{
    return (radius * radius * Math.PI);
}

double CalcMoneyAfterVAT(double money, double vatPercent)
{
    return money * (1 - vatPercent / 100);
}

void Print(string text)
{ 
    Console.WriteLine(text); 
}

int res = Addition(5, 2);
Console.WriteLine(res); // 7

double res2 = CalcCircleArea(5);
Console.WriteLine($"{res2:F2}"); // 78.54

double res3 = CalcMoneyAfterVAT(100, 25);
Console.WriteLine($"{res3:F2}"); // 75

Print("Dette er en test"); // Dette er en test