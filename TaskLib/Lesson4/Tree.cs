using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms
{
    /// <summary>
    /// Клласс бинарное дерево поиска
    /// </summary>
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
        /// Метод получает на вход данные, преобразует их и вызывает метод построения дерева поиска
        /// </summary>
        /// <param name="sDict">SortedDictionary<int, object> отсортированный список ключей и данных, связанных с этими ключами</param>
        public void BuildTree(SortedDictionary<int, object> sDict)
        {
            List<int> keys = new List<int>();

            List<object> data = new List<object>();

            foreach (int key in sDict.Keys)
            {
                keys.Add(key);

                data.Add(sDict[key]);
            }

            AddListOfNodes(keys, data);
        }

        /// <summary>
        /// Метод создает и заполняет дерево данными из внешнего источника
        /// </summary>
        /// <param name="keys">List<int> ключи для поиска даных</param>
        /// <param name="data">List<object>данные</param>
        /// <returns></returns>
        private NodeOfTree AddListOfNodes(List<int> keys, List<object> data)
        {
            Count = keys.Count;

            int n = keys.Count;

            NodeOfTree newNode;

            if (n == 0)
            {
                return null;
            }
            else
            {
                int nMed;

                int nLeft;

                int nRight;

                if (n % 2 != 0)
                {
                    nMed = n / 2 + 1;

                    nLeft = n - nMed;

                    nRight = n - nMed;
                }
                else
                {
                    nMed = n / 2;

                    nLeft = n - nMed - 1;

                    nRight = n - nMed;
                }
                newNode = new NodeOfTree(keys[nMed - 1], data[nMed - 1]);

                if (RootNode == null)
                {
                    RootNode = newNode;
                }
                if (nLeft != 0)
                {
                    List<int> keysLeftSholder = new List<int>();

                    List<object> dataLeftShoulder = new List<object>();

                    for (int i = 0; i < nMed - 1; i++)
                    {
                        keysLeftSholder.Add(keys[i]);

                        dataLeftShoulder.Add(data[i]);
                    }
                    newNode.LeftNode = AddListOfNodes(keysLeftSholder, dataLeftShoulder);

                }
                if (nRight != 0)
                {
                    List<int> keysRightSholder = new List<int>();

                    List<object> dataRightShoulder = new List<object>();

                    for (int i = nMed; i < n; i++)
                    {
                        keysRightSholder.Add(keys[i]);

                        dataRightShoulder.Add(data[i]);
                    }
                    newNode.RightNode = AddListOfNodes(keysRightSholder, dataRightShoulder);

                }
            }
            return newNode;
        }

        /// <summary>
        /// Метод вычисляет находится ли элемент с указанным индексом в дереве
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns>bool возврашает результат вычисления</returns>
        public bool Contains(int index)
        {
            return FindWithParent(out _, index) != null;
        }

        /// <summary>
        /// Метод поиска узла по индексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns>NodeOfTree искомый узел</returns>
        public NodeOfTree FindNode(int index)
        {
            NodeOfTree node = Contains(index) ? FindWithParent(out _, index) : new NodeOfTree();

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

            current = FindWithParent(out NodeOfTree parent, index);

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

            PrefixBypass(RootNode);

            Console.WriteLine($"Чтобы продолжить нажмите любую клавишу");

            Console.ReadKey();
        }

        /// <summary>
        /// Префиксный обход дерева рекурсией с выводом в консоль элементов
        /// </summary>
        /// <param name="node">NodeOfTree string строковая переменная - попытка вывести дерево со ступенями</param>
        private void PrefixBypass(NodeOfTree node)
        {
            if (node != null)
            {
                Console.WriteLine(String.Format($"{node.Index}\t{node.Data}"));

                PrefixBypass(node.LeftNode);

                PrefixBypass(node.RightNode);
            }
        }

        /// <summary>
        /// Метод запускает постфиксный обход дерева
        /// </summary>
        public void PrintTreePostfixBypass(string str)
        {
            Console.Clear();

            Console.WriteLine($"{str}");

            PostfixBypass(RootNode);

            Console.WriteLine($"Чтобы продолжить нажмите любую клавишу");

            Console.ReadKey();
        }

        /// <summary>
        /// Постфиксный обход дерева рекурсией с выводом в консоль элементов
        /// </summary>
        /// <param name="node">NodeOfTree string строковая переменная - попытка вывести дерево со ступенями</param>        
        private void PostfixBypass(NodeOfTree node)
        {
            if (node != null)
            {
                PostfixBypass(node.LeftNode);

                PostfixBypass(node.RightNode);

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

            InfixBypass(RootNode);

            Console.WriteLine($"Чтобы продолжить нажмите любую клавишу");

            Console.ReadKey();
        }

        /// <summary>
        /// Инфиксный обход дерева рекурсией с выводом в консоль элементов
        /// </summary>
        /// <param name="node">NodeOfTree string строковая переменная - попытка вывести дерево со ступенями</param>
        private void InfixBypass(NodeOfTree node)
        {
            if (node != null)
            {
                InfixBypass(node.LeftNode);

                if (node.Data != null)
                {
                    Console.WriteLine(string.Format($"{node.Index}\t{node.Data}"));
                }

                InfixBypass(node.RightNode);
            }
        }

        /// <summary>
        /// Метод поиска в ширину
        /// </summary>
        /// <param name="index">int ключ для поиска</param>
        /// <returns>object значение - результат поиска</returns>
        public object SerchByBFS(int index)
        {
            Queue<NodeOfTree> queue = new Queue<NodeOfTree>();

            queue.Enqueue(RootNode);

            while (queue.Count != 0)
            {
                {//контроль состояния очереди
                    List<NodeOfTree> list = new List<NodeOfTree>();

                    list = queue.ToList();

                    Console.WriteLine($"Текущее состояние очереди");

                    foreach (NodeOfTree node in list)
                    {
                        Console.Write(" " + node.Index);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Нажмите любую клавишу...");

                    Console.ReadKey();
                }
                NodeOfTree nod = queue.Dequeue();

                if (index == nod.Index)
                {
                    return nod.Data;
                }

                if (nod.LeftNode != null)
                {
                    queue.Enqueue(nod.LeftNode);
                }
                if (nod.RightNode != null)
                {
                    queue.Enqueue(nod.RightNode);
                }
            }
            return null;
        }

        /// <summary>
        /// Метод поиска в глубину
        /// </summary>
        /// <param name="index">int ключ для поиска</param>
        /// <returns>object значение - результат поиска</returns>
        public object SerchByDFS(int index)
        {
            Stack<NodeOfTree> stack = new Stack<NodeOfTree>();

            stack.Push(RootNode);

            while (stack.Count != 0)
            {
                {//контроль состояния стека
                    List<NodeOfTree> list = new List<NodeOfTree>();

                    list = stack.ToList();

                    Console.WriteLine("Текущее состояние стека");

                    foreach (NodeOfTree node in list)
                    {
                        Console.Write(" " + node.Index);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Нажмите любую клавишу...");

                    Console.ReadKey();
                }
                NodeOfTree nod = stack.Pop();

                if (index == nod.Index)
                {
                    return nod.Data;
                }

                if (nod.LeftNode != null)
                {
                    stack.Push(nod.RightNode);
                }
                if (nod.RightNode != null)
                {
                    stack.Push(nod.LeftNode);
                }
            }
            return null;
        }

        /// <summary>
        /// Метод рекурсивно обходит дерево и выводит индексы в консоль
        /// </summary>
        /// <param name="prefix">string префикс</param>
        /// <param name="node">NodeOfTree текущий узел</param>
        public void WriteAllLines(string prefix, NodeOfTree node)
        {
            if (node == null)
            {
                return;
            }
            if (node == RootNode)
            {
                Console.WriteLine(node.Index + " корень");
            }
            List<NodeOfTree> childs = new List<NodeOfTree>();

            if (node.LeftNode == null && node.RightNode == null)
            {
                return;
            }
            if (node.RightNode == null && node.LeftNode != null)
            {
                childs.Add(node.LeftNode);
            }
            if (node.RightNode != null && node.LeftNode == null)
            {
                childs.Add(node.RightNode);
            }
            childs.Add(node.LeftNode);

            childs.Add(node.RightNode);

            foreach (NodeOfTree child in childs)
            {
                Console.WriteLine(prefix + child.Index);

                WriteAllLines(prefix + "_", child);
            }
        }



















        /// <summary>
        /// Метод обхода в ширину
        /// </summary>
        /// <returns>List<object> список ключей для вывода в консоль</returns>
        public List<object> BypassBFS()
        {
            List<object> list = new List<object>();

            Queue<NodeOfTree> queue = new Queue<NodeOfTree>();

            queue.Enqueue(RootNode);

            while (queue.Count != 0)
            {
                NodeOfTree nod = queue.Dequeue();

                list.Add(nod.Index);

                if (nod.LeftNode != null)
                {
                    queue.Enqueue(nod.LeftNode);
                }
                if (nod.RightNode != null)
                {
                    queue.Enqueue(nod.RightNode);
                }
            }
            return list;
        }
    }
}
