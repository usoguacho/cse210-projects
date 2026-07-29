Journal journal = new Journal();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("Journal Menu");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save the journal to a file");
    Console.WriteLine("4. Load the journal from a file");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");

    string? choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            journal.Write();
            break;

        case "2":
            journal.Display();
            break;

        case "3":
            Console.Write("What is the filename? ");
            string? saveFilename = Console.ReadLine();
            journal.SaveToFile(saveFilename ?? "journal.txt");
            break;

        case "4":
            Console.Write("What is the filename? ");
            string? loadFilename = Console.ReadLine();
            journal.LoadFromFile(loadFilename ?? "journal.txt");
            break;

        case "5":
            running = false;
            break;

        default:
            Console.WriteLine("That's not a valid option. Please choose 1-5.");
            break;
    }
}

Console.WriteLine("Goodbye!");