using System;

namespace Node
{
    public class Node : INode
    {
        #region Поля и свойства

        /// <summary>
        /// Значение
        /// </summary>
        private int _value;

        /// <summary>
        /// Ссылка на следующий элемент
        /// </summary>
        private Node _nextNode;

        /// <summary>
        /// Ссылка на предыдущий элемент
        /// </summary>
        private Node _prevNode;

        /// <summary>
        /// Свойство значения
        /// </summary>
        public int Value { get => _value; set => _value = value; }

        /// <summary>
        /// Свойство ссылка на следующий элемент
        /// </summary>
        public Node NextNode { get => _nextNode; set => _nextNode = value; }

        /// <summary>
        /// Свойство ссылка на предыдущий элемент
        /// </summary>
        public Node PrevNode { get => _prevNode; set => _prevNode = value; }

        #endregion

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            
            while (Node.NextNode != null)
            {
                Node = Node.NextItem;
            }

            return 0;
        }

        /// <summary>
        /// Добавляет новый элемент списка
        /// </summary>
        /// <param name="value">int новый элемент списка</param>
        public void AddNode(int value)
        {

        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node">Node элемент, после которого нужно добавить новый элемент</param>
        /// <param name="value">int новый элемент списка</param>
        public void AddNodeAfter(Node node, int value)
        {

        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index">int индекс удаляемого элемента</param>
        public void RemoveNode(int index)
        {

        }

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        /// <param name="node">Node элемент списка, который нужно удалить</param>
        public void RemoveNode(Node node)
        {

        }

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue">int значение элемента, который нужно найти</param>
        /// <returns>Node искомый элемент</returns>
        public Node FindNode(int searchValue)
        {
            return null;
        }
    }
}
