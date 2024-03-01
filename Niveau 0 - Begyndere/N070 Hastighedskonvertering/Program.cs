
Console.Write("Indtast hastighed in MPH: ");
string? input = Console.ReadLine();

try
{
    double mph = double.Parse(input);
    if (mph < 0 )
    {
        Console.WriteLine("Hastigheden kan ikke være negativ");
        return;
    }

    double kmt = mphToKmt(mph);
    Console.WriteLine($"Resultat: {mph} MPH er lig med {kmt:F2} KMT.");
}

catch (FormatException)
{
    Console.WriteLine("Input var ikke et gyldigt tal - programmet afsluttes");
}


double mphToKmt(double mph)
{
    return mph * 1.60934;
}