using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface IObserver
    {
        public void Update(ISubject subject);
    }

    internal interface ISubject
    {
        int State { get; set; }
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

    internal class Subject : ISubject
    {
        int status;
        List<IObserver> listeners;

        public int State
        {
            get { return status; }
            set { status = value; }
        }

        public Subject()
        {
            listeners = new List<IObserver>();
        }

        public void Attach(IObserver oberver)
        {
            listeners.Add(oberver);
        }

        public void Detach(IObserver oberver)
        {
            listeners.Remove(oberver);
        }

        public void Notify() 
        {
            foreach(IObserver observer in listeners)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Performing some business logic");
            State = Random.Shared.Next(10);
            Thread.Sleep(1000);
            Notify();

        }
    }

    internal class ConcreteObserverA : IObserver 
    {
        public void Update(ISubject subject)
        {
            if(subject != null && subject.State < 3)
            {
                Console.WriteLine($"State value has change to {subject.State} in observerA");
            }
        }
    }

    internal class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject != null && (subject.State == 0 || subject.State > 3))
            {
                Console.WriteLine($"State value has change to {subject.State} observerB");
            }
        }
    }
}
