using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task12 : BaseTask
    {
        private readonly int _taskNumber = 12;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Очередь. Дек.\t\t\t\t\t\t\t\t- задача 12";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.WriteLine();

            var easyQueue = new EasyQueue<int>();

            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());

            Console.ReadKey(true);

            Console.WriteLine();

            var arrayQueue = new ArrayQueue<int>();

            arrayQueue.Enqueue(10);
            arrayQueue.Enqueue(11);
            arrayQueue.Enqueue(12);
            arrayQueue.Enqueue(13);
            arrayQueue.Enqueue(14);
            arrayQueue.Enqueue(15);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());

            Console.ReadKey(true);

            Console.WriteLine();

            var linkedQueue = new LinkedQueue<int>();

            linkedQueue.Enqueue(20);
            linkedQueue.Enqueue(21);
            linkedQueue.Enqueue(22);
            linkedQueue.Enqueue(23);
            linkedQueue.Enqueue(24);
            linkedQueue.Enqueue(25);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());

            Console.ReadKey(true);
        }

    }
}
