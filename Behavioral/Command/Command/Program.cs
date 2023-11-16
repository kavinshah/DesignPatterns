// See https://aka.ms/new-console-template for more information
using Command;

Invoker invoker = new Invoker();
invoker.OnStart(new SimpleCommand());
invoker.OnFinish(new ComplexCommand(new Receiver()));
invoker.Execute();

