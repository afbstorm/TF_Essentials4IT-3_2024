using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_hors_banque.Models
{
    internal class TaskActions
    {
        public static void CompleteTask(TaskDef task)
        {
            task.IsCompleted = true;
            Console.WriteLine($"Tâche '{task.Title}' marquée comme terminée.");
        }

        public static void CancelTask(TaskDef task)
        {
            Console.WriteLine($"Tâche '{task.Title}' annulée.");
        }

        public static void DisplayTask(TaskDef task)
        {
            task.Display();
        }
    }
}
