using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_exception
{
    class JobImpossible : ApplicationException
    {
        public JobImpossible() { }
        public JobImpossible(string message) : base(message) { }
        public JobImpossible(string message, Exception innerException) : base(message, innerException) { }
    }

    class WorkerIsBusy : JobImpossible // работник уже чем-то занят
    {
        public WorkerIsBusy() { }
        public WorkerIsBusy(string message) : base(message) { }
        public WorkerIsBusy(string message, Exception innerException) : base(message, innerException) { }

        protected DateTime remaining_time;
        public DateTime RemainingTime
        {
            get { return remaining_time; }
            set { remaining_time = value; }
        }

        protected string work_description;
        public string WorkDescription
        {
            get { return work_description; }
            set { work_description = value; }
        }
    }

    class ForceMajor : JobImpossible // случилось что-то невероятное
    {
        public ForceMajor() { }
        public ForceMajor(string message) : base(message) { }
        public ForceMajor(string message, Exception innerException) : base(message, innerException) { }

        protected decimal damage;
        public decimal Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        protected string force_major_description;
        public string ForceMajorDescription
        {
            get { return force_major_description; }
            set { force_major_description = value; }
        }
    }

    class ToolsCrush : JobImpossible // я твой стекло ломал
    {
        public ToolsCrush() { }
        public ToolsCrush(string message) : base(message) { }
        public ToolsCrush(string message, Exception innerException) : base(message, innerException) { }

        protected string tool_crush_description;
        public string ToolCrushDescription
        {
            get { return tool_crush_description; }
            set { tool_crush_description = value; }
        }
    }

    class Worker
    {
        public bool isWorking = false;
        public void Work()
        {
            if (isWorking) throw new WorkerIsBusy("рабочий занят!");
            else
            {
                if (VerificateTools())
                {
                    isWorking = true;
                    Console.WriteLine("рабочий работает...");
                    //using System.Threading;
                    Thread.Sleep(1000);
                    isWorking = false;
                    Console.WriteLine("рабочий окончил работу.");
                }
                else throw new ToolsCrush("молоток сломался!");

            }
        }
        public bool VerificateTools()
        {
            Random r = new Random();
            int code = r.Next(0, 5);
            if (code != 0) return true;
            else return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker Andrew = new Worker();
            Andrew.Work();
        }
    }
}
