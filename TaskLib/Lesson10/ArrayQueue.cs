using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms
{
    internal class ArrayQueue<T>
    {
        private T[] _items;
        private T Head => _items[Count > 0 ? Count - 1 : 0];
        private T Tail => _items[0];
        private int MaxCount => _items.Length;
        public int Count { get; private set; }

        public ArrayQueue(int size = 10)
        {
            _items = new T[size];
            Count = 0;
        }
        public ArrayQueue(T data, int size = 10)
        {
            _items = new T[size];
            _items[0] = data;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count<MaxCount)
            {
                var result = new T[] {data}.Concat(_items);
                _items = result.ToArray();
                Count++;
            }

            //if (Count < MaxCount)
            //{
            //    var result = new T[MaxCount];

            //    result[0] = data;

            //    for (var i = 0; i < Count; i++)
            //    {
            //        result[i + 1] = _items[i];
            //    }
            //    _items = result;
            //    Count++;
            //}
        }

        public T Dequeue()
        {
            var item = Head;
            Count--;
            return item;
        }
        public T Peek()
        {
            return Head;
        }
    }
}
