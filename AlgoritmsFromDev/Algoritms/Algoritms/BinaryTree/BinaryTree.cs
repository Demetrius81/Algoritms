namespace Algoritms.BinaryTree;
public class BinaryTree<TValue> where TValue : IComparable<TValue>
{
    private Node? Root { get; set; }

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

    internal sealed class Node
    {
        internal TValue? Value { get; set; }
        internal Node? LeftNode { get; set; }
        internal Node? RightNode { get; set; }
    }
}

