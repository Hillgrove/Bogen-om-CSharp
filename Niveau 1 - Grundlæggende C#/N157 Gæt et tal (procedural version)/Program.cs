
// MVP of a procedural number guessing game.

int randomNumber = GenerateRandomNumber();
bool gameCompleted = false;

Console.WriteLine("Guess a number between 1 and 100");

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
    Console.Write("Input number: ");
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
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