// See https://aka.ms/new-console-template for more information
List<string> tasks = new List<string>();

while (true)
{
    Console.Clear();

    Console.WriteLine("========================");
    Console.WriteLine("       TASK TRACKER");
    Console.WriteLine("========================");
    Console.WriteLine();

    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. View Tasks");
    Console.WriteLine("3. Exit");

    Console.WriteLine();
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine();
        Console.Write("Enter a new task: ");

        string? newTask = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(newTask))
        {
            tasks.Add(newTask);

            Console.WriteLine();
            Console.WriteLine("Task added successfully!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Task cannot be empty.");
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    else if (choice == "2")
    {
        Console.WriteLine();
        Console.WriteLine("View Tasks feature is coming next!");

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    else if (choice == "3")
    {
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Invalid option.");

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}