using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /*
     * This is a generic class which is used to create children
     */
    internal static class ChildCreator
    {
        internal static IChild CreateChild(IMammal mammal)
        {
            return mammal.GiveBirth();
        }
    }

    //Mammal interface to give birth
    internal interface IMammal
    {
        IChild GiveBirth();
    }

    // Generic Child interface
    internal interface IChild
    {
        void Cry();
    }

    // a new legacy class with different implementation
    internal class Triceratops
    {
        public TriceratopsEggs LayEggs()
        {
            return new TriceratopsEggs();
        }
    }

    internal class TriceratopsEggs
    {
        public IChild HatchEggs()
        {
            return new TriceratopsChild();
        }
    }

    internal class TriceratopsChild : IChild
    {
        public TriceratopsChild() { }

        public void Cry()
        {
            Console.WriteLine("TRICERATOPS IS CRYING!");
        }
    }

    /* 
     * Our adapter to wrap methods to give birth
     * We are using object adapter here.
    */
    internal class TriceratopsToMammalAdapter : IMammal
    {
        Triceratops triceratops;
        public TriceratopsToMammalAdapter(Triceratops triceratops)
        {
            this.triceratops = triceratops;
        }
        public IChild GiveBirth()
        {
            return triceratops?.LayEggs().HatchEggs();
        }
    }
}
