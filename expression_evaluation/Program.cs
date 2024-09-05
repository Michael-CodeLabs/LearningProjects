class Program
{
    static void Main()
    {
        // Define the permissions and levels
        string[] permission = { "SuperAdmin", "Admin", "Manager", "User" };

        // Employee names, IDs, and their corresponding permission levels
        string[] employees = { "Michael", "Lora", "Oscar", "Reem" };
        string[] employeeId = { "A137", "A875", "AC826", "LC109" };
        string[] employeePermissions = { permission[0], permission[1], permission[2], permission[3] };

        // Greet the user
        Console.WriteLine("\t\t\t\tWelcome");

        // Prompt for Employee ID
        Console.Write("Please enter Employee ID: ");
        string? userInput = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < employeeId.Length; i++)
        {
            if (userInput == employeeId[i])
            {
                Console.WriteLine($"Hello\nName: {employees[i]}\nPermission: {employeePermissions[i]}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Please enter a valid employee ID.");
        }
    }
}
