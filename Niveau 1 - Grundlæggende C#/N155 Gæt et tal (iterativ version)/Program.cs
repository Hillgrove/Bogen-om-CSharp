
// Simple console number guessing games


Random random = new Random();
int minNumber = 1;
int maxNumber = 100;
int numberToGuess = random.Next(minNumber, maxNumber);

Console.WriteLine($"Guess a number between {minNumber} and {maxNumber}");

bool numberGuessed = false;
int numberOfGuesses = 1;

while (!numberGuessed)
{
    Console.Write($"Guess #{numberOfGuesses++}: ");
    var guess = Console.ReadLine();

    if ( !int.TryParse(guess, out int guessInt) )
    {
        Console.WriteLine("The guess was not an integer. Please try again\n");
    }
 
    else if (guessInt < numberToGuess)
    {
        Console.WriteLine($"{guessInt} is too small\n");
    }

    else if (guessInt > numberToGuess)
    {
        Console.WriteLine($"{guessInt} is too big\n");
    }

    else
    {
        Console.WriteLine($"Congratulations. You've guessed the number");
        numberGuessed = true;
    }
}