using Algoritms.Lesson13;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms
{
    internal class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> _items = new List<Item<TKey, TValue>>();
        private List<TKey> _keys = new List<TKey>();

        public int Count { get { return _items.Count; } }

        public EasyMap()
        {

        }

        public void Add(Item<TKey, TValue> item)
        {
            if (!_keys.Contains(item.Key))
            {
                _items.Add(item);
                _keys.Add(item.Key);
            }
        }

        public TValue Search(TKey key)
        {
            if (_keys.Contains(key))
            {
                return _items.Single(i => i.Key.Equals(key)).Value;
            }
            // or exception
            return default(TValue);
        }

        public void Remove(TKey key)
        {
            if (_keys.Contains(key))
            {
                _items.Remove(_items.Single(i => i.Key.Equals(key)));
                _keys.Remove(key);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
