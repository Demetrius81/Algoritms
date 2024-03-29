﻿namespace Algoritms.RedBlackTree;

/// <summary>Класс красно-черного дерева</summary>
/// <typeparam name="T">Тип, реализующий интерфейс IComparable</typeparam>
internal class RedBlackTree<T> where T : IComparable<T>
{
    private Node<T>? _root;

    /// <summary>Добавить значение в дерево</summary>
    /// <param name="value">значение</param>
    /// <returns></returns>
    public bool Add(T value)
    {
        if (_root is not null)
        {
            bool result = AddNode(_root, value);
            _root = Rebalnce(_root);
            _root.Color = Color.BLACK;
            return result;
        }
        else
        {
            _root = new Node<T>();
            _root.Color = Color.BLACK;
            _root.Value = value;
            return true;
        }
    }

    /// <summary>Добавить значение в дерево. Рекурсивный метод</summary>
    /// <param name="node">узел дерева для рекурсии</param>
    /// <param name="value">значение</param>
    /// <returns></returns>
    private bool AddNode(Node<T>? node, T value)
    {
        if (node.Value.CompareTo(value) == 0)
        {
            return false;
        }
        else
        {
            if (node.Value.CompareTo(value) > 0)
            {
                if (node.LeftChild is not null)
                {
                    bool result = AddNode(node.LeftChild, value);
                    node.LeftChild = Rebalnce(node.LeftChild);
                    return result;
                }
                else
                {
                    node.LeftChild = new Node<T>();
                    node.LeftChild.Color = Color.RED;
                    node.LeftChild.Value = value;
                    return true;
                }
            }
            else
            {
                if (node.RightChild is not null)
                {
                    bool result = AddNode(node.RightChild, value);
                    node.RightChild = Rebalnce(node.RightChild);
                    return result;
                }
                else
                {
                    node.RightChild = new Node<T>();
                    node.RightChild.Color = Color.RED;
                    node.RightChild.Value = value;
                    return true;
                }
            }
        }
    }

    /// <summary>Метод ребалансировки дерева</summary>
    /// <param name="node">узел</param>
    /// <returns>узел</returns>
    private Node<T>? Rebalnce(Node<T>? node)
    {
        Node<T>? result = node;
        bool needRebalance;

        do
        {
            needRebalance = false;

            if (result.RightChild is not null && result.RightChild.Color == Color.RED &&
                    (result.LeftChild is null || result.LeftChild.Color == Color.BLACK))
            {
                needRebalance = true;
                result = RightSwap(result);
            }
            if (result.LeftChild is not null && result.LeftChild.Color == Color.RED &&
                    result.LeftChild.LeftChild is not null && result.LeftChild.LeftChild.Color == Color.RED)
            {
                needRebalance = true;
                result = LeftSwap(result);
            }
            if (result.LeftChild is not null && result.LeftChild.Color == Color.RED &&
                    result.RightChild is not null && result.RightChild.Color == Color.RED)
            {
                needRebalance = true;
                ColorSwap(result);
            }
        }
        while (needRebalance);

        return result;
    }

    /// <summary>Правый малый поворот</summary>
    /// <param name="node">узел</param>
    /// <returns>узел</returns>
    private Node<T>? RightSwap(Node<T>? node)
    {
        Node<T>? rightChild = node.RightChild;
        Node<T>? betweenChild = rightChild.LeftChild;
        rightChild.LeftChild = node;
        node.RightChild = betweenChild;
        rightChild.Color = node.Color;
        node.Color = Color.RED;
        return rightChild;
    }

    /// <summary>Левый малый поворот</summary>
    /// <param name="node">узел</param>
    /// <returns>узел</returns>
    private Node<T>? LeftSwap(Node<T>? node)
    {
        Node<T>? leftChild = node.LeftChild;
        Node<T>? betweenChild = leftChild.RightChild;
        leftChild.RightChild = node;
        node.LeftChild = betweenChild;
        leftChild.Color = node.Color;
        node.Color = Color.RED;
        return leftChild;
    }

    /// <summary>Смена цвета</summary>
    /// <param name="node"></param>
    private void ColorSwap(Node<T>? node)
    {
        node.RightChild.Color = Color.BLACK;
        node.LeftChild.Color = Color.BLACK;
        node.Color = Color.RED;
    }
}
