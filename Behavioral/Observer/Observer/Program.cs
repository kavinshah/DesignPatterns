// See https://aka.ms/new-console-template for more information
using Observer;

Observable observable = new Observable();
IObserver observer1 = new ConcreteObserverA();
IObserver observer2 = new ConcreteObserverB();

observable.Attach(observer1);
observable.Attach(observer2);

observable.SomeBusinessLogic();

observable.Detach(observer2);

observable.SomeBusinessLogic();

