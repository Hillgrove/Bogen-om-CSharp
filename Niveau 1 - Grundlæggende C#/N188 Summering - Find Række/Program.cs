
//Du har en fil med kommaseparerede tal, hvor hver linje repræsenterer en række af tal. Din opgave er at skrive et C#-program,
//der læser denne fil og finder den række, som har det højeste gennemsnit af tal.

//Eksempel på filindhold:


//1,4,5
//5,6,3
//2,3,4
//Gem filen i eksempelvis c:\temp\data.csv.

//Forventet Output:
//Programmet skal udskrive linjenummeret og det højeste gennemsnit. For ovenstående eksempel vil output være:
//Række 2 har det højeste gennemsnit: 4.66667

//Retningslinjer:
//1.Læs hver linje i filen som en string.
//2. Opdel hver linje i enkelte tal ved at bruge kommaet som separator.
//3. Konverter disse tal fra string til int og beregn gennemsnittet for hver række.
//4. Gem det højeste gennemsnit og tilhørende rækkenummer undervejs i læsningen.
//5. Efter alle linjerne er blevet læst og behandlet, udskriv rækkenummeret og det højeste gennemsnit.

string folderPath = @"C:\temp";
string fileName = "data.csv";
string fullPath =  Path.Combine(folderPath, fileName);

string[] lines = File.ReadAllLines(fullPath);
double maxAverage = double.MinValue;
int maxLineIndex = -1;

for (int i = 0; i < lines.Length; i++)
{
    string line = lines[i];
    double[] numbers = line.Split(",").Select(double.Parse).ToArray();
    double average = numbers.Average();

    if (average > maxAverage)
    {
        maxAverage = average;
        maxLineIndex = i + 1;
    }
}

Console.WriteLine($"Row {maxLineIndex} got the highest average: {maxAverage:N5}");