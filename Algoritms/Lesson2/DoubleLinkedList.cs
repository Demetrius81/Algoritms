using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson2
{
    internal class DoubleLinkedList : INode, ITask
    {
        #region Поля и свойства

        /// <summary>
        /// Поле первый элемент списка
        /// </summary>
        private Node _firstNode;

        /// <summary>
        /// Свойство поля первый элемент списка
        /// </summary>
        public Node FirstNode { get => _firstNode; set => _firstNode = value; }

        /// <summary>
        /// Поле крайний элемент списка
        /// </summary>
        private Node _lastNode;

        /// <summary>
        /// Свойство поля крайний элемент списка
        /// </summary>
        public Node LastNode { get => _lastNode; set => _lastNode = value; }

        private string _taskNumber = "2";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Работа с двусвязным списком";

        public string TaskName { get => _taskName; }

        #endregion

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

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns>int количество элементов списка</returns>
        public int GetCount()
        {
            int i = 1;

            if (FirstNode == LastNode)
            {
                return i;
            }
            else
            {
                Node currentNode = FirstNode;

                do
                {
                    i++;

                    currentNode = currentNode.NextNode;

                } while (currentNode.NextNode != null);
            }
            return i;
        }

        /// <summary>
        /// Добавляет новый элемент списка
        /// </summary>
        /// <param name="value">int новый элемент списка</param>
        public void AddNode(int value)
        {
            Node newNode = new Node(value);

            if (FirstNode == null)
            {
                FirstNode = newNode;

                LastNode = newNode;
            }
            else
            {
                Node currentNode = LastNode;

                currentNode.NextNode = newNode;

                newNode.PrevNode = currentNode;

                LastNode = newNode;
            }
        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node">Node элемент, после которого нужно добавить новый элемент</param>
        /// <param name="value">int новый элемент списка</param>
        public void AddNodeAfter(Node userNode, int value)
        {
            Node newNode = new Node(value);

            if (userNode != LastNode)
            {
                Node nextNode = userNode.NextNode;

                nextNode.PrevNode = newNode;

                userNode.NextNode = newNode;

                newNode.NextNode = nextNode;

                newNode.PrevNode = userNode;
            }
            else
            {
                userNode.NextNode = newNode;

                newNode.PrevNode = userNode;

                LastNode = newNode;
            }


        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index">int индекс удаляемого элемента</param>
        public void RemoveNode(int index)
        {
            int temp = GetCount();

            Node currentNode = FirstNode;

            if (temp < index)
            {
                return;
            }

            for (int i = 1; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }

            RemoveNode(currentNode);
        }

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        /// <param name="node">Node элемент списка, который нужно удалить</param>
        public void RemoveNode(Node userNode)
        {
            Node prevNode = userNode.PrevNode;

            Node nextvNode = userNode.NextNode;

            if (userNode != LastNode && userNode != FirstNode)
            {
                prevNode.NextNode = userNode.NextNode;

                nextvNode.PrevNode = userNode.PrevNode;
            }

            if (userNode == LastNode)
            {
                prevNode.NextNode = null;

                LastNode = prevNode;
            }

            if (userNode == FirstNode)
            {
                nextvNode.PrevNode = null;

                FirstNode = nextvNode;
            }
        }

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue">int значение элемента, который нужно найти</param>
        /// <returns>Node искомый элемент</returns>
        public Node FindNode(int searchValue)
        {
            Node currentNode = FirstNode;

            while (currentNode.Value != searchValue)
            {
                if (currentNode == LastNode && currentNode.Value != searchValue)
                {
                    return null;
                }

                currentNode = currentNode.NextNode;
            }
            return currentNode;
        }

        /// <summary>
        /// Выводит в консоль список
        /// </summary>
        private void PrintDoubleLinkedList()
        {
            Node currentNode = FirstNode;

            int count = GetCount();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"  {currentNode.Value}");

                currentNode = currentNode.NextNode;
            }
            Console.WriteLine();
        }


    }
}
