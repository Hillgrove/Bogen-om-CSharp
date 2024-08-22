
//Del 1: HashSet med Integers
//Skabe en instans af en generisk HashSet<int>.
//Tilføj 5 forskellige tal.
//Forsøg at tilføje et tal, der allerede findes i sættet, og observer hvad der sker.
//Skriv alle tal ud i en foreach-løkke.
//Tjek om et specifikt tal findes i sættet.

HashSet<int> setA = new HashSet<int>();
setA.Add(1);
setA.Add(2);
setA.Add(3);
setA.Add(4);
setA.Add(5);

Console.WriteLine("Elements in SetA:");
foreach (var number in setA)
{
    Console.WriteLine(number);
}

setA.Add(5);
Console.WriteLine("\nElements in SetA after adding a duplicate:");
foreach (var number in setA)
{
    Console.WriteLine(number);
}

int numberToFind = 5;
Console.WriteLine($"\nIs {numberToFind} in the setA? {setA.Contains(numberToFind)}");


//Del 2: HashSet med Strings
//Skabe en instans af en generisk HashSet<string>.
//Tilføj 5 forskellige strings.
//Forsøg at tilføje en string, der allerede findes i sættet, og observer hvad der sker.
//Skriv alle strings ud i en foreach-løkke.
//Tjek om en specifik string findes i sættet.

HashSet<string> setB = new HashSet<string>();
setB.Add("Monday");
setB.Add("Tuesday");
setB.Add("Wednesday");
setB.Add("Thursday");
setB.Add("Friday");

Console.WriteLine("\nElements in setB:");
foreach (var day in setB)
{
    Console.WriteLine(day);
}

setB.Add("Tuesday");
Console.WriteLine("\nElements in setB after adding a duplicate:");
foreach (var day in setB)
{
    Console.WriteLine(day);
}

string dayToFind = "Sunday";
Console.WriteLine($"\nIs {dayToFind} in setB? {setB.Contains(dayToFind)}");