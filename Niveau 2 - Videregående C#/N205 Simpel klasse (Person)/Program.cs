
using System.Text.Json;

// Person A
Person personA = new Person();
Console.WriteLine($"Person A (default constructor): {personA.FullName()}");
Console.WriteLine($"Estimated age: {personA.Age()}");

// Person B
Person personB = new Person("John", "Due", 1980);
Console.WriteLine($"\nPerson B (custom constructor): {personB.FullName()}");
Console.WriteLine($"Estimated age: {personB.Age()}");

// serializing
string jsonString = JsonSerializer.Serialize(personB);
Console.WriteLine("\nSerialized string of personB:");
Console.WriteLine(jsonString);

// Person C
Person personC = new Person();
personC = JsonSerializer.Deserialize<Person>(jsonString);
Console.WriteLine($"\nPerson C (deserialzied): {personC.FullName()}");
Console.WriteLine($"Estimated age: {personC.Age()}");