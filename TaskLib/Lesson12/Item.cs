using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson12
{
    internal class Item<T>
    {
        public int Key { get; set; }
        public List<T> Items { get; set; }
        public Item(int key)
        {
            Key = key;
            Items = new List<T>();
        }
    }
}
