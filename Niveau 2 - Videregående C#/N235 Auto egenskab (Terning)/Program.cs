
Console.WriteLine("First Die:");
Die firstDie = new Die();
firstDie.ShowDie();

Console.WriteLine("\nSecond Die:");
Die secondDie = new Die(3);
secondDie.ShowDie();
secondDie.Shake();
secondDie.ShowDie();
secondDie.Shake();
secondDie.ShowDie();
secondDie.Shake();
secondDie.ShowDie();
secondDie.Shake();
secondDie.ShowDie();
secondDie.Shake();
secondDie.ShowDie();


public class Die
{
    public int FaceValue { get; private set; }

    public Die()
    {
        Shake();
    }

    public Die(int faceValue)
    {
        if (faceValue < 1 || faceValue > 7)
        {
            throw new ArgumentOutOfRangeException(nameof(faceValue));
        }

        FaceValue = faceValue;
    }

    public void Shake()
    {
        Random random = new Random();
        FaceValue = random.Next(1, 7);
    }

    public void ShowDie()
    {
        Console.WriteLine($"[{FaceValue}]");
    }
}