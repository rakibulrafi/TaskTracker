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
Console.WriteLine("3. Edit Task");
Console.WriteLine("4. Delete Task");
Console.WriteLine("5. Exit");

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
        Console.WriteLine("YOUR TASKS");
        Console.WriteLine("------------------------");

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    else if (choice == "3")
{
    Console.WriteLine();
    Console.WriteLine("EDIT TASK");
    Console.WriteLine("------------------------");

    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
    }
    else
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }

        Console.WriteLine();
        Console.Write("Enter task number to edit: ");

        string? input = Console.ReadLine();

        if (int.TryParse(input, out int taskNumber))
        {
            if (taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                Console.Write("Enter new task name: ");

                string? updatedTask = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(updatedTask))
                {
                    tasks[taskNumber - 1] = updatedTask;

                    Console.WriteLine();
                    Console.WriteLine("Task updated successfully!");
                }
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

    else if (choice == "4")
    {
        Console.WriteLine();
        Console.WriteLine("DELETE TASKS");
        Console.WriteLine("------------------------");

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available for deletion.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            Console.WriteLine();
            Console.Write("Enter the number of the task to delete: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine();
                Console.WriteLine("Task deleted successfully!");
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid task number.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }



    else if (choice == "5")
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