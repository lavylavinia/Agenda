using System;
using System.IO;

namespace NivelStocareDate
{
    public class TaskManagement
    {
        private const int NR_MAX_TASKS = 20;
        private string numeFisier = "Tasks.txt";

        public void AddTask(Task task)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                //      streamWriterFisierText.WriteLine(ConversieLaSir_PentruFisier(task));
            }
        }



        /*
         public Task[] GetTasks(out int nrtasks)
         {
             Task[] tasks = new Task[NR_MAX_TASKS];

             using (StreamReader streamReader = new StreamReader(numeFisier))
             {
                 string linieFisier;
                 nrtasks = 0;
                 while ((linieFisier = streamReader.ReadLine()) != null)
                 {
                     tasks[nrtasks++] = new Task(linieFisier);
                 }
             }

             return tasks;
         }*/
    }
}

