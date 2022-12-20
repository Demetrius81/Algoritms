namespace Algoritms.RedBlackTree;

internal class RedBlackTree<T> where T : IComparable<T>
{
    private Node<T>? _root;

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

    private void ColorSwap(Node<T>? node)
    {
        node.RightChild.Color = Color.BLACK;
        node.LeftChild.Color = Color.BLACK;
        node.Color = Color.RED;
    }
}
