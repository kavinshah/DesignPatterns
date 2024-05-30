using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /*
     
    1. The Abstraction class acts as a blueprint for its future concrete implementations.

    2. The Implementation class acts as a blueprint for its future concrete implementations.

    3. Using the skeleton of type Implementation:- 
    Abstraction class defines methods 'Method1' and 'Method2' which make internal calls to methods 'Method1' and 'Method2'
    
    4. The concrete types ConcreteImplementation class will now override blueprint methods 'MethodA' and 'MethodB' of Implementation class

    This approach lets the Abstraction and Implementation types to evolve independently of each other.

     */
    internal abstract class Abstraction
    {
        protected Implementation _implementation;

        public virtual void MethodA()
        {
            Console.WriteLine("Abstraction : Method A");
            return;
        }

        public virtual void MethodB()
        {
            Console.WriteLine("Abstraction : Method B");
            return;
        }
    }

    internal class ConcreteAbstraction: Abstraction
    {
        public ConcreteAbstraction(Implementation implementation)
        {
            _implementation = implementation;
        }

        public override void MethodA()
        {
            Console.WriteLine("Concrete Abstraction : Method A");
            _implementation.Method1();
            return;
        }

        public override void MethodB()
        {
            Console.WriteLine("Concrete Abstraction : Method B");
            _implementation.Method2();
            return;
        }
    }

    internal abstract class Implementation
    {
        public virtual void Method1()
        {
            Console.WriteLine("Abstract Implementation : Method 1");
            return;
        }

        public virtual void Method2()
        {
            Console.WriteLine("Abstract Implementation : Method 2");
            return;
        }
    }

    internal class ConcreteImplementation : Implementation
    {
        public override void Method1()
        {
            Console.WriteLine("Concrete Implementation : Method 1");
            return;
        }

        public override void Method2()
        {
            Console.WriteLine("Concrete Implementation : Method 2");
            return;
        }

    }
}
