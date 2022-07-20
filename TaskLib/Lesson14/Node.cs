using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson14
{
    internal class Node
    {
        private int _value;
        private Color _color;
        private Node _leftChild;
        private Node _rightChild;

        public int Value { get => _value; set => _value = value; }
        internal Color Color { get => _color; set => _color = value; }
        internal Node LeftChild { get => _leftChild; set => _leftChild = value; }
        internal Node RightChild { get => _rightChild; set => _rightChild = value; }

        public override String ToString()
        {
            return "Node{" + "value=" + _value + ", color=" + _color + '}';
        }
    }
}
