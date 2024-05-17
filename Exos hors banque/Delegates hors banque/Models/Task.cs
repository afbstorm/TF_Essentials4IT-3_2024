using System;

namespace Delegates_hors_banque.Models
{
    internal class TaskDef
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;

        public TaskDef(string title)
        {
            Title = title;
        }

        public void Display()
        {
            Console.WriteLine($"Tâche : {Title}, Terminée : {IsCompleted}");
        }
    }
}
