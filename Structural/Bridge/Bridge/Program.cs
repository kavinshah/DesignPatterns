﻿namespace Bridge
{
    /*
    
    We assign the concrete implementations of Abstraction and Implementation types and then call the skeleton methods.
    This decouples the code and lets the types evolve independent of each other.

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