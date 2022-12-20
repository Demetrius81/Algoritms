namespace Algoritms.BinaryTree;

/// <summary>Бинарное дерево</summary>
/// <typeparam name="TValue">класс, реализующий интерфейс IComparable</typeparam>
public class BinaryTree<TValue> where TValue : IComparable<TValue>
{
    private Node? Root { get; set; }

    /// <summary>Метод определяет, находится ли значение в дереве или нет циклом</summary>
    /// <param name="value">значение</param>
    /// <returns>результат операции</returns>
    public bool ContainsCycle(TValue value)
    {
        var currentNode = Root;

        while (currentNode is not null)
        {
            if (currentNode.Value.Equals(value))
                return true;

            if (currentNode.Value.CompareTo(value) < 0)
                currentNode = currentNode.LeftNode;
            else
                currentNode = currentNode.RightNode;
        }

        return false;
    }

    /// <summary>Метод определяет, находится ли значение в дереве или нет рекурсией</summary>
    /// <param name="value">значение</param>
    /// <returns>результат операции</returns>
    public bool ContainsRecursive(TValue value)
    {
        if (Root is null)
            return false;

        return true;
    }

    private bool ContainsRecursive(Node? node, TValue value)
    {
        if (node.Value.Equals(value))
            return true;
        else
        {
            if (node.Value.CompareTo(value) < 0)
                return ContainsRecursive(node.LeftNode, value);
            else
                return ContainsRecursive(node.RightNode, value);
        }
    }

    /// <summary>Класс узла дерева</summary>
    internal sealed class Node
    {
        internal TValue? Value { get; set; }
        internal Node? LeftNode { get; set; }
        internal Node? RightNode { get; set; }
    }
}

