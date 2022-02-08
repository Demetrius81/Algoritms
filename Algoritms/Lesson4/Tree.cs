using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class Tree : ITask
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
        /// Поле количество узлов дерева
        /// </summary>
        private int _count;

        /// <summary>
        /// Свойство поля количество узлов дерева
        /// </summary>
        public int Count { get => _count; set => _count = value; }



        private string _taskNumber = "4";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Работа с бинарным деревом поиска";

        public string TaskName { get => _taskName; }




        public void TaskResultOutput()
        {


        }

        private Tree CreateDataLine(int count)
        {
            Tree tree = new Tree();


            return tree;
        }

        /// <summary>
        /// Метод вычисляет находится ли элемент с указанным индексом в дереве
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns>bool возврашает результат вычисления</returns>
        private bool Contains(int index)
        {
            NodeOfTree parent;

            return FindWithParent(out parent, index) != null;
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
        /// Метод добавляет элемент дерева по тндексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        private void Add(int index)
        {
            if (RootNode == null)
            {
                NodeOfTree nodeOfTree = new NodeOfTree(index);
            }
            else
            {
                AddTo(RootNode, index);
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
            else
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
        /// Метод удаляет элемент дерева по индексу
        /// </summary>
        /// <param name="index">int индекс элемента</param>
        /// <returns>bool возвращает значение удален ли элемент</returns>
        private bool Remove(int index)
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
    }
}
