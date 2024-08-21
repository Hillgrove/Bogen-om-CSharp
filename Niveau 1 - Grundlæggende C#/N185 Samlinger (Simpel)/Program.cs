
// Lists
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);

Console.WriteLine("All integers in the list: ");
foreach (int i in list)
{
    Console.WriteLine(i);
}

// Stacks
Stack<DateTime> stack = new Stack<DateTime>();
stack.Push(DateTime.Now);
stack.Push(new DateTime(1978, 12, 22));
stack.Push(new DateTime(1980, 7, 7));

Console.WriteLine("\nAll dates in the stack: ");
foreach (DateTime date in  stack)
{
    Console.WriteLine(date.ToString());
}

DateTime dateTime = stack.Pop();
Console.WriteLine($"\nDate popped: \n{dateTime.ToString()}");

// Dictionaries
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Horse");
dict.Add(2, "Car");
dict.Add(3, "Flower");

string foundString = dict[2];
Console.WriteLine($"\nFound string:\n{foundString}");