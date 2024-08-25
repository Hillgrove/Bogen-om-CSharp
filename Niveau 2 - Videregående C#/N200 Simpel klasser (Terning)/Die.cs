
public class Die
{
    public int faceValue;

    public Die()
    {
        this.faceValue = 1;
    }

    public Die(int faceValue)
    { 
        if (faceValue < 1 || faceValue > 6)
        {
            throw new ApplicationException("Wrong value");
        }
        this.faceValue = faceValue; 
    }


    public void Shake()
    {
        Random rand = new Random();
        faceValue = rand.Next(1, 7);
    }
}

