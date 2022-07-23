using System;


namespace Algoritms
{
    public abstract class BaseTask : ITask
    {
        public abstract int TaskNumber { get; }
                
        public abstract string TaskName { get; }

        public virtual void TaskResultOutput()
        {            
            Console.WriteLine("Метод не определен. Нажмите любую клавишу...");

            Console.ReadKey();
        }


    }

}
