
static string SmartToUpper(string text)
{
    if (text == null)
    {
        throw new ArgumentException("Tekst må ikke være null");
    }

    if (text.Length == 0)
    {
        throw new ArgumentException("Tekst må ikke være tom");
    }

    return text.ToUpper();
}

try
{
    Console.WriteLine(SmartToUpper("mikkel"));
    Console.WriteLine(SmartToUpper("mAtHiAs"));

    // prøv også 
    Console.WriteLine(SmartToUpper(""));
    // eller
    Console.WriteLine(SmartToUpper(null));

}
catch (Exception ex)
{
    Console.WriteLine("Der er sket en fejl: " + ex.Message);
}