using Delegates_hors_banque.Models;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        TaskDef task1 = new TaskDef("Apprendre C#");
        TaskDef task2 = new TaskDef("Faire de l'exercice");

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        taskManager.ExecuteActionOnTask("Apprendre C#", TaskActions.CompleteTask);
        taskManager.ExecuteActionOnTask("Faire de l'exercice", TaskActions.DisplayTask);
        taskManager.ExecuteActionOnTask("Apprendre C#", TaskActions.DisplayTask);
        taskManager.ExecuteActionOnTask("Faire de l'exercice", TaskActions.CancelTask);
    }
}