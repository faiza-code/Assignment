using MakeenAssignment.Assignment4.TaskTrackerApplication.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.TaskTrackerApplication.Models
{
    public class TaskList
    {
        public List <Task> Tasks = new List <Task> ();

        public List<Task> this[TaskPriority priority]
        {
            get
            {
                return Task.Equals(t => t.Priority == priority);
            }
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void MarkComplete(string taskTitle)
        {
            var task = Tasks.FirstOrDefault(t => t.Title.Equals(taskTitle, StringComparison.OrdinalIgnoreCase));
            if (task != null)
            {
                task.IsCompleted = true;
            }
            else
            {
                Console.WriteLine($"{taskTitle}  not found ");
            }
        }

        public void ShowAll()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("No tasks found");
                return;
            }

            foreach (var element in Tasks)
            {
                Console.WriteLine(element);
            }
        }


    }
}
