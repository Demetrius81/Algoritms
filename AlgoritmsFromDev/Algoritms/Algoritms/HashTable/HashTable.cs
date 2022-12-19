namespace Algoritms.HashTable;

public class HashTable<TKey, TValue>
{
    private const int BASKET_COUNT = 16;
    private const int MULTIPLICATION_FACTOR = 2;
    private const double LOAD_FACTOR = 0.75;


    private int Size { get; set; }

    private Basket[] Baskets { get; set; }

    public HashTable() : this(BASKET_COUNT)
    {
    }

    public HashTable(int initSize)
    {
        Baskets = new Basket[initSize];
    }

    private int CalculateBasketIndex(TKey key) => key.GetHashCode() % Baskets.Length;

    private void Recalculate()
    {
        var oldBaskets = Baskets;
        Baskets = new Basket[oldBaskets.Length * MULTIPLICATION_FACTOR];
        Size = 0;

        for (var i = 0; i < oldBaskets.Length; i++)
        {
            var basket = oldBaskets[i];
            var node = basket.FirstNode;

            while (node is not null)
            {
                Put(node.Value.Key, node.Value.Value);
                node = node.NextNode;
            }

            //oldBaskets[i] = null; // Why? GK destroy this object when we exit from this method.
        }
    }


    public TValue? Get(TKey key)
    {
        var index = CalculateBasketIndex(key);
        var basket = Baskets[index];

        if (basket is not null)
            return basket.Get(key);

        return default;
    }

    public bool Put(TKey key, TValue value)
    {
        if (Baskets.Length * LOAD_FACTOR < Size)
            Recalculate();
        var index = CalculateBasketIndex(key);
        var basket = Baskets[index];

        if (basket is null)
        {
            basket = new Basket();
            Baskets[index] = basket;
        }

        Entity entity = new()
        {
            Key = key,
            Value = value
        };

        if (basket.Add(entity))
        {
            Size++;
            return true;
        }

        return false;
    }

    public bool Remove(TKey key)
    {
        var index = CalculateBasketIndex(key);
        var basket = Baskets[index];
        if (basket.Remove(key))
        {
            Size--;
            return true;
        }
        return false;
    }

    internal sealed class Entity
    {
        internal TKey? Key { get; set; }
        internal TValue? Value { get; set; }
    }

    internal sealed class Basket
    {
        internal Node? FirstNode { get; set; }

        internal TValue? Get(TKey key)
        {
            var currentNode = FirstNode;

            while (currentNode is not null)
            {
                if (currentNode.Value.Key.Equals(key))
                    return currentNode.Value.Value;

                currentNode = currentNode.NextNode;
            }
            return default;
        }

        internal bool Remove(TKey key)
        {
            if (FirstNode is not null)
                if (FirstNode.Value.Key.Equals(key))
                    FirstNode = FirstNode.NextNode;
                else
                {
                    var currentNode = FirstNode;

                    while (currentNode.NextNode is not null)
                    {
                        if (currentNode.NextNode.Value.Key.Equals(key))
                        {
                            currentNode.NextNode = currentNode.NextNode.NextNode;
                            return true;
                        }

                        currentNode = currentNode.NextNode;
                    }
                }

            return false;
        }

        internal bool Add(Entity entity)
        {
            Node newNode = new()
            {
                Value = entity
            };

            if (FirstNode is not null)
            {
                var currentNode = FirstNode;

                while (true)
                {
                    if (currentNode.Value.Key.Equals(entity.Key))
                        return false;

                    if (currentNode.NextNode is null)
                    {
                        currentNode.NextNode = newNode;
                        return true;
                    }
                    else
                        currentNode = currentNode.NextNode;
                }
            }
            else
            {
                FirstNode = newNode;
                return true;
            }
        }

        internal sealed class Node
        {
            internal Node? NextNode { get; set; }
            internal Entity? Value { get; set; }
        }
    }
}

