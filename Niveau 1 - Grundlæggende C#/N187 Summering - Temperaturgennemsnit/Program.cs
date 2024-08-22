
//I denne opgave skal du skabe et program, der kan indsamle og behandle temperaturdata. Brugeren skal indtaste en række temperaturer (som decimaltal),
//og programmet skal derefter udregne og vise gennemsnittet af disse temperaturer. Du skal sikre, at de indtastede temperaturer er gyldige decimaltal
//og håndtere eventuelle indtastningsfejl.

//Opret en ny tom konsolapplikation. Programmet skal:

//Bede brugeren om at indtaste temperaturer, én ad gangen. Brugeren skal kunne indtaste så mange temperaturer, som ønsket.
//Efter hver indtastning, skal programmet spørge, om brugeren vil indtaste en ny temperatur.
//Hvis brugeren indtaster noget, der ikke er et gyldigt decimaltal, skal programmet vise en fejlmeddelelse og bede om en ny indtastning.
//Når brugeren vælger ikke at indtaste flere temperaturer, skal programmet udregne og vise gennemsnittet af de indtastede temperaturer.
//Brug eksempelvis en List<decimal> til at opbevare de indtastede temperaturer.

List<double> temperatures = new List<double>();
bool continueInput = true;


while (continueInput)
{
    Console.Write("Please add a temperature: ");
    string? input = Console.ReadLine();

    if (double.TryParse(input, out double temperature))
    {
        temperatures.Add(temperature);
        Console.Write("Do you want to add a new temperature (y/n): ");
        continueInput = Console.ReadLine().ToLower() == "y";
    }

    else
    {
        Console.WriteLine($"The input ({input}) is not a number . Please try again.");   
    }
}

if (temperatures.Count > 0)
{
    double averageTemperature = temperatures.Average();
    Console.WriteLine($"The average of all temperatures added is: {averageTemperature:N2}");
}

else
{
    Console.WriteLine("No temperatures were added.");
}

