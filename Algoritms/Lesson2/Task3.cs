using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson2
{
    class Task3 : ITask
    {
        private string _taskNumber = "3";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = $"Практическая работа 2. Работа с двусвязным списком\t\t\t\t\t- задача 3";

        public string TaskName { get => _taskName; }

        public void TaskResultOutput()
        {
            DoubleLinkedList list = new DoubleLinkedList();

            for (int i = 0; i < 10; i++)
            {
                list.AddNode((i + 1) * 10);
            }
            Console.WriteLine($"Вновь созданный список");

            list.PrintDoubleLinkedList();

            int a = 50;

            int b = 999;

            int index = 8;

            list.AddNodeAfter(list.FindNode(a), b);

            Console.WriteLine($"Список после добавления элемента со значением {b} после элемента со значением {a}");

            list.PrintDoubleLinkedList();

            Console.WriteLine();

            list.RemoveNode(list.FindNode(50));

            Console.WriteLine($"Список после удаления элемента со значением {b}");

            list.PrintDoubleLinkedList();

            Console.WriteLine();

            list.RemoveNode(index);

            Console.WriteLine($"Список после удаления элемента с индексом {index}");

            list.PrintDoubleLinkedList();

            Console.WriteLine();
        }
    }
}
