using MakeenAssignment.Assignment4.TaskTrackerApplication.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.TaskTrackerApplication.Models
{
    public class Task
    {
        public string Title  { get; set; }
        public string Description  { get; set; }
        public TaskPriority Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string description, TaskPriority priority, bool isCompleted)
        {
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = isCompleted;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Task Title : {Title} Descripation Of Task : {Description} Level of Task : {Priority} Status Of Task : {IsCompleted}");
        }

    }
}
