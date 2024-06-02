// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("using Object Adapter");
IChild triceratopsChild = ChildCreator.CreateChild(new TriceratopsToMammalAdapter(new Triceratops()));
triceratopsChild.Cry();

Console.WriteLine("using Class Adapter");
triceratopsChild = ChildCreator.CreateChild(new TricercertopsToMammalClassAdapter());
triceratopsChild.Cry();