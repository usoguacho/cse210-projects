Console.Write("Enter your grade percentage: ");
string? input = Console.ReadLine();
int percentage = int.Parse(input!);

string letter;

if (percentage >= 90)
{
    letter = "A";
}
else if (percentage >= 80)
{
    letter = "B";
}
else if (percentage >= 70)
{
    letter = "C";
}
else if (percentage >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

// ---- Stretch Challenge : determine the +/- sign ----
int lastDigit = percentage % 10;
string sign = "";

if (lastDigit >= 7)
{
    sign = "+";
}
else if (lastDigit < 3)
{
    sign = "-";
}

// ---- Stretch Challenges: there is no A+, no F+, and no F- ----
if (letter == "A" && sign == "+")
{
    sign = "";
}

if (letter == "F")
{
    sign = "";
}

Console.WriteLine($"Your grade is: {letter}{sign}");

// pass/fail message 
if (percentage >= 70)
{
    Console.WriteLine("Congratulations, you passed the course!");
}
else
{
    Console.WriteLine("You didn't pass this time, but keep working — you'll get there next attempt.");
}