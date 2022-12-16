namespace Algoritms.List.DoubleLinkedList;

/// <summary>Двухсвязный список</summary>
internal class DoubleLinkedList
{
    private Node? FirstNode { get; set; }

    private Node? LastNode { get; set; }

    #region Constructors

    public DoubleLinkedList()
    {

    }

    public DoubleLinkedList(Node node)
    {
        FirstNode = node;
        LastNode = node;
    }

    public DoubleLinkedList(int value)
    {
        Node node = new(value);
        FirstNode = node;
        LastNode = node;
    }

    public DoubleLinkedList(IEnumerable<Node> nodes)
    {
        foreach (var item in nodes)
            AddNode(item.Value);
    }

    public DoubleLinkedList(IEnumerable<int> values)
    {
        foreach (var item in values)
            AddNode(item);
    }

    #endregion

    /// <summary>Метод добавляет в начало списка новый узел</summary>
    /// <param name="value">значение узла</param>
    public void AddNodeFirst(int value)
    {
        Node newNode = new(value);

        if (FirstNode != null)
        {
            newNode.NextNode = FirstNode;
            FirstNode.NextNode = newNode;
        }
        else
            LastNode = newNode;

        FirstNode = newNode;
    }

    /// <summary>Метод удаляет первый элемент списка</summary>
    public void RemoveNodeFirst()
    {
        if (FirstNode is not null &&
            FirstNode.NextNode is not null)
        {
            FirstNode.NextNode.PrevNode = null;
            FirstNode = FirstNode.NextNode;
        }
        else
        {
            FirstNode = null;
            LastNode = null;
        }
    }

    /// <summary>Метод добавляет элемент в конец списка</summary>
    /// <param name="value">значение</param>
    public void AddNodeLast(int value)
    {
        Node? newNode = new(value);

        if (LastNode is not null)
        {
            newNode.PrevNode = LastNode;
            LastNode.NextNode = newNode;
        }
        else
            FirstNode = newNode;

        LastNode = newNode;
    }

    /// <summary>Метод удаляет последний элемент из списка</summary>
    public void RemoveNodeLast()
    {
        if (LastNode is not null &&
            LastNode.PrevNode is not null)
        {
            LastNode.PrevNode.NextNode = null;
            LastNode = LastNode.PrevNode;
        }
        else
        {
            FirstNode = null;
            LastNode = null;
        }
    }

    /// <summary>Метод сортирует список</summary>
    public void SortList()
    {
        if (FirstNode is null)
            return;

        bool needSort;

        do
        {
            needSort = false;
            Node? node = FirstNode;

            while (node is not null &&
                node.NextNode is not null)
            {
                if (node.Value > node.NextNode.Value)
                {
                    Node? beforeNode = node.PrevNode;
                    Node? afterNode = node.NextNode.NextNode;
                    Node? currentNode = node;
                    Node? nextNode = node.NextNode;

                    currentNode.NextNode = afterNode;
                    currentNode.PrevNode = nextNode;
                    nextNode.NextNode = currentNode;
                    nextNode.PrevNode = beforeNode;

                    if (beforeNode != null)
                        beforeNode.NextNode = nextNode;
                    else
                        FirstNode = nextNode;

                    if (afterNode != null)
                        afterNode.PrevNode = currentNode;
                    else
                        LastNode = currentNode;

                    needSort = true;
                }

                node = node.NextNode;
            }
        }
        while (needSort);
    }

    /// <summary>Метод переворачивает список</summary>
    public void Revert()
    {
        Node? node = FirstNode;

        while (node != null)
            (node.NextNode, node.PrevNode, node) = (node.PrevNode, node.NextNode, node.NextNode);

        (FirstNode, LastNode) = (LastNode, FirstNode);
    }



    #region Other methods

    /// <summary>Возвращает количество элементов в списке</summary>
    /// <returns>int количество элементов списка</returns>
    public int GetCount()
    {
        if (FirstNode == null)
            return 0;

        int i = 1;

        if (FirstNode == LastNode)
        {
            return i;
        }
        else
        {
            Node? currentNode = FirstNode;

            do
            {
                i++;
                currentNode = currentNode.NextNode;

            }
            while (currentNode.NextNode != null);
        }
        return i;
    }

    /// <summary>Добавляет новый элемент списка</summary>
    /// <param name="value">int новый элемент списка</param>
    public void AddNode(int value)
    {
        Node? newNode = new(value);

        if (FirstNode != null && LastNode != null)
        {
            Node? currentNode = LastNode;
            currentNode.NextNode = newNode;
            newNode.PrevNode = currentNode;
            LastNode = newNode;
        }
        else
        {
            FirstNode = newNode;
            LastNode = newNode;
        }
    }

    /// <summary>Добавляет новый элемент списка после определённого элемента</summary>
    /// <param name="node">Node элемент, после которого нужно добавить новый элемент</param>
    /// <param name="value">int новый элемент списка</param>
    public void AddNodeAfter(Node? userNode, int value)
    {
        if (userNode is null)
            return;

        Node? newNode = new(value);

        switch (true)
        {
            case true when userNode != LastNode && userNode.NextNode != null:
                Node? nextNode = userNode.NextNode;
                nextNode.PrevNode = newNode;
                userNode.NextNode = newNode;
                newNode.NextNode = nextNode;
                newNode.PrevNode = userNode;
                break;
            default:
                userNode.NextNode = newNode;
                newNode.PrevNode = userNode;
                LastNode = newNode;
                break;
        }
    }

    /// <summary>Удаляет элемент по порядковому номеру</summary>
    /// <param name="index">int индекс удаляемого элемента</param>
    public void RemoveNode(int index)
    {
        if (FirstNode is null)
            throw new ArgumentNullException(nameof(index), "Списка не существует");

        int temp = GetCount();
        Node? currentNode = FirstNode;

        if (temp < index)
            return;

        for (int i = 1; i < index; i++)
        {
            if (currentNode.NextNode is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Такого количества элементов в списке нет");
            }
            currentNode = currentNode.NextNode;
        }

        RemoveNode(currentNode);
    }

    /// <summary>Удаляет указанный элемент</summary>
    /// <param name="node">Node элемент списка, который нужно удалить</param>
    public void RemoveNode(Node? userNode)
    {
        if (userNode is null)
            return;

        Node? prevNode = userNode.PrevNode;
        Node? nextvNode = userNode.NextNode;

        switch (true)
        {
            case true when userNode != LastNode && userNode != FirstNode:
                prevNode.NextNode = userNode.NextNode;
                nextvNode.PrevNode = userNode.PrevNode;
                break;
            case true when userNode == LastNode:
                prevNode.NextNode = null;
                LastNode = prevNode;
                break;
            case true when userNode == FirstNode:
                nextvNode.PrevNode = null;
                FirstNode = nextvNode;
                break;
            default:
                break;
        }
    }

    /// <summary>Ищет элемент по его значению</summary>
    /// <param name="searchValue">int значение элемента, который нужно найти</param>
    /// <returns>Node искомый элемент</returns>
    public Node FindNode(int searchValue)
    {
        Node? currentNode = FirstNode;

        while (currentNode.Value != searchValue)
        {
            if (currentNode == LastNode && currentNode.Value != searchValue)
                return null;

            currentNode = currentNode.NextNode;
        }

        return currentNode;
    }

    #endregion

    /// <summary>Выводит в консоль список</summary>
    public void PrintDoubleLinkedList()
    {
        if (FirstNode is null)
            Console.WriteLine("Список пуст");
        else
        {
            Node? currentNode = FirstNode;

            while (currentNode.NextNode is not null)
            {
                Console.Write($"  {currentNode.Value}");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
    }
}
