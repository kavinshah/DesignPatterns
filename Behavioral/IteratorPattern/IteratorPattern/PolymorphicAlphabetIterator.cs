using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class PolymorphicAlphabetIterator<T>
    {
        private int _position = -1;
        private PolymorphicCollection<T> _collection;
        public PolymorphicAlphabetIterator(PolymorphicCollection<T> collection)
        {
            _collection = collection;
        }

        public T Current
        {
            get
            {
                return _collection.GetItem(_position);
            }
        }

        public bool MoveNext()
        {
            if ((_position + 1) >= _collection.Count)
                return false;
            _position++;
            return true;
        }
    }

    internal class PolymorphicCollection<T>
    {
        private List<T> _items;

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public PolymorphicCollection()
        {
            _items = new List<T>();
        }

        public void AddItem(T value)
        {
            _items.Add(value);
        }

        public T GetItem(int index)
        {
            return _items[index];
        }

        public PolymorphicAlphabetIterator<T> GetEnumerator()
        {
            return new PolymorphicAlphabetIterator<T>(this);
        }
    }
}
