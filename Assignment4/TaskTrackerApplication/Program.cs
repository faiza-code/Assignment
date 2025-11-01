using MakeenAssignment.Assignment4.TaskTrackerApplication.Enum;
using MakeenAssignment.Assignment4.TaskTrackerApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.TaskTrackerApplication
{
    public class Program
    { 
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();

            
            taskList.AddTask(new Task("Solve the assignment", " Assignment Basic C# , OOP1", TaskPriority.High,true));
            taskList.AddTask(new Task("Room cleaning", "At Saturday ", TaskPriority.Medium,false));
            taskList.AddTask(new Task("Make Call", "Call me Besti frind", TaskPriority.Low ,true));

            
            Console.WriteLine("All tasks:");
            taskList.ShowAll();

            
            Console.WriteLine("High priority tasks:");
            foreach (var task in taskList[TaskPriority.High])
            {
                Console.WriteLine(task);
            }

            
            taskList.MarkComplete("Room Cleaning");

            Console.WriteLine("Show all  marking:");
            taskList.ShowAll();
        
        }
    }
}
