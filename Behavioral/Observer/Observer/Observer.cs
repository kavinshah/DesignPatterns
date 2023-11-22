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
        ISubject subject;
        ConcreteObserverA(ISubject subject)
        {
            this.subject = subject;
        }

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

    public readonly record struct BaggageInfo
    (
        int FlightNumber,
        string From,
        int Carousel
    );

    internal class classA : IObservable<BaggageInfo>
    {
        private readonly HashSet<IObserver<BaggageInfo>> _observers = new();
        private readonly HashSet<BaggageInfo> _flights = new();
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            return new Unsubscriber<BaggageInfo>(_observers, observer);
        }
    }

    internal sealed class Unsubscriber<BaggageInfo> : IDisposable
    {
        private readonly ISet<IObserver<BaggageInfo>> _observers;
        private readonly IObserver<BaggageInfo> _observer;

        internal Unsubscriber(
            ISet<IObserver<BaggageInfo>> observers,
            IObserver<BaggageInfo> observer) => (_observers, _observer) = (observers, observer);

        public void Dispose() => _observers.Remove(_observer);
    }
}
