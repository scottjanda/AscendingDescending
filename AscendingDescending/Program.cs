string userContinue = "y";

do
{
    Console.Write("Please enter a number: ");
    bool validNumber = int.TryParse(Console.ReadLine(), out int number);
    Console.Clear();
    if (validNumber == false)
    {
        Console.WriteLine("That was not a valid number!");
        Console.WriteLine();
        continue;
    }

    for (int i = number; i >= 0; i--)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();

    for (int i = 0; i <= number; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();

    Console.Write("Do you want to continue (y/n)? ");
    userContinue = Console.ReadLine();
    Console.Clear();

} while (userContinue.ToLower() == "y");

Console.WriteLine("Goodbye!");