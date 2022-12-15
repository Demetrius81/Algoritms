using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.List.LinkedList;
internal class Node
{
    public int Value { get; set; }

    public Node? NextNode { get; set; }

    public Node(int value, Node? nextNode = null)
    {
        Value = value;
        NextNode = nextNode;
    }
}
