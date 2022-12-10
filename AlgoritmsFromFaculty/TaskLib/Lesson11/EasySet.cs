using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms
{
    public class EasySet<T> : IEnumerable
    {
        private List<T> _items = new List<T>();

        public int Count => _items.Count;

        public EasySet()
        {

        }

        public EasySet(T item)
        {
            _items.Add(item);
        }

        public EasySet(IEnumerable<T> items)
        {
            this._items = items.ToList();
        }

        public void Add(T item)
        {
            if (_items.Contains(item))
            {
                return;
            }

            //foreach (T i in _items)
            //{
            //    if (i.Equals(item))
            //    {
            //        return;
            //    }
            //}

            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public EasySet<T> Union(EasySet<T> set)
        {
            //return new EasySet<T>(_items.Union(set._items));

            EasySet<T> result = new EasySet<T>();

            foreach (T item in _items)
            {
                result.Add(item);
            }

            foreach (T item in set._items)
            {
                result.Add(item);
            }

            return result;
        }

        public EasySet<T> Intersection(EasySet<T> set)
        {
            //return new EasySet<T>(_items.Intersect(set._items));

            EasySet<T> result = new EasySet<T>();

            EasySet<T> big;

            EasySet<T> small;

            if (Count >= set.Count)
            {
                big = this;
                small = set;
            }
            else
            {
                big = set;
                small = this;
            }

            foreach (var item in small._items)
            {
                foreach (var item2 in big._items)
                {
                    if (item.Equals(item2))
                    {
                        result.Add(item);

                        break;
                    }
                }
            }

            return result;
        }

        public EasySet<T> Difference(EasySet<T> set)
        {
            //return new EasySet<T>(_items.Except(set._items));

            EasySet<T> result = new EasySet<T>(_items);

            foreach (var item in set._items)
            {
                result.Remove(item);
            }

            return result;
        }

        public bool Subset(EasySet<T> set)
        {
            //return set._items.All(x => _items.Contains(x));

            foreach (var item in set._items)
            {
                    bool isEquals = false;

                foreach (var item2 in _items)
                {
                    if (item.Equals(item2))
                    {
                        isEquals = true;
                        continue;
                    }
                }

                if (!isEquals)
                {
                    return false;
                }
            }

            return true;
        }

        public EasySet<T> SymmetricDifference(EasySet<T> set)
        {
            //return new EasySet<T>(_items.Except(set._items).Union(set._items.Except(_items)));

            EasySet<T> result = new EasySet<T>();

            foreach(var item in _items)
            {
                bool isEquals = false;

                foreach (var item2 in set._items)
                {
                    if (item.Equals(item2))
                    {
                        isEquals = true;

                        break;
                    }
                }

                if (!isEquals)
                {
                    result.Add(item);
                }
            }

            foreach (var item in set._items)
            {
                bool isEquals = false;

                foreach (var item2 in _items)
                {
                    if (item.Equals(item2))
                    {
                        isEquals = true;

                        break;
                    }
                }

                if (!isEquals)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
