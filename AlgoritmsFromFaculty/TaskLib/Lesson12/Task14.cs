using Algoritms.Lesson12;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task14 : BaseTask
    {
        private readonly int _taskNumber = 14;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Хеш-таблицы.\t\t\t\t\t\t\t\t- задача 14";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            var superHashtable = new SuperHashTable<Person>();
            Person person = new Person("Богдан", 29, 0);
            Person person2 = new Person("Катя", 24, 1);
            Person person3 = new Person("Вася", 25, 0);
            superHashtable.Add(person3);
            superHashtable.Add(new Person("Петя", 27, 0));
            superHashtable.Add(new Person("Володя", 22, 0));
            superHashtable.Add(person2);
            superHashtable.Add(new Person("Борис", 38, 0));

            Console.WriteLine(superHashtable.Search(person));
            Console.WriteLine(superHashtable.Search(person2));
            Console.WriteLine(superHashtable.Search(person3));

            Console.WriteLine();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));

            Console.WriteLine();

            var hashtable = new HashTable<int, string>();
            hashtable.Add(5, "hello");
            hashtable.Add(18, "world");
            hashtable.Add(777, "how do you do");
            hashtable.Add(7, "programmer");

            Console.WriteLine(hashtable.Search(6, "Vasiliy"));
            Console.WriteLine(hashtable.Search(18, "world"));

            Console.WriteLine();

        }

    }
}
