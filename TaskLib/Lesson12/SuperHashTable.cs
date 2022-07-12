using Algoritms.Lesson12;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    internal class SuperHashTable<T>
    {
        private Item<T>[] _items;

        public SuperHashTable(int size = 100)
        {
            _items = new Item<T>[size];

            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            _items[key].Items.Add(item);
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
            return _items[key].Items.Contains(item);
        }

        private int GetHash(T item)
        {
            return item.GetHashCode() % _items.Length;
        }
    }
}
