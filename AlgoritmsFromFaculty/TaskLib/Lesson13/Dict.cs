using Algoritms.Lesson13;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    internal class Dict<TKey, TValue> : IEnumerable
    {
        private Item<TKey, TValue>[] _items;
        private List<TKey> _keys;
        private int _capasity;

        private int GetCash(TKey key)
        {
            return key.GetHashCode() % _capasity;
        }

        public Dict(int capasity = 100)
        {
            _keys = new List<TKey>();
            _capasity = capasity;
            _items = new Item<TKey, TValue>[capasity];
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetCash(item.Key);

            if (_keys.Contains(item.Key))
            {
                return;
            }

            if (_items[hash] == null)
            {
                _keys.Add(item.Key);
                _items[hash] = item;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < _capasity; i++)
                {
                    if (_items[i] == null)
                    {
                        _keys.Add(item.Key);
                        _items[i] = item;
                        placed = true;
                        break;
                    }
                    if (_items[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (_items[i] == null)
                        {
                            _keys.Add(item.Key);
                            _items[i] = item;
                            placed = true;
                            break;
                        }
                        if (_items[i].Key.Equals(item.Key))
                        {
                            return;
                        }
                    }
                }

                if (!placed)
                {
                    throw new Exception("Словарь заполнен");
                }
            }
        }
        public void Remove(TKey key)
        {
            var hash = GetCash(key);

            if (!_keys.Contains(key))
            {
                return;
            }

            if (_items[hash] == null)
            {
                for (int i = 0; i < _capasity; i++)
                {
                    if (_items[i].Key.Equals(key))
                    {
                        _items[i] = null;
                        _keys.Remove(key);
                    }
                }
            }

            if (_items[hash].Key.Equals(key))
            {
                _items[hash] = null;
                _keys.Remove(key);
            }
            else
            {
                for (int i = hash; i < _capasity; i++)
                {
                    if (_items[i] == null)
                    {
                        return;
                    }
                    if (_items[i].Key.Equals(key))
                    {
                        _items[i] = null;
                        _keys.Remove(key);
                        return;
                    }
                }

                for (int i = 0; i < hash; i++)
                {
                    if (_items[i] == null)
                    {
                        return;
                    }
                    if (_items[i] != null && _items[i].Key.Equals(key))
                    {
                        _items[i] = null;
                        _keys.Remove(key);
                        return;
                    }
                }
            }
        }

        public TValue Search(TKey key)
        {
            var hash = GetCash(key);

            if (!_keys.Contains(key))
            {
                return default(TValue);
            }

            if (_items[hash] == null)
            {
                foreach (var item in _items)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }

                return default(TValue);
            }

            if (_items[hash].Key.Equals(key))
            {
                return _items[hash].Value;
            }
            else
            {
                for (int i = hash; i < _capasity; i++)
                {
                    if (_items[i] == null)
                    {
                        return default(TValue);
                    }
                    if (_items[i].Key.Equals(key))
                    {
                        return _items[i].Value;
                    }
                }

                for (int i = 0; i < hash; i++)
                {
                    if (_items[i] == null)
                    {
                        return default(TValue);
                    }
                    if (_items[i].Key.Equals(key))
                    {
                        return _items[i].Value;
                    }
                }
            }

            return default(TValue);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}
