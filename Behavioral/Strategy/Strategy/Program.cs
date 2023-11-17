// See https://aka.ms/new-console-template for more information

using Strategy;

Context context = new Context(new StrategyAdd());
Console.WriteLine(context.Execute(10, 5));

context = new Context(new StrategySubtract());
Console.WriteLine(context.Execute(10, 5));

context = new Context(new StrategyMultiply());
Console.WriteLine(context.Execute(5, 10));

