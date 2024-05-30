namespace Bridge
{
    /*
    
    We assign the concrete implementations of Abstraction and Implementation types and then call the skeleton methods.
    This decouples the code and lets the types evolve independent of each other.

    Resources:
    https://www.dofactory.com/net/bridge-design-pattern

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementation());
            abstraction.MethodA();
            abstraction.MethodB();
        }
    }
}
