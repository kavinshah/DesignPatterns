using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class LibraryItem
    {
        private int numCopies;

        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }

        public abstract void Display();
    }

    internal class Book : LibraryItem
    {
        string author;
        string title;
        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook");
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("#copies: {0}", NumCopies);
        }
    }

    internal class Video: LibraryItem
    {
        string director;
        string title;
        int playtime;
        
        public Video(string director, string title, int playtime, int numofCopies)
        {
            this.director = director;
            this.title = title;
            this.playtime = playtime;
            this.NumCopies = numofCopies;
        }
        public override void Display()
        {
            Console.WriteLine("\nVideo");
            Console.WriteLine("Director: {0}", director);
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("PlayTime: {0}", playtime);
            Console.WriteLine("# Copies: {0}", NumCopies);
        }

        internal class Decorator: LibraryItem
        {
            LibraryItem item;
            public Decorator(LibraryItem item)
            {
                this.item = item;
            }

            public override void Display()
            {
                item.Display();
            }
        }

        internal class Borrowable : Decorator
        {
            List<string> borrowers = new List<string>();
            public Borrowable(LibraryItem item) : base(item)
            {
            }

            public void Borrow(string name)
            {
                borrowers.Add(name);
                NumCopies--;
            }

            public void Return(string name)
            {
                borrowers.Remove(name);
                NumCopies++;
            }

            public override void Display()
            {
                base.Display();

                foreach(string name in borrowers)
                {
                    Console.WriteLine("Borrower:" + name);
                }
            }
        }
    }
}
