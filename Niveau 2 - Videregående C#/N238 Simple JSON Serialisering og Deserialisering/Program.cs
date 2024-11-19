
using System.Text.Json;

string jsonFilename = "persondata.json";

while (true)
{
    Console.WriteLine("""
        Choose an action:
        1. Add person (overwrite file)
        2. Show person
        3. Exit
        """);

    string action = Console.ReadLine();
    if (!string.IsNullOrEmpty(action))
        Console.WriteLine();

    switch (action)
    {
        case "1":
            AddPerson();
            break;

        case "2":
            PrintPerson();
            break;

        case "3":
            Console.WriteLine("Exiting program...");
            return;

        default:
            Console.WriteLine("Wrong command. Please try again.\n");
            break;
    }
}


void AddPerson()
{
    Console.Write("Name of person: ");
    string name = Console.ReadLine();
    Console.Write("Age of person: ");
    int age = int.Parse(Console.ReadLine());

    var person = new Person(name, age);

    // TODO: add person to json
    string jsonString = JsonSerializer.Serialize(person);
    File.WriteAllText(jsonFilename, jsonString);
    Console.WriteLine("Person added.\n");
}

void PrintPerson()
{
    try
    {
        string jsonString = File.ReadAllText(jsonFilename);
        var person = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine($"{person}\n");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("File not found.\n");
    }
}

class Person
{
    public string Name { get; init; }
    public int Age { get; init; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}