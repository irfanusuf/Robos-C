

using System;   
                

namespace testConsoleApp
{


    class Program
    {
        static List<string> toDoList = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("To-Do List Application");

                Console.WriteLine("1. Add Task");

                Console.WriteLine("2. Remove Task");

                Console.WriteLine("3. Display Tasks");

                Console.WriteLine("4. Exit");

                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        DisplayTasks();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter the task description: ");
            string task = Console.ReadLine();
            toDoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }




        static void RemoveTask()
        {
            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= toDoList.Count)
            {
                toDoList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }

        static void DisplayTasks()
        {
            if (toDoList.Count == 0)
            {
                Console.WriteLine("No tasks to display.");
            }
            else
            {
                Console.WriteLine("To-Do List:");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i]}");
                }
            }
        }
    }
}   

