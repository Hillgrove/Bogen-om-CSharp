
Console.Write("Indtast tal 1: ");
string? tal1 = Console.ReadLine();
Console.Write("Indtast tal 2: ");
string? tal2 = Console.ReadLine();

double t1 = Convert.ToDouble(tal1);
double t2 = Convert.ToDouble(tal2);
double t3 = t1 + t2;

Console.WriteLine($"Resultat: {t3:N2}");