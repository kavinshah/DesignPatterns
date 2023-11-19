// See https://aka.ms/new-console-template for more information
using Observer;

Subject subject = new Subject();
IObserver observer1 = new ConcreteObserverA();
IObserver observer2 = new ConcreteObserverB();

subject.Attach(observer1);
subject.Attach(observer2);

subject.SomeBusinessLogic();

subject.Detach(observer2);

subject.SomeBusinessLogic();

