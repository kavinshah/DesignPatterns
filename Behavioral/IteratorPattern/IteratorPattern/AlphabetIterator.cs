using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class AlphabetIterator : IEnumerator
    {
        protected WordsCollection _collection;
        protected int _position;

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
            _position = -1;
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

        public virtual void Reset()
        {
#if DEBUG
            Console.WriteLine("Reset Method called");
#endif
            _position = -1;
        }

        public virtual bool MoveNext()
        {
            if ((_position + 1) >= _collection.Count)
            {
#if DEBUG
                Console.WriteLine("_position>_collection.Count");
#endif
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
        protected List<string> _collection;

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

        public virtual AlphabetIterator GetEnumerator()
        {
            return new AlphabetIterator(this);
        }
    }

    internal class WordCollectionWithSkipIteration : WordsCollection
    {
        public override SkipIterator GetEnumerator()
        {
            return new SkipIterator(this);
        }
    }

    internal class SkipIterator : AlphabetIterator
    {
        WordCollectionWithSkipIteration _collection;
        public SkipIterator(WordCollectionWithSkipIteration collection) : base(collection)
        {
            _position = -2;
            _collection = collection;
        }

        public override bool MoveNext()
        {
            if ((_position + 2) >= _collection.Count)
            {
#if DEBUG
                Console.WriteLine("_position>_collection.Count");
#endif
                return false;
            }
            _position += 2;
#if DEBUG
            Console.WriteLine($"_Position:{_position}");
#endif
            return true;
        }
    }

}

