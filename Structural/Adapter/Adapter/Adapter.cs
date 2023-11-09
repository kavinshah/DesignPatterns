using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal static class ChildCreator
    {
        internal static IChild CreateChild(IMammal mammal)
        {
            return mammal.GiveBirth();
        }
    }
    
    internal interface IChild
    {
        void Cry();
    }

    internal interface IMammal
    {
        IChild GiveBirth();
    }

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
