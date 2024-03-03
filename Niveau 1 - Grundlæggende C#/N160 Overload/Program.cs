
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(1, 2, 3));
        Console.WriteLine(Add(1, 2, 4, 5));
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Add(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }

}