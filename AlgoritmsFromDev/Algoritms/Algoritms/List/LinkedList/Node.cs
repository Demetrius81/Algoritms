namespace Algoritms.List.LinkedList;

/// <summary>Модель узла списка</summary>
internal class Node
{
    /// <summary>Значение</summary>
    public int Value { get; set; }

    /// <summary>Ссылка на следующий элемент</summary>
    public Node? NextNode { get; set; }

    public Node(int value, Node? nextNode = null)
    {
        Value = value;
        NextNode = nextNode;
    }
}
