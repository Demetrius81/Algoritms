using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms
{
    public class EazyStack<T> : ICloneable
    {
        private List<T> _items = new List<T>();

        public int Count { get => _items.Count; }

        public bool IsEmpty => _items.Count == 0;

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = _items.LastOrDefault();

                _items.Remove(item);

                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }

        public void Clear()
        {
            _items.Clear();
        }

        public T Peek()
        {
            {
                if (!IsEmpty)
                {
                    return _items.LastOrDefault();
                }
                else
                {
                    throw new NullReferenceException("Стек пустой");
                }
            }
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами.";
        }

        public object Clone()
        {
            var newStack = new EazyStack<T>();

            newStack._items = new List<T>(_items);

            return newStack;
        }
    }
}
