using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class Task5 : ITask
    {
        private string _taskNumber = "4";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Работа с бинарным деревом поиска";

        public string TaskName { get => _taskName; }




        public void TaskResultOutput()
        {
            Tree tree = new Tree();

            int count = 10; //задаем размер дерева

            //tree.CreateTree(count);
           
            tree.CreateDataLine(count);
            
            //tree.Add(12, "goooooooooo");
            
            //tree.Remove(5);
            
            //tree.Remove(8);
            
            //tree.Add(11);
            
            //tree.Add(10, "yaaaaaaaaaaa");
            
            //tree.Add(5, "YOOOOOOOOOOOO");
            
            //tree.PrintTreePrefixBypass();

            //tree.PrintTreePostfixBypass();

            tree.PrintTreeInfixBypass();

            Dictionary<int, object> dict = tree.TreeToDict();

            Console.WriteLine();

            foreach (var key in dict.Keys)
            {
                Console.WriteLine(dict[key]);
            }




            //object rrr = tree.Contains(5) ? tree.FindNode(5).Data : "Не найден";

            //object qqq = tree.FindNode(18).Data;

            //Console.WriteLine(rrr);

            //Console.WriteLine(qqq);

            Console.ReadKey();
        }
    }
}
