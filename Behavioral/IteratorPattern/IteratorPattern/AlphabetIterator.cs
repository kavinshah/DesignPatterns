using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class AlphabetIterator : IEnumerator
    {
        private WordsCollection _collection;
        private int _position = -1;

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public string Current
        {
            get
            {
#if DEBUG
                Console.WriteLine($"Current:{_collection.GetItem(_position)}");
#endif
                return _collection.GetItem(_position);
            }
        }

        public AlphabetIterator(WordsCollection collection)
        {
            _collection = collection;
        }

        bool IEnumerator.MoveNext()
        {
            return MoveNext();
        }

        void IEnumerator.Reset()
        {
            Reset();
        }

        public void Reset()
        {
#if DEBUG
            Console.WriteLine("Reset Method called");
#endif
            _position = -1;
        }

        public bool MoveNext()
        {
            if ((_position + 1) >= _collection.Count)
            {
                Console.WriteLine("_position>_collection.Count");
                return false;
            }

            _position++;
#if DEBUG
            Console.WriteLine($"_Position:{_position}");
#endif
            return true;
        }
    }

    internal class WordsCollection : IEnumerable
    {
        private List<string> _collection;

        public int Count
            { get { return _collection.Count; } }

        public WordsCollection()
        {
            _collection = new List<string>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public void AddItem(string item)
        {
            _collection.Add(item);
        }

        public string GetItem(int index)
        {
            return _collection[index];
        }

        public AlphabetIterator GetEnumerator()
        {
            return new AlphabetIterator(this);
        }
    }
}

