using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class Tree
    {
        /// <summary>
        /// Поле корневой элемент дерева
        /// </summary>
        private NodeOfTree _rootNode;

        /// <summary>
        /// Свойство поля корневой элемент дерева
        /// </summary>
        public NodeOfTree RootNode { get => _rootNode; set => _rootNode = value; }

        /// <summary>
        /// Поле размер дерева
        /// </summary>
        private int _count;

        /// <summary>
        /// Свойство поля размер дерева
        /// </summary>
        public int Count { get => _count; set => _count = value; }

        /// <summary>
        /// Метод строит дерево из 10 элементов и заполныет его данными извне
        /// </summary>
        /// <param name="sDict">SortedDictionary<int, object> источник данных для дерева</param>
        public void BuildTreeByHands(SortedDictionary<int, object> sDict)
        {
            Add(5, sDict[5]);
            Add(3, sDict[3]);
            Add(1, sDict[1]);
            Add(2, sDict[2]);
            Add(4, sDict[4]);
            Add(8, sDict[8]);
            Add(7, sDict[7]);
            Add(6, sDict[6]);
            Add(9, sDict[9]);
            Add(10, sDict[10]);
        }

        #region Метод работает, но заполняет не деревом а линией от корня влево и вправо.

        /// <summary>
        /// Метод создает и заполняет дерево данными из внешнего источника
        /// </summary>
        /// <param name="sDict">SortedDictionary<int, object> источник данных для дерева</param>
        public void CreateTree(SortedDictionary<int, object> sDict)
        {
            int count = sDict.Count;

            int n = 0;

            //int nl = 0;

            //int nr = 0;

            NodeOfTree newNode = null;

            if (count == 0)

                return;

            else
            {
                if (count % 2 != 0)
                {
                    n = count / 2 + 1;

                    //nl = count - n;

                    //nr = count - n;
                }
                else
                {
                    n = count / 2;

                    //nl = count - n - 1;

                    //nr = count - n;
                }
                newNode = new NodeOfTree(n, sDict[n]);

                if (RootNode == null)
                {
                    RootNode = newNode;
                }
                for (int i = n - 1; i >= 1; i--)
                {
                    Add(i, sDict[i]);
                }

                for (int i = count; i > n; i--)
                {
                    Add(i, sDict[i]);
                }
            }
        }

        #endregion

        /// <summary>
        /// Метод вычисляет находится ли элемент с указанным индексом в дереве
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns>bool возврашает результат вычисления</returns>
        public bool Contains(int index)
        {
            NodeOfTree parent;

            return FindWithParent(out parent, index) != null;
        }

        /// <summary>
        /// Метод поиска узла по индексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns></returns>
        public NodeOfTree FindNode(int index)
        {
            NodeOfTree parent;

            NodeOfTree node = Contains(index) ? FindWithParent(out parent, index) : new NodeOfTree();

            return node;
        }

        /// <summary>
        /// Метод производит поиск элемента дерева с указанным индексом
        /// </summary>
        /// <param name="parent">NodeOfTree возвращает родительский элемент искомого элемента</param>
        /// <param name="index">index индекс элемента</param>
        /// <returns>NodeOfTree искомый элемент</returns>
        private NodeOfTree FindWithParent(out NodeOfTree parent, int index)
        {
            NodeOfTree current = RootNode;

            parent = null;

            while (current != null)
            {
                if (current.Index > index)
                {
                    parent = current;

                    current = current.LeftNode;
                }
                else if (current.Index < index)
                {
                    parent = current;

                    current = current.RightNode;
                }
                else
                {
                    break;
                }
            }
            return current;
        }

        /// <summary>
        /// Метод добавляет элемент дерева по индексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        public void Add(int index)
        {
            if (RootNode == null)
            {
                NodeOfTree nodeOfTree = new NodeOfTree(index);

                RootNode = nodeOfTree;
            }
            else
            {
                AddTo(RootNode, index);
            }
            Count++;
        }

        /// <summary>
        /// Метод добавляет элемент дерева по индексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <param name="data">object хранимые данные</param>
        public void Add(int index, object data)
        {
            if (RootNode == null)
            {
                NodeOfTree nodeOfTree = new NodeOfTree(index, data);

                RootNode = nodeOfTree;
            }
            else
            {
                AddTo(RootNode, index, data);
            }
            Count++;
        }

        /// <summary>
        /// Метод добавляет элемент дерева рекурсивным способом
        /// </summary>
        /// <param name="node">NodeOfTree узел дерева</param>
        /// <param name="index">int индекс элемента</param>
        private void AddTo(NodeOfTree node, int index)
        {
            if (index < node.Index)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new NodeOfTree(index);
                }
                else
                {
                    AddTo(node.LeftNode, index);
                }
            }
            else if (index > node.Index)
            {
                if (node.RightNode == null)
                {
                    node.RightNode = new NodeOfTree(index);
                }
                else
                {
                    AddTo(node.RightNode, index);
                }
            }
        }

        /// <summary>
        /// Метод добавляет элемент дерева рекурсивным способом
        /// </summary>
        /// <param name="node">NodeOfTree узел дерева</param>
        /// <param name="index">int индекс элемента</param>
        /// <param name="data">object хранимые данные</param>
        private void AddTo(NodeOfTree node, int index, object data)
        {
            if (index < node.Index)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new NodeOfTree(index, data);
                }
                else
                {
                    AddTo(node.LeftNode, index, data);
                }
            }
            else if (index > node.Index)
            {
                if (node.RightNode == null)
                {
                    node.RightNode = new NodeOfTree(index, data);
                }
                else
                {
                    AddTo(node.RightNode, index, data);
                }
            }
            else if (index == node.Index)
            {
                node.Data = data;

                Count--;
            }
        }

        /// <summary>
        /// Метод удаляет элемент дерева по индексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns>bool возвращает значение удален ли элемент</returns>
        public bool Remove(int index)
        {
            NodeOfTree current;

            NodeOfTree parent;

            current = FindWithParent(out parent, index);

            if (current == null)
            {
                return false;
            }
            Count--;

            //если нет детей справа

            if (current.RightNode == null)
            {
                if (parent == null)
                {
                    //левый ребенок встает на место удаляемого

                    RootNode = current.LeftNode;
                }
                else
                {
                    //если значение родителя больше текущего

                    if (parent.Index > current.Index)
                    {
                        //левый ребенок текущего узла становится левым ребенком родителя

                        parent.LeftNode = current.LeftNode;
                    }
                    //если значение родителя меньше текущего

                    else if (parent.Index < current.Index)
                    {
                        //левый ребенок текущего узла становится правым ребенком родителя

                        parent.RightNode = current.LeftNode;
                    }
                }
            }
            //если у правого ребенка нет детей слева

            else if (current.RightNode.LeftNode == null)
            {
                //он занимает место удаляемого узла

                current.RightNode.LeftNode = current.LeftNode;

                if (parent == null)
                {
                    RootNode = current.RightNode;
                }
                else
                {
                    //усли значение родителя больше текущего

                    if (parent.Index > current.Index)
                    {
                        //правый ребенок текущего узла становится левым ребенком родителя

                        parent.LeftNode = current.RightNode;
                    }
                    //если значение родителя меньше текущего

                    else if (parent.Index < current.Index)
                    {
                        //правый ребенок текущего узла становится правым ребенком родителя

                        parent.RightNode = current.RightNode;
                    }
                }
            }
            //если у правого ребенка есть дети слева

            //крайний левый ребенок из правого поддерева заменяет удаляемый узел

            else
            {
                //находим крайний левый узел

                NodeOfTree leftMost = current.RightNode.LeftNode;

                NodeOfTree leftMostParent = current.RightNode;

                while (leftMost.LeftNode != null)
                {
                    leftMostParent = leftMost;

                    leftMost = leftMost.LeftNode;
                }
                //левое поддерево родителя становится правым поддеревом крайнего левого узла

                leftMostParent.LeftNode = leftMost.RightNode;

                //левый и правый ребенок текущего узла становится левым и правым ребенком крайнего левого

                leftMost.LeftNode = current.LeftNode;

                leftMost.RightNode = current.RightNode;

                if (parent == null)
                {
                    RootNode = leftMost;
                }
                else
                {
                    //если значение родителя больше текущего

                    if (parent.Index > current.Index)
                    {
                        //крайний левый узел становится левым ребенком родителя

                        parent.LeftNode = leftMost;
                    }
                    //если значение родителя меньше текущего

                    else if (parent.Index < current.Index)
                    {
                        //крайний левый узел становится правым ребенком родителя

                        parent.RightNode = leftMost;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Метод запускает префиксный обход дерева
        /// </summary>
        public void PrintTreePrefixBypass(string str)
        {
            Console.Clear();

            Console.WriteLine($"{str}");

            PrintTreePrefixBypass(RootNode);

            Console.WriteLine($"Чтобы продолжить нажмите любую клавишу");

            Console.ReadKey();
        }

        /// <summary>
        /// Префиксный обход дерева рекурсией с выводом в консоль элементов
        /// </summary>
        /// <param name="node">NodeOfTree string строковая переменная - попытка вывести дерево со ступенями</param>
        private void PrintTreePrefixBypass(NodeOfTree node)
        {
            if (node != null)
            {
                Console.WriteLine(String.Format($"{node.Index}\t{node.Data}"));

                PrintTreePrefixBypass(node.LeftNode);

                PrintTreePrefixBypass(node.RightNode);
            }
        }

        /// <summary>
        /// Метод запускает постфиксный обход дерева
        /// </summary>
        public void PrintTreePostfixBypass(string str)
        {
            Console.Clear();

            Console.WriteLine($"{str}");

            PrintTreePostfixBypass(RootNode);

            Console.WriteLine($"Чтобы продолжить нажмите любую клавишу");

            Console.ReadKey();
        }

        /// <summary>
        /// Постфиксный обход дерева рекурсией с выводом в консоль элементов
        /// </summary>
        /// <param name="node">NodeOfTree string строковая переменная - попытка вывести дерево со ступенями</param>        
        private void PrintTreePostfixBypass(NodeOfTree node)
        {
            if (node != null)
            {
                PrintTreePostfixBypass(node.LeftNode);

                PrintTreePostfixBypass(node.RightNode);

                Console.WriteLine(String.Format($"{node.Index}\t{node.Data}"));
            }
        }

        /// <summary>
        /// Метод запускает инфиксный обход дерева
        /// </summary>
        public void PrintTreeInfixBypass(string str)
        {
            Console.Clear();

            Console.WriteLine($"{str}");

            PrintTreeInfixBypass(RootNode);

            Console.WriteLine($"Чтобы продолжить нажмите любую клавишу");

            Console.ReadKey();
        }

        /// <summary>
        /// Инфиксный обход дерева рекурсией с выводом в консоль элементов
        /// </summary>
        /// <param name="node">NodeOfTree string строковая переменная - попытка вывести дерево со ступенями</param>
        private void PrintTreeInfixBypass(NodeOfTree node)
        {
            if (node != null)
            {
                PrintTreeInfixBypass(node.LeftNode);

                if (node.Data != null)
                {
                    Console.WriteLine(string.Format($"{node.Index}\t{node.Data}"));
                }

                PrintTreeInfixBypass(node.RightNode);
            }
        }
    }
}
