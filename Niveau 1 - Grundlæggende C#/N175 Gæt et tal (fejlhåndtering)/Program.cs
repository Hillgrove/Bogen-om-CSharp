
// MVP of a procedural number guessing game.

int randomNumber = GenerateRandomNumber();
bool gameCompleted = false;

while (!gameCompleted)
{
    int guess = getNumberFromUser();
    Feedback(guess);
}


int GenerateRandomNumber()
{
    Random rand = new Random();
    return rand.Next(1, 100);
}

int getNumberFromUser()
{    
    try
    {
        Console.Write("Guess a number between 1 and 100: ");
        string input = Console.ReadLine();
        return Convert.ToInt32(input);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Please enter a valid number. " + ex.Message);
        return getNumberFromUser();
    }
}

void Feedback(int guess)
{
    if (guess < randomNumber)
    {
        Console.WriteLine("Too small\n");
    }

    else if (guess > randomNumber)
    {
        Console.WriteLine("Too big\n");
    }

    else
    {
        Console.WriteLine("Congratulations! You guessed it");
        gameCompleted = true;
    }
}