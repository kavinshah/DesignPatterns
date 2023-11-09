// See https://aka.ms/new-console-template for more information

using Adapter;

IChild triceratopsChild = ChildCreator.CreateChild(new TriceratopsToMammalAdapter(new Triceratops()));
triceratopsChild.Cry();
