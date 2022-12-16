using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson15
{
    internal class BinaryTree
    {
        private Node _root;

        public bool Add(int value)
        {
            if (_root == null)
            {
                _root = new Node();

                _root.Value = value;

                return true;
            }
            else
            {
                return CreateNode(_root, value);
            }
        }

        public bool Exist(int value)
        {
            Node node = FindNode(_root, value);

            return node != null;
        }

        private bool CreateNode(Node node, int value)
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
                        return CreateNode(node.LeftChild, value);
                    }
                    else
                    {
                        node.LeftChild = new Node();

                        node.LeftChild.Value = value;

                        return true;
                    }
                }
                else
                {
                    if (node.RightChild != null)
                    {
                        return CreateNode(node.RightChild, value);
                    }
                    else
                    {
                        node.RightChild = new Node();

                        node.RightChild.Value = value;

                        return true;
                    }

                }
            }
        }

        private Node FindNode(Node node, int value)
        {
            if (node.Value == value)
            {
                return node;
            }
            else
            {
                if (node.Value > value)
                {
                    if (node.LeftChild != null)
                    {
                        return FindNode(node.LeftChild, value);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (node.RightChild != null)
                    {
                        return FindNode(node.RightChild, value);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
