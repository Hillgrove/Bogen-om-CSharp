
DateTime d1 = DateTime.Now;
Console.WriteLine(d1);

d1 = d1.AddDays(10);
Console.WriteLine(d1);

d1 = d1.AddMinutes(20);
Console.WriteLine(d1);

d1 = d1.AddMonths(-1);
Console.WriteLine(d1);

DateTime d2 = new DateTime(1978, 12, 22);
DateTime d3 = new DateTime(1980, 7, 7);
TimeSpan difference = d3 - d2;
// Approximation. Real time difference in years/months need to take account for leap years
int years = difference.Days / 365;
int months = difference.Days % 365 / 30;
Console.WriteLine($"{years} years and {months} months");

TimeSpan t2 = new TimeSpan(16, 0, 0);
Console.WriteLine(t2);

TimeSpan t3 = new TimeSpan(0, 30, 0);
Console.WriteLine(t3);

TimeSpan t4 = t2 - t3;
Console.WriteLine(t4);

TimeSpan t5 = t2 + t3;
Console.WriteLine(t5);