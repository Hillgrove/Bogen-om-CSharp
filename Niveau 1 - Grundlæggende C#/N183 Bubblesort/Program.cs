
class Program
{
    static void Main(string[] args)
    {
        int[] tal = { 5, 1, 4, 2, 8, 0, 2, 7, 6, 3, 9, 5, 8, 1, 4, 2, 7, 6, 3, 0 };
        BubbleSort(tal);
        Console.WriteLine("Sorted order:");
        foreach (var item in tal)
        {
            Console.Write(item + " ");
        }
    }

    private static void BubbleSort(int[] tal)
    {
        for (int i = 0; i < tal.Length - 1; i++)
        {
            for (int j = 0; j < tal.Length - i - 1; j++)
            {
                if (tal[j] > tal[j + 1])
                {
                    int temp = tal[j];
                    tal[j] = tal[j + 1];
                    tal[j + 1] = temp;
                }
            }
        }
    }
}