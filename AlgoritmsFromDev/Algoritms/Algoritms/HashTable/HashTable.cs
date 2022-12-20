namespace Algoritms.HashTable;

/// <summary>Класс хеш таблицы</summary>
/// <typeparam name="TKey">ключ</typeparam>
/// <typeparam name="TValue">значение</typeparam>
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

    /// <summary>Вычисляем индекс позиции в массиве корзин</summary>
    /// <param name="key">ключ</param>
    /// <returns>индекс позиции в массиве</returns>
    private int CalculateBasketIndex(TKey key) => key.GetHashCode() % Baskets.Length;

    /// <summary>Перерасчет размера массива корзин</summary>
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
        }
    }

    /// <summary>Получить значение по ключу</summary>
    /// <param name="key">ключ</param>
    /// <returns>значение</returns>
    public TValue? Get(TKey key)
    {
        var index = CalculateBasketIndex(key);
        var basket = Baskets[index];

        if (basket is not null)
            return basket.Get(key);

        return default;
    }

    /// <summary>Положить значение по ключу</summary>
    /// <param name="key">ключ</param>
    /// <param name="value">значение</param>
    /// <returns>результат операции</returns>
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

    /// <summary>Удалить значение по ключу</summary>
    /// <param name="key">ключ</param>
    /// <returns>результат операции</returns>
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

    /// <summary>Класс сущности, хранит пару ключ-значение</summary>
    internal sealed class Entity
    {
        internal TKey? Key { get; set; }
        internal TValue? Value { get; set; }
    }

    /// <summary>Класс корзины представляет собой односвязный список</summary>
    internal sealed class Basket
    {
        internal Node? FirstNode { get; set; }

        /// <summary>Получить значение по ключу</summary>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
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

        /// <summary>Удалить значение по ключу</summary>
        /// <param name="key">ключ</param>
        /// <returns>результат операции</returns>
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

        /// <summary>Добавить сущность</summary>
        /// <param name="entity">сущность</param>
        /// <returns>результат выполнения операции</returns>
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

        /// <summary>
        /// Класс узла щдносвязного списка
        /// </summary>
        internal sealed class Node
        {
            internal Node? NextNode { get; set; }
            internal Entity? Value { get; set; }
        }
    }
}

