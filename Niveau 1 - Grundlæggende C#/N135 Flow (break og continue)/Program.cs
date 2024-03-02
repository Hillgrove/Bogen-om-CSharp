
// Print out 0, 3, 6, 9, 12, 15 with use of continue and break.


for (int i = 0; i < 20; i++)
{
    if (i % 3 != 0)
        continue;

    if (i > 15)
        break;

    Console.Write($"{i} ");
}