
Dice newDice = new Dice();
newDice.WriteFaceValue();
newDice.Shake();
newDice.WriteFaceValue();

public class Dice
{
	private int _faceValue;

	public int FaceValue
	{
		get
        {
            Console.WriteLine("Facevalue accessed.");
            return _faceValue;
        }
		set
		{
			if (value < 1 || value > 6)
                value = 1;
            _faceValue = value;
            Console.WriteLine($"Facevalue changed to {_faceValue}");
        }
	}

    public Dice()
    {
        Shake();
    }

    public Dice(int faceValue)
    {
        FaceValue = faceValue;
    }

    public void Shake()
    {
        Random rnd = new Random();
        FaceValue = rnd.Next(1, 7);
    }

    public void WriteFaceValue()
    {
        Console.WriteLine($"[{this.FaceValue}]");
    }

}