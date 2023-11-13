using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2
{
    internal interface IPlant
    {
        void Eat();
    }

    /// <summary>
    /// The Eat() method belongs to the component inteface IPlant
    /// </summary>
    internal class Leaf : IPlant
    {
        bool isEaten = false;
        public Leaf() { }

        public void Eat()
        {
            isEaten = true;
            Console.WriteLine("A Leaf is eaten");
        }
    }

    /// <summary>
    /// The Eat() method allows us to treat the individual 
    /// objects (Leaf) in the same way as the composite object Branch
    /// </summary>
    internal class Branch : IPlant
    {
        IList<IPlant> leaves;

        public Branch(IList<IPlant> leaves)
        {
            this.leaves= leaves;
        }

        public void Eat()
        {
            foreach(IPlant leaf in leaves)
            {
                leaf.Eat();
            }
        }
    }

    internal class Composite
    {
        public void Run()
        {
            IPlant branch1 = new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf() });
            
            IPlant branch2_1 = new Branch(new List<IPlant>() { new Leaf(), new Leaf() });
            IPlant branch2_2 = new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf() });
            IPlant branch2 = new Branch(new List<IPlant>() { branch2_1, branch2_2 });
            
            IPlant plant = new Branch(new List<IPlant>() { branch1, branch2 , new Leaf(), new Leaf()});

            plant.Eat();
        }

    }
}
