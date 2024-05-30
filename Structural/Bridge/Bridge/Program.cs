namespace Bridge
{
    /*
    


     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new ConcreteAbstraction(new ConcreteImplementation());
            abstraction.MethodA();
            abstraction.MethodB();
        }
    }
}
