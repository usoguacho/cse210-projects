bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("Mindfulness Program");
    Console.WriteLine();
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Reflection Activity");
    Console.WriteLine("3. Listing Activity");
    Console.WriteLine("4. Quit");
    Console.Write("Which activity would you like to do? ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
            break;

        case "2":
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Run();
            break;

        case "3":
            ListingActivity listing = new ListingActivity();
            listing.Run();
            break;

        case "4":
            running = false;
            break;

        default:
            Console.WriteLine("That's not a valid option.");
            Console.WriteLine("Press enter to try again.");
            Console.ReadLine();
            break;
    }
}