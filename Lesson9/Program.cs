/*using System;
namespace ToDoList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our ToDoList app. In our app you can manage your tasks.");
            Console.WriteLine("Here is our sample tasks to do:");
            string[] ToDoList = {"Tidy up", "Do math", "Programming"};
            
            foreach(string i in ToDoList)
            {
                Console.WriteLine(i);
            }

            string [] Tasks = new string[10];
            for(int l = 0; l < 10; l++)
            {
                Console.WriteLine($"Enter the task number {l + 1}: ");
                Tasks[l] = Console.ReadLine();
            } 

            DisplayTasks(Tasks);

        }
        static void DisplayTasks(string[] array)
        {
            Console.WriteLine("Tasks to do: ");
            foreach (string k in array)
            {
                Console.WriteLine(k);
            }
        } 
    }
}
*/

using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tasks = new string[10]; 

            tasks[0] = "Tidy up";
            tasks[1] = "Do math";
            tasks[2] = "History";

            int taskCount = 3;

            Console.WriteLine("Sample Tasks:");
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. Change a task");
                Console.WriteLine("3. Display all tasks");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask(tasks, ref taskCount);
                        break;
                    case "2":
                        ChangeTask(tasks);
                        break;
                    case "3":
                        DisplayTasks(tasks, taskCount);
                        break;
                    case "4":
                        
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void AddTask(string[] tasks, ref int taskCount) //ref nima uchun ishlatilgan?
        {
            if (taskCount < tasks.Length)
            {
                Console.Write($"Enter the new task: ");
                string input = Console.ReadLine();
                tasks[taskCount] = input;
                taskCount++;
                Console.WriteLine("Task added.");
            }
            else
            {
                Console.WriteLine("Task list is full. You can't add more tasks.");
            }
        }

        static void ChangeTask(string[] tasks)
        {
            Console.Write("Enter the task number to change: ");
            int taskNumber = int.Parse(Console.ReadLine()) - 1;

            if (taskNumber >= 0 && taskNumber < tasks.Length)
            {
                Console.Write($"Enter the new value for task {taskNumber + 1}: ");
                tasks[taskNumber] = Console.ReadLine();
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number. No task was changed.");
            }
        }



        static void DisplayTasks(string[] tasks, int taskCount)
        {
            Console.WriteLine("All tasks:");
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}
