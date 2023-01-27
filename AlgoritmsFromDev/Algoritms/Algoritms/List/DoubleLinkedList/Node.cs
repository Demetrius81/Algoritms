namespace Algoritms.List.DoubleLinkedList;

/// <summary>Модель узла списка</summary>
internal class Node
{
    /// <summary>Значениe</summary>
    internal int Value { get; set; }

    /// <summary>Ссылка на следующий элемент</summary>
    internal Node? NextNode { get; set; }

    /// <summary>Ссылка на предыдущий элемент</summary>
    internal Node? PrevNode { get; set; }

    /// <summary>Конструктор</summary>
    /// <param name="value">значение</param>
    public Node(int value)
    {
        Value = value;
    }
}
