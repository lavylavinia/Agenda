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
                        task = CitireTaskTastatura();
                        break;

                    case "A":
                        AfisareTask(task);
                        break;

                    case "F":
                        
                        nrtasks++;
                       Task[] tasks = new Task[20];
                       // tasks= File.ReadLines(FilePath);
                       // AfisareListaTaskuri(tasks, nrtasks);

                        break;

                    case "S":

                        nrtasks++;
                        var linecount = File.ReadAllLines(FilePath).Count();

                        var sw = new StreamWriter(FilePath);
                        //for (int i = linecount; i < 5; i++)
                          //  sw.WriteLine(task);
                        // sw.WriteLine(task);
                        int id = nrtasks + 1;
                        task.SetIdStudent(id);
                        sw.WriteLine(task);
                        nrtasks++;

                        break;
                    case "C":
                        lines = File.ReadAllLines(FilePath).ToList();
                        foreach (string line in lines)
                        {
                            string[] items = line.Split(' ');
                            task = new LibrarieModele.Task(Convert.ToInt32(items[0]), items[1], items[2]);
                           
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
        public static void AfisareTask(LibrarieModele.Task task)
        {
            string infoStudent = string.Format("Task-ul cu id-ul #{0} este: {1} {2}",
                   task.GetId(),
                   task.GetToDo() ?? " NECUNOSCUT ",
                   task.GetDeadline() ?? " NECUNOSCUT ");

            Console.WriteLine(infoStudent);
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

                AfisareTask(tasks[contor]);

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