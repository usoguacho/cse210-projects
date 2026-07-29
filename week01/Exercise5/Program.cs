DisplayWelcome();

string name = PromptUserName();
int number = PromptUserNumber();
int squared = SquareNumber(number);

DisplayResult(name, squared);


void DisplayWelcome()
{
    Console.WriteLine("Welcome to the program!");
}

string PromptUserName()
{
    Console.Write("Please enter your name: ");
    string? input = Console.ReadLine();
    return input!;
}

int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    string? input = Console.ReadLine();
    return int.Parse(input!);
}

int SquareNumber(int number)
{
    return number * number;
}

void DisplayResult(string name, int squared)
{
    Console.WriteLine($"{name}, the square of your number is {squared}");
}