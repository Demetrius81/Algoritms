using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task11 : BaseTask
    {
        private readonly int _taskNumber = 11;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Стек.\t\t\t\t\t\t\t\t\t- задача 11";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            EazyStack<int> eazyStack = new EazyStack<int>();

            eazyStack.Push(1);
            eazyStack.Push(2);
            eazyStack.Push(3);
            eazyStack.Push(4);
            eazyStack.Push(5);
            eazyStack.Push(6);
            eazyStack.Push(7);
            eazyStack.Push(8);
            eazyStack.Push(9);

            var item = eazyStack.Pop();
            var item2 = eazyStack.Peek();

            Console.WriteLine();

            Console.WriteLine(item);
            Console.WriteLine(item2);

            Console.ReadKey(true);

            var linkedStack = new LinkedStack<int>();

            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());

            Console.ReadKey(true);

            var arrayStack = new ArrayStack<int>(5);

            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Count);
            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Count);
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());

            Console.ReadKey(true);
        }

    }
}
