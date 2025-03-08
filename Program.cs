namespace TaskTrackerWithoutOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------WELCOME  TO THE TASK TRACKER ----------------");
            while (true)
            {
                Console.WriteLine("Choose an option: ");
                Console.Write("1. Add Task");
                Console.WriteLine("          2. Edit Task");
                Console.Write("3. Delete Task");
                Console.WriteLine("       4. Search Task");
                Console.Write("5. View All Tasks");
                Console.WriteLine("    6. Mark Task as Completed");
                Console.WriteLine("7. Exit");
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        // Add Task 
                        break;
                    case "2":
                        // Edit Task
                        break;
                    case "3":
                        // Delete Task
                        break;
                    case "4":
                        // Search Task
                        break;
                    case "5":
                        // View All Tasks
                        break;
                    case "6":
                        // Mark task As Completed
                        break;
                    case "7":
                        // Exit
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Option: ");
                        break;
                }
            }
        }
    }
    
}