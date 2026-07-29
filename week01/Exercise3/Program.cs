Random random = new Random();
bool playAgain = true;

// Stretch Challenge: play again loop 
while (playAgain)
{
    int magicNumber = random.Next(1, 101);

    int guessCount = 0;
    int guess = -1; 

    
    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        string? input = Console.ReadLine();
        guess = int.Parse(input!);

        // Stretch Challenge: count guesses 
        guessCount++;

        if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

    Console.WriteLine($"It took you {guessCount} guesses.");

    // ---- Stretch Challenge 2: ask to play again ----
    Console.Write("Do you want to play again? (yes/no) ");
    string? response = Console.ReadLine();
    playAgain = response != null && response.Trim().ToLower() == "yes";
}

Console.WriteLine("Thanks for playing!");