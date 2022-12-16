using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson14
{
    internal class RedBlackTree
    {
        private Node _root;

        public bool Add(int value)
        {
            if (_root != null)
            {
                bool result = AddNode(_root, value);

                _root = Rebalnce(_root);

                _root.Color = Color.BLACK;

                return result;
            }
            else
            {
                _root = new Node();

                _root.Color = Color.BLACK;

                _root.Value = value;

                return true;
            }
        }

        private bool AddNode(Node node, int value)
        {
            if (node.Value == value)
            {
                return false;
            }
            else
            {
                if (node.Value > value)
                {
                    if (node.LeftChild != null)
                    {
                        bool result = AddNode(node.LeftChild, value);

                        node.LeftChild = Rebalnce(node.LeftChild);

                        return result;
                    }
                    else
                    {
                        node.LeftChild = new Node();

                        node.LeftChild.Color = Color.RED;

                        node.LeftChild.Value = value;

                        return true;
                    }
                }
                else
                {
                    if (node.RightChild != null)
                    {
                        bool result = AddNode(node.RightChild, value);

                        node.RightChild = Rebalnce(node.RightChild);

                        return result;
                    }
                    else
                    {
                        node.RightChild = new Node();

                        node.RightChild.Color = Color.RED;

                        node.RightChild.Value = value;

                        return true;
                    }
                }
            }
        }

        private Node Rebalnce(Node node)
        {
            Node result = node;

            bool needRebalance = false;

            do
            {
                needRebalance = false;
                if (result.RightChild != null && result.RightChild.Color == Color.RED &&
                        (result.LeftChild == null || result.LeftChild.Color == Color.BLACK))
                {
                    needRebalance = true;

                    result = RightSwap(result);
                }
                if (result.LeftChild != null && result.LeftChild.Color == Color.RED &&
                        result.LeftChild.LeftChild != null && result.LeftChild.LeftChild.Color == Color.RED)
                {
                    needRebalance = true;

                    result = LeftSwap(result);
                }
                if (result.LeftChild != null && result.LeftChild.Color == Color.RED &&
                        result.RightChild != null && result.RightChild.Color == Color.RED)
                {
                    needRebalance = true;

                    ColorSwap(result);
                }
            }
            while (needRebalance);
            return result;
        }

        private Node RightSwap(Node node)
        {
            Node rightChild = node.RightChild;

            Node betweenChild = rightChild.LeftChild;

            rightChild.LeftChild = node;

            node.RightChild = betweenChild;

            rightChild.Color = node.Color;

            node.Color = Color.RED;

            return rightChild;
        }

        private Node LeftSwap(Node node)
        {
            Node leftChild = node.LeftChild;

            Node betweenChild = leftChild.RightChild;

            leftChild.RightChild = node;

            node.LeftChild = betweenChild;

            leftChild.Color = node.Color;

            node.Color = Color.RED;

            return leftChild;
        }

        private void ColorSwap(Node node)
        {
            node.RightChild.Color = Color.BLACK;

            node.LeftChild.Color = Color.BLACK;

            node.Color = Color.RED;
        }

    }
}
