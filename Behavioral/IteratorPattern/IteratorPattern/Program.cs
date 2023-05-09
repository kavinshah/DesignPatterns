// See https://aka.ms/new-console-template for more information
using IteratorPattern;

WordsCollection collection = new WordsCollection();
collection.AddItem("Kavin");
collection.AddItem("Shah");
collection.AddItem("Sharad");

foreach (var item in collection)
{
    Console.WriteLine(item);
}

Console.WriteLine("Using while loop");

AlphabetIterator iterator = collection.GetEnumerator();
while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}

