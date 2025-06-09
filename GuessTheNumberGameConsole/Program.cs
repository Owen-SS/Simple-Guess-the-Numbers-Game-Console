bool startGame = DoYouWantToPlay();

while (startGame)
{
    int randomNumber = GenerateRandomNumber();
    int attempts = PlayRound(randomNumber);

    Console.WriteLine($"You guessed it in {attempts} tries!");

    startGame = AskToPlayAgain();
}

Console.WriteLine("Thanks for playing!");

bool DoYouWantToPlay()
{
    Console.WriteLine("Are you ready to play? Press 'Y' for Yes or 'N' for No");
    while (true)
    {
        var key = Console.ReadKey(true);
        var keyValue = char.ToUpper(key.KeyChar);

        if (keyValue == 'Y') return true;
        if (keyValue == 'N') return false;

        Console.WriteLine("Invalid answer. Try again.");
    }
}

int GenerateRandomNumber()
{
    Random random = new Random();
    return random.Next(1, 100);
}

int PlayRound(int targetNumber)
{
    Console.WriteLine("I have selected a number between 1 and 99. Try to guess it!");
    int count = 0;

    while (true)
    {
        Console.Write("Enter your guess: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out var guess))
        {
            count++;

            if (guess == targetNumber)
            {
                return count;
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too low!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}

bool AskToPlayAgain()
{
    Console.WriteLine("Play again? Press 'Y' for Yes or 'N' for No");

    while (true)
    {
        var key = Console.ReadKey(true);
        var keyValue = char.ToUpper(key.KeyChar);

        if (keyValue == 'Y') return true;
        if (keyValue == 'N') return false;

        Console.WriteLine("Invalid answer. Press 'Y' or 'N'.");
    }
}