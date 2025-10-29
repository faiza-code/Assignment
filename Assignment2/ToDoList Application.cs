using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    public class ToDoList_Application
    {
        const int maxTasks = 100;
        static string[] tasks = new string[maxTasks];
        static bool[] isCompleted = new bool[maxTasks];
        static int count = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("To-Do List Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. View Tasks");
                Console.WriteLine("5. Clear Completed Tasks");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int userVlue = int.Parse(Console.ReadLine());

                switch (userVlue)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        DeleteTask();
                        break;
                    case 3:
                        MarkCompleted();
                        break;
                    case 4:
                        ViewTasks();
                        break;
                    case 5:
                        ClearCompletedTasks();
                        break;
                    case 6:
                        Console.WriteLine("Exiting application...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void AddTask()
        {
            if (count >= maxTasks)
            {
                Console.WriteLine("Task list is full.");
                return;
            }

            Console.Write("Enter new task description: ");
            string task = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(task))
            {
                Console.WriteLine("Task description cannot be empty.");
                return;
            }

            tasks[count] = task;
            isCompleted[count] = false;
            count++;
            Console.WriteLine("Task added.");
        }

        static void DeleteTask()
        {
            if (count == 0)
            {
                Console.WriteLine("No tasks to delete.");
                return;
            }

            ViewTasks();
            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= count)
            {
                index--; 

                for (int i = index; i < count - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                    isCompleted[i] = isCompleted[i + 1];
                }

                
                tasks[count - 1] = null;
                isCompleted[count - 1] = false;
                count--;

                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void MarkCompleted()
        {
            if (count == 0)
            {
                Console.WriteLine("No tasks to mark.");
                return;
            }

            ViewTasks();
            Console.Write("Enter task number to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= count)
            {
                index--; 
                isCompleted[index] = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void ViewTasks()
        {
            if (count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            Console.WriteLine("Tasks List:");
            for (int i = 0; i < count; i++)
            {
                string status = isCompleted[i] ? "Done" : "Pending";
                Console.WriteLine($"{i + 1}. {tasks[i]} [{status}]");
            }
        }

        static void ClearCompletedTasks()
        {
            if (count == 0)
            {
                Console.WriteLine("No tasks to clear.");
                return;
            }

            int originalCount = count;
            for (int i = 0; i < count;)
            {
                if (isCompleted[i])
                {
                    
                    for (int j = i; j < count - 1; j++)
                    {
                        tasks[j] = tasks[j + 1];
                        isCompleted[j] = isCompleted[j + 1];
                    }

                    tasks[count - 1] = null;
                    isCompleted[count - 1] = false;
                    count--;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine($"Cleared {originalCount - count} completed tasks.");
        }
    }
}

