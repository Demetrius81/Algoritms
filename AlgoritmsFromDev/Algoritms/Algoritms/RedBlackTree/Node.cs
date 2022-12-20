namespace Algoritms.RedBlackTree;

internal class Node<T> where T : IComparable<T>
{    
    public T Value { get; set; }
    internal Color Color { get; set; }
    internal Node<T>? LeftChild { get; set; }
    internal Node<T>? RightChild { get; set; }

    public override string ToString()
    {
        return $$"""Node{ value={{Value}}, color={{Color}}}""";
    }
}
