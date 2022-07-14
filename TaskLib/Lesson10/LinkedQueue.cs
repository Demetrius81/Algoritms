using Algoritms.Lesson9;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    public class LinkedQueue<T>
    {
        private Item<T> _head;
        private Item<T> _tail;
        public int Count { get; private set; }

        public LinkedQueue()
        {

        }
        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            _head = item;
            _tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data)
            {
                Previous = _tail
            };

            _tail = item;

            Count++;
        }

        public T Dequeue()
        {
            var data = _head.Data;

            Item<T> current = _tail.Previous;

            Item<T> next = _tail;

            while (current != null && current.Previous != null)
            {
                next = current;

                current = current.Previous;
            }

            _head = next;

            _head.Previous = null;

            Count--;

            return data;
        }
        public T Peek()
        {
            return _head.Data;
        }
    }
}
