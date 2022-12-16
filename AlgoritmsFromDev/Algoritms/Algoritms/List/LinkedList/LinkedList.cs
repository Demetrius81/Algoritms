namespace Algoritms.List.LinkedList;
internal class LinkedList
{
    private Node? FirstNode { get; set; }

    #region Constructors

    public LinkedList(Node node)
    {
        FirstNode = node;
    }

    public LinkedList(int value)
    {
        AddNodeFirst(value);
    }

    public LinkedList(IEnumerable<int> values)
    {
        foreach (var item in values)
        {
            AddNodeLast(item);
        }
    }

    #endregion

    public void AddNodeFirst(int value)
    {
        Node newNode = new(value, FirstNode);
        FirstNode = newNode;
    }


    public void RemoveNodeFirst()
    {
        if (FirstNode is not null)
            FirstNode = FirstNode.NextNode;
    }

    public bool Contains(int value)
    {
        if (FirstNode is null)
            throw new ArgumentNullException(nameof(value), "Список пуст");

        Node? currentNode = FirstNode;

        while (currentNode is not null)
        {
            if (currentNode.Value.Equals(value))
                return true;

            currentNode = currentNode.NextNode;
        }
        return false;
    }

    public void AddNodeLast(int value)
    {
        Node newNode = new(value);

        if (FirstNode is null)
            FirstNode = newNode;
        else
        {
            Node currentNode = FirstNode;

            while (currentNode.NextNode is not null)
                currentNode = currentNode.NextNode;

            currentNode.NextNode = newNode;
        }
    }

    public void RemoveNodeLast()
    {
        if (FirstNode is not null)
        {
            Node currentNode = FirstNode;

            while (currentNode.NextNode is not null)
            {
                if (currentNode.NextNode.NextNode is null)
                    currentNode.NextNode = null;
            }
            FirstNode = null;
        }
    }

    public void Revert()
    {
        if (FirstNode is not null && FirstNode.NextNode is not null)
            Revert(FirstNode, FirstNode.NextNode);
    }

    private void Revert(Node currentNode, Node nextNode)
    {
        if (nextNode.NextNode is not null)
            Revert(nextNode, nextNode.NextNode);
        else
            FirstNode = nextNode;

        nextNode.NextNode = currentNode;
        currentNode.NextNode = null;
    }


    /// <summary>Выводит в консоль список</summary>
    public void PrintLinkedList()
    {
        if (FirstNode is null)
            Console.WriteLine("Список пуст");
        else
        {
            Node currentNode = FirstNode;

            while (currentNode.NextNode is not null)
            {
                Console.Write($"  {currentNode.Value}");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
    }
}
