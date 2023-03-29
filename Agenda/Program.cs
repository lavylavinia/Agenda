using System;
using System.Configuration;
using System.Threading.Channels;
using System.IO;
namespace Agenda
{
    class Program
    {

        static void Main()
        {
            LibrarieModele.Task task = new LibrarieModele.Task(0, null, null);
            //string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string FilePath = "Tasks.txt";
            //TaskManagement adminTaskuri = new TaskManagement(Path);
            List<string> lines = new List<string>();
            int nrtasks = 0;

            string optiune;
            do
            {
                Console.WriteLine("I. Introduceti informatii task");
                Console.WriteLine("A. Afisare task-uri");
                Console.WriteLine("F. Afisare task-uri din fisier");
                Console.WriteLine("S.Salvare task din fisier");
                Console.WriteLine("C. Preluare date fisier");
                Console.WriteLine("Alegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        int ID = nrtasks + 1;
                        Console.WriteLine("Introdu task-ul {0} : ", ID);
                        string ToDo = Console.ReadLine();
                        Console.WriteLine("Introdu deadline-ul task-ului {0} : ", ID);
                        string deadline = Console.ReadLine();
                        task = new LibrarieModele.Task(ID, ToDo, deadline);
                        nrtasks++;
                        // task = CitireTaskTastatura();
                        break;

                    case "A":
                        string infoTask = task.TaskInfo();
                        Console.WriteLine("{0} {1}", nrtasks, infoTask);

                        break;

                    case "F":
                        ID = nrtasks + 1;
                        nrtasks++;
                        Task[] tasks = new Task[20];
                        //  AfisareListaTaskuri(tasks, nrtasks);

                        break;

                    case "S":
                        ID = nrtasks++;
                        nrtasks++;
                        var linecount = File.ReadAllLines(FilePath).Count();

                        var sw = new StreamWriter(FilePath);
                        for (int i = linecount; i < 5; i++)
                            sw.WriteLine(task);
                        // sw.WriteLine(task);


                        break;
                    case "C":
                        lines = File.ReadAllLines(FilePath).ToList();
                        foreach (string line in lines)
                        {
                            string[] items = line.Split(' ');
                            task = new LibrarieModele.Task(Convert.ToInt32(items[0]), items[1], items[2]);
                            nrtasks++;
                        }

                        break;

                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");
            Console.ReadKey();

        }


        public static void AfisareListaTaskuri(LibrarieModele.Task[] tasks, int nrtasks)
        {
            Console.WriteLine("ToDo list:");
            for (int contor = 0; contor < nrtasks; contor++)
            {
                string infoTask = string.Format("Task-ulcu ID #{0} este: {1} {2}",
                   tasks[contor].GetId(),
                   tasks[contor].GetToDo() ?? " NECUNOSCUT ",
                   tasks[contor].GetDeadline() ?? " NECUNOSCUT ");

                Console.WriteLine(infoTask);

            }

        }
        public static LibrarieModele.Task CitireTaskTastatura()
        {
            Console.WriteLine("Introduceti task-ul:");
            string todo = Console.ReadLine();

            Console.WriteLine("Introduceti deadline:");
            string deadline = Console.ReadLine();

            LibrarieModele.Task student = new LibrarieModele.Task(0, todo, deadline);

            return student;
        }




    }
}