using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class Task5 : ITask
    {
        private string _taskNumber = "5";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Работа с бинарным деревом поиска";

        public string TaskName { get => _taskName; }


        private SortedDictionary<int, object> DataGenerate(int count)
        {
            SortedDictionary<int, object> sDict = new SortedDictionary<int, object>();

            for (int i = 1; i <= count; i++)
            {
                sDict.Add(i, String.Format($"Данные элемента №{i}"));
            }
            return sDict;
        }

        public void TaskResultOutput()
        {
            Tree tree = new Tree();

            int count = 10; //задаем размер дерева

            SortedDictionary<int, object> sDict = DataGenerate(count);

            tree.CreateTree(sDict);
                        
            tree.Add(12, "goooooooooo");
            
            tree.Remove(5);
            
            tree.Remove(8);
            
            tree.Add(11);
            
            tree.Add(10, "yaaaaaaaaaaa");
            
            tree.Add(5, "YOOOOOOOOOOOO");
            
            tree.PrintTreePrefixBypass();

            tree.PrintTreePostfixBypass();

            tree.PrintTreeInfixBypass();

            //Dictionary<int, object> dict = tree.TreeToDict();

            //Console.WriteLine();

            //foreach (var key in dict.Keys)
            //{
            //    Console.WriteLine(dict[key]);
            //}




            object rrr = tree.Contains(5) ? tree.FindNode(5).Data : "Не найден";

            object www = tree.Contains(18) ? tree.FindNode(18).Data : "Не найден";

            Console.WriteLine(rrr);

            Console.WriteLine(www);

            Console.ReadKey();
        }
    }
}
