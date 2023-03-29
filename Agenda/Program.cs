using System;
using System.ComponentModel;
using System.Xml.Linq;
using System.Collections;

namespace Agenda
{
    static class Program
    {
        static void Main()
        {
            Task task = new Task();
            
            Console.WriteLine("Introdu task-ul: ");
            string ToDo = Console.ReadLine();
            Console.WriteLine("Introdu deadline-ul task-ului : ");
            string deadline = Console.ReadLine();
            task = new Task(ToDo, deadline);
            Console.WriteLine(task);
        }
    }
    public class Task
    {
        private string task, deadline;
        //constructori fara parametri
        public Task()
        {
            task = string.Empty;
            deadline = string.Empty;
        }
        //constructori cu parametrii
        public Task(string _todo, string _deadline)
        {
            task = _todo;
            deadline = _deadline;
        }
        //afiseaza data la care a fost creat
        public string CreatedDate
        {
            // get { return; }
            set { }
        }
        //returneaza daca task-ul a fost rezolvat sau nu
        public bool TaskDone
        {
            get { return false; }

        }
        //returneaza statusul task-ului
        public bool TaskStatus
        {
            get { return false; }
        }
        //returneaza info despre task
        public string TaskInfo()
        {
            return $"Task:";
        }

    }
    public class ToDoList
    {
        //creare lista de task-uri
        List<string> AllTasks = new List<string>();
        public ToDoList()
        {

        }
        public void AddTask()
        {

        }
        public void DeleteTask()
        {

        }

    }
}