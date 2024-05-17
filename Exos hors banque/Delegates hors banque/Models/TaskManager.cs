using System;
using System.Collections.Generic;

namespace Delegates_hors_banque.Models
{
    internal class TaskManager
    {
        private List<TaskDef> tasks = new List<TaskDef>();

        public void AddTask(TaskDef task)
        {
            tasks.Add(task);
            Console.WriteLine($"Tâche '{task.Title}' ajoutée.");
        }

        public void ExecuteActionOnTask(string title, TaskAction action)
        {
            TaskDef task = tasks.Find(t => t.Title == title);
            if (task != null)
            {
                action(task);
            }
            else
            {
                Console.WriteLine($"Tâche '{title}' non trouvée.");
            }
        }
    }
}
