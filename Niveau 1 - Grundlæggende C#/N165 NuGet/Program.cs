
using Humanizer;

DateTime nieceBirthday = new DateTime(2000, 7, 9);
Console.WriteLine($"Niece was born: {nieceBirthday.Humanize()}");

int intNumber = 123;
Console.WriteLine($"Humanized number ({intNumber}): \"{intNumber.ToWords()}\"");

string testString = "camelCaseString";
Console.WriteLine(testString.Humanize());