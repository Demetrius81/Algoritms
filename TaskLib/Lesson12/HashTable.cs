using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    internal class HashTable<TKey, TValue>
    {
        private List<TValue>[] _items;

        public HashTable(int size = 100)
        {
            _items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (_items[k] == null)
            {
                _items[k] = new List<TValue>() { value };

            }
            else
            {

                _items[k].Add(value);
            }
        }

        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            return _items[k]?.Contains(item) ?? false;
        }

        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }
}
