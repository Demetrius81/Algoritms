namespace Algoritms.List.LinkedList;

/// <summary> Класс односвязного списка </summary>
internal class LinkedList
{
    private Node? FirstNode { get; set; }

    #region Constructors

    public LinkedList()
    {

    }

    public LinkedList(Node node) => FirstNode = node;

    public LinkedList(int value) => AddNodeFirst(value);

    public LinkedList(IEnumerable<int> values)
    {
        foreach (var item in values)
            AddNodeLast(item);
    }

    #endregion

    /// <summary>Метод добавляет в начало списка новый узел</summary>
    /// <param name="value">значение узла</param>
    public void AddNodeFirst(int value)
    {
        Node newNode = new(value, FirstNode);
        FirstNode = newNode;
    }

    /// <summary>Метод удаляет первый элемент списка</summary>
    public void RemoveNodeFirst()
    {
        if (FirstNode is not null)
            FirstNode = FirstNode.NextNode;
    }

    /// <summary>Метод устанавливает, есть ли заданное значение в списке</summary>
    /// <param name="value">значение</param>
    /// <returns>bool есть ли значение</returns>
    /// <exception cref="ArgumentNullException">Исключение выбрасывается при попытке обратиться к пустому списку</exception>
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

    /// <summary>Метод добавляет элемент в конец списка</summary>
    /// <param name="value">значение</param>
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

    /// <summary>Метод удаляет последний элемент из списка</summary>
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

    /// <summary>Метод переворачивает список</summary>
    public void Revert()
    {
        if (FirstNode is not null && FirstNode.NextNode is not null)
            Revert(FirstNode, FirstNode.NextNode);
    }

    /// <summary>Метод рекурсивно меняет направление (переворачивает) списка</summary>
    /// <param name="currentNode">еекущий узел</param>
    /// <param name="nextNode">следующий узел</param>
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
