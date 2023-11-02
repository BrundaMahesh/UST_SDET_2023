﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public int TaskID {  get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted {  get; set; }
        public static List<TaskItem> taskItems = new List<TaskItem>();

        public TaskItem(int taskID, string? taskDescription, bool isCompleted)
        {
            TaskID = taskID;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public void AddTask(int taskID,string? taskDescription,bool isCompleted)
        {
           taskItems.Add(new TaskItem(TaskID=taskID, TaskDescription=taskDescription, IsCompleted=isCompleted));
        }

        public void RemoveTask(int taskID)
        {
            var remove=taskItems.Find(x => x.TaskID==taskID);
            if(remove != null)
                taskItems.Remove(remove);
            else
                Console.WriteLine("No task found with this task id");
        }
        public void MarkAsCompleted(int taskID)
        {
            var completed=taskItems.Find(x=>x.TaskID==taskID);
            if (completed != null)
            {
                completed.IsCompleted = true;
            }
            else
            {
                Console.WriteLine("No task found with this task id");
            }
        }

        public void DisplayTask()
        {
            Console.WriteLine("To-Do list:");

        }
    }
}
