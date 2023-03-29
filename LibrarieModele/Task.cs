using System;
using System.ComponentModel;
using System.Xml.Linq;
namespace LibrarieModele
{
    public class Task
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int id = 0;
        private const int TODO = 1;
        private const int DEADLINE = 2;

        private string todo, deadline;
        private int ID;
        //constructori fara parametri
        public Task(string line)
        {
            todo = string.Empty;
            deadline = string.Empty;
        }
        //constructori cu parametrii
        public Task(int _ID, string _todo, string _deadline)
        {
            this.ID = _ID;
            this.todo = _todo;
            this.deadline = _deadline;
        }
        //returneaza info despre task
        public string TaskInfo()
        {
            string info = string.Format("{0} {1}  {2}",
                 ID.ToString(), (todo ?? " UNKNOW "), (deadline ?? " UNKNOW "));
            return info;
        }
        /*public Task(string linieFisier, string v)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            ID = Convert.ToInt32(dateFisier[id]);
            todo= dateFisier[TODO];
            deadline = dateFisier[DEADLINE];
        }*/
        public string ConversieLaSir_PentruFisier(Task task)
        {
            string obiectTaskPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID.ToString(),
                (todo ?? " NECUNOSCUT "),
                (deadline ?? " NECUNOSCUT "));

            return obiectTaskPentruFisier;
        }
        public int GetId()
        {
            return ID;
        }

        public string GetToDo()
        {
            return todo;
        }

        public string GetDeadline()
        {
            return deadline;
        }
        public void SetIdStudent(int id)
        {
            this.ID = id;

        }
    }
}
