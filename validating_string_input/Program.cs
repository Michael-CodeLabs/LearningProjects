string? readResult;
bool validEntry = false;

// Store valid roles in an array
string[] validRoles = { "administrator", "manager", "user" };

Console.WriteLine("Enter your role name");

do
{
    // Read the input from the user
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        // Trim leading/trailing spaces and convert to lowercase
        readResult = readResult.Trim().ToLower();

        // Check if the input matches any of the valid roles
        if (validRoles.Contains(readResult))
        {
            validEntry = true; // Valid entry, exit the loop
        }
        else
        {
            // Invalid entry, prompt the user again
            Console.WriteLine($"The role name you entered, '{readResult}', is not valid.");
        }
    }

} while (!validEntry); // Continue looping until valid input is entered

// Inform the user that their input has been accepted
Console.WriteLine($"Your input value ({readResult}) has been accepted.");
