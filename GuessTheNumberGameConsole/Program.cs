Console.WriteLine("Guess the Numbers Game");
Console.WriteLine("Are you ready to play? Press 'Y' for Yes or 'N' for No");

bool startGame = false;

while (true)
{
    var key = Console.ReadKey(true);
    var keyValue = char.ToUpper(key.KeyChar);

    if (keyValue == 'Y')
    {
        startGame = true;
        break;
    }
    else if (keyValue == 'N')
    {
        startGame = false;
        break;
    }
    else
    {
        Console.WriteLine("Invalid answer. Try again.");
        Console.WriteLine("Are you ready to play? Press 'Y' for Yes or 'N' for No");
    }
}

while (startGame)
{
    Random random = new Random();
    var randomNumber = random.Next(1, 100);
    int count = 0;

    Console.WriteLine("I have selected a number between 1 and 99. Try to guess it!");

    while (true)
    {
        Console.Write("Enter your guess: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out var num))
        {
            count++;

            if (num == randomNumber)
            {
                Console.WriteLine($"Congratulations! You guessed it in {count} tries.");
                break;
            }
            else if (num > randomNumber)
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

    Console.WriteLine("Play again? Press 'Y' for Yes or 'N' for No");
    var playAgainKey = Console.ReadKey(true).KeyChar;

    if (char.ToUpper(playAgainKey) != 'Y')
    {
        startGame = false;
        Console.WriteLine("Thanks for playing!");
    }
}
