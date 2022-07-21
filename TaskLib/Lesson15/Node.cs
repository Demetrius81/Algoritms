
namespace Algoritms.Lesson15
{
    internal class Node
    {
        private int _value;
        private Node _leftChild;
        private Node _rightChild;

        public int Value { get => _value; set => _value = value; }
        internal Node LeftChild { get => _leftChild; set => _leftChild = value; }
        internal Node RightChild { get => _rightChild; set => _rightChild = value; }
    }
}
