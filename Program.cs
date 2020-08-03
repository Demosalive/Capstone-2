using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tasks> taskList = new List<Tasks>();

            while (true)
            {
                DisplayMenu();
                string input = Console.ReadLine();

                try
                {
                    int choice = int.Parse(input);
                    if (choice == 1)
                    {
                        TaskList(taskList);
                    }
                    else if (choice == 2)
                    {
                        AddTask(taskList);
                    }
                    else if (choice == 3)
                    {
                        DeleteTask(taskList);
                    }
                    else if (choice == 4)
                    {
                        CompletedTask(taskList);
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please select a number 1-5");
                }
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\nWelcome to the Task Manager");
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Mark Task Complete");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\nWhat would you like to do?");
        }

        public static void TaskList(List<Tasks> taskList)
        {
            int counter = 1;
            foreach (Tasks task in taskList)
            {
                Console.WriteLine($"{counter}:\tName: {task.Name}");
                Console.WriteLine($"\tDescriptiom: {task.Description}");
                Console.WriteLine($"\tDue Date: {task.DueDate}");
                Console.WriteLine($"\tCompleted: {task.Completed}");
                Console.WriteLine();
                counter++;
            }
        }

        public static void AddTask(List<Tasks> taskList)
        {
            Console.WriteLine("Please add name");
            string name = Console.ReadLine();

            Console.WriteLine("Please add description");
            string description = Console.ReadLine();

            Console.WriteLine("Please add due date");
            string dueDate = Console.ReadLine();

            Tasks all = new Tasks(name, description, dueDate, false);
            taskList.Add(all);
        }

        public static void DeleteTask(List<Tasks> taskList)
        {
            string answer = "";

            Console.WriteLine("Please input the number you wish to remove from the list");
            int input = int.Parse(Console.ReadLine());
            int index = input - 1;

            Console.WriteLine("Do you wish to delete task? (y/n)");
            answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Console.WriteLine($"{input} has been deleted");
                taskList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("\nNothing was deleted");
            }
        }

        public static void CompletedTask(List<Tasks> taskList)
        {
            string answer = "";

            Console.WriteLine("Please input the number you wish to mark as complete.");
            int input = int.Parse(Console.ReadLine());
            int index = input - 1;

            Console.WriteLine($"Are you sure you wish to mark {input} task as complete? (y/n)");
            answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Console.WriteLine($"{input} has been changed");
                taskList[index].Completed = true;
            }
            else
            {
                Console.WriteLine("\nNothing was changed.");
            }
        }
    }  
}


