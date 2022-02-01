using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    internal class Node
    {
        /// <summary>
        /// Поле значение
        /// </summary>
        private int _value;

        /// <summary>
        /// Поле ссылка на следующий элемент
        /// </summary>
        private Node _nextNode;

        /// <summary>
        /// Поле ссылка на предыдущий элемент
        /// </summary>
        private Node _prevNode;

        /// <summary>
        /// Свойство поля значения
        /// </summary>
        internal int Value { get => _value; set => _value = value; }

        /// <summary>
        /// Свойство поля ссылка на следующий элемент
        /// </summary>
        internal Node NextNode { get => _nextNode; set => _nextNode = value; }

        /// <summary>
        /// Свойство поля ссылка на предыдущий элемент
        /// </summary>
        internal Node PrevNode { get => _prevNode; set => _prevNode = value; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
