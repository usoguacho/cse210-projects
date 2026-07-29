List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int number = -1; 
while (number != 0)
{
    Console.Write("Enter number: ");
    string? input = Console.ReadLine();
    number = int.Parse(input!);

    if (number != 0)
    {
        numbers.Add(number);
    }
}

int sum = numbers.Sum();
Console.WriteLine($"The sum is: {sum}");

double average = numbers.Average();
Console.WriteLine($"The average is: {average}");

int max = numbers.Max();
Console.WriteLine($"The largest number is: {max}");

// Stretch Challenge: smallest positive number
List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
if (positiveNumbers.Count > 0)
{
    int smallestPositive = positiveNumbers.Min();
    Console.WriteLine($"The smallest positive number is: {smallestPositive}");
}
else
{
    Console.WriteLine("There were no positive numbers in the list.");
}

// Stretch Challenge: sort and display the list 
numbers.Sort();
Console.WriteLine("The sorted list is:");
foreach (int n in numbers)
{
    Console.WriteLine(n);
}