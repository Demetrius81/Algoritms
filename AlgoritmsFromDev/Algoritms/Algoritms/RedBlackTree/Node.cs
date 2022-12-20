namespace Algoritms.RedBlackTree;

/// <summary>Класс узел красно-черного дерева</summary>
/// <typeparam name="T">тип, реализующий интерфейс IComparable</typeparam>
internal class Node<T> where T : IComparable<T>
{    
    public T Value { get; set; }
    internal Color Color { get; set; }
    internal Node<T>? LeftChild { get; set; }
    internal Node<T>? RightChild { get; set; }

    public override string ToString()
    {
        return $$"""Node{ "value" = "{{Value}}", "color" = "{{Color}}" }""";
    }
}
