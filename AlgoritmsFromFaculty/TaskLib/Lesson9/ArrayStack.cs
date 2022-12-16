using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    public class ArrayStack<T>
    {
        private T[] _items;

        public int Count => _current + 1;

        private int _current = -1;

        private readonly int _size = 10;

        public ArrayStack(int size = 10)
        {
            _items = new T[size];
            _size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {

            _items[0] = data;
            _current = 1;
        }

        public void Push(T data)
        {
            if (_current < _size - 1)
            {
                _current++;
                _items[_current] = data;
            }
            else
            {
                throw new StackOverflowException("Стек переполнен.");
            }
        }

        public T Pop()
        {
            if (_current >= 0)
            {
                var item = _items[_current];
                _current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }

        public T Peek()
        {
            if (_current >= 0)
            {
                return _items[_current];
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }
    }
}
