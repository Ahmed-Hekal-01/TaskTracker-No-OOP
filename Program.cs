using System.Collections;
using System.Globalization;

namespace TaskTrackerWithoutOOP
{
    internal class Program
    {
        struct Task
        {
            public string Title;
            public string Description;
            public DateTime DueDate;
            public string Priority;
            public string Status ;
            public Task(string title, string description, DateTime dueDate, string  priority)
            {
                Title = title;
                Description = description;
                DueDate = dueDate;
                Priority = priority;
                Status = "pending";
            }
            
        }

        static Dictionary<string, Task> tasks = new Dictionary<string, Task>();
        static void Main(string[] args)
        {
            Console.WriteLine("----------------WELCOME  TO THE TASK TRACKER ----------------");
            while (true)
            {
                SystemInterface();
                var userChoice = Console.ReadLine();
                SelectOption(userChoice);
                AskUserIfWantToComplete();
            }

            static void SystemInterface()
            {
                Console.WriteLine("Choose an option: ");
                Console.Write("1. Add Task");
                Console.WriteLine("          2. Edit Task");
                Console.Write("3. Delete Task");
                Console.WriteLine("       4. Search Task");
                Console.Write("5. Display Tasks");
                Console.WriteLine("    6. Mark Task as Completed");
                Console.WriteLine("7. Exit");
            }

            static void AskUserIfWantToComplete()
            {
                Console.Write("you want to complete in program? (y/n): ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "n")
                {
                    Exit();
                }
            }
            static void SelectOption(string option)
            {
                switch (option)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        // Edit Task
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        // Search Task
                        break;
                    case "5":
                        DisplayTasks();
                        break;
                    case "6":
                        // Mark task As Completed
                        break;
                    case "7":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Option: ");
                        break;
                }
            }
            static void AddTask()
            {
                Console.WriteLine("Enter Task Title: ");
                var title = Console.ReadLine();
                Console.WriteLine("Enter Task Description: ");
                var description = Console.ReadLine();
                Console.WriteLine("Enter Task Due Date (DD-MM-YYYY): ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
                {
                    Console.WriteLine("Invalid date format. Try again.");
                    return;
                }
                Console.WriteLine("Enter Task Priority: ");
                var priority = Console.ReadLine();
                Task task = new Task(title , description, dueDate, priority);
                tasks.Add(title, task);
            }

            static void DeleteTask()
            {
                Console.WriteLine("Select task to delete: ");
                DisplayTasks();
                var selectedTask = Console.ReadLine();
                tasks.Remove(selectedTask);
            }
            static void Exit()
            {
                Console.WriteLine("Exit...");
                Environment.Exit(0);
            }
            static void DisplayTasks()
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine(task.Value.Title);
                    Console.WriteLine(task.Value.Description);
                    Console.WriteLine(task.Value.DueDate.ToShortDateString());
                    Console.WriteLine(task.Value.Priority);
                    Console.WriteLine(task.Value.Status);
                }
            }
        }
    }
    
}