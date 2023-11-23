using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal interface ICommand
    {
        void Execute();
    }

    internal class ComplexCommand : ICommand
    {
        Receiver receiver;
        public ComplexCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.DoSomething1();
            //use the receiver in some form
            receiver.DoSomething2();

        }
    }

    internal class SimpleCommand : ICommand
    {

        public void Execute()
        {
            //use the receiver in some form
            Console.WriteLine("Performing simple command");
        }
    }

    internal class Receiver
    {
        public void DoSomething1()
        {
            Console.WriteLine("Doing something in method 1 in the receiver");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Doing something in method 2 in the receiver");
        }
    }

    internal class Invoker
    {
        ICommand onStart, onFinish;
        public void OnStart(ICommand command)
        {
            this.onStart = command;
        }

        public void OnFinish(ICommand command)
        {
            this.onFinish = command;
        }

        public void Execute()
        {
            Console.WriteLine("Performing some action onstart");
            if (onStart != null)
                onStart.Execute();

            Console.WriteLine("Performing some action onfinish");

            if (onFinish != null)
                onFinish.Execute();
        }
    }
}
