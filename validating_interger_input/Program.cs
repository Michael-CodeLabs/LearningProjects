string? readResult;

int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();

    // Check if the input can be parsed as an integer
    if (readResult != null && int.TryParse(readResult, out numericValue))
    {
        // Check if the number is outside the valid range
        if (numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }
        else
        {
            // The input is valid and within the range
            validNumber = true;
            Console.WriteLine($"Your input value ({numericValue}) has been accepted");
        }
    }
    else
    {
        // This block runs when the input cannot be parsed as an integer
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

} while (!validNumber);
