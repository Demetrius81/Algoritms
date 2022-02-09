using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class NodeOfTree
    {
        /// <summary>
        /// Поле значение
        /// </summary>
        private int _index;

        /// <summary>
        /// Поле хранимые данные
        /// </summary>
        private object _data;
                
        /// <summary>
        /// Поле ссылка на следующий элемент слева
        /// </summary>
        private NodeOfTree _lefttNode;

        /// <summary>
        /// Поле ссылка на следующий элемент справа
        /// </summary>
        private NodeOfTree _rightNode;

        /// <summary>
        /// Свойство поля значения
        /// </summary>
        internal int Index { get => _index; set => _index = value; }

        /// <summary>
        /// Свойство поля хранимые данные
        /// </summary>
        internal object Data { get => _data; set => _data = value; }

        /// <summary>
        /// Свойство поля ссылка на следующий элемент слева
        /// </summary>
        internal NodeOfTree LeftNode { get => _lefttNode; set => _lefttNode = value; }

        /// <summary>
        /// Свойство поля ссылка на следующий элемент справа
        /// </summary>
        internal NodeOfTree RightNode { get => _rightNode; set => _rightNode = value; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value"></param>
        public NodeOfTree()
        {
            
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value"></param>
        public NodeOfTree(int value)
        {
            Index = value;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value"></param>
        public NodeOfTree(int value, object data)
        {
            Index = value;

            Data = data;
        }
    }
}
