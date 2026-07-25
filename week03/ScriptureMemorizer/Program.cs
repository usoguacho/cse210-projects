Reference reference = new Reference("Proverbs", 3, 5, 6);
Scripture scripture = new Scripture(
    reference,
    "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
    "In all thy ways acknowledge him and he shall direct thy paths."
);

const int wordsToHidePerRound = 3;

while (true)
{
    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();

    if (scripture.AllWordsHidden())
    {
        break;
    }

    Console.Write("Press enter to continue or type 'quit' to exit: ");
    string? input = Console.ReadLine();

    if (input != null && input.Trim().ToLower() == "quit")
    {
        break;
    }

    scripture.HideRandomWords(wordsToHidePerRound);
}