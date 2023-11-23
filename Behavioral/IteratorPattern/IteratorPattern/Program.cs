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

Console.WriteLine("Using skip iteration");
collection = new WordCollectionWithSkipIteration();
collection.AddItem("Kavin");
collection.AddItem("Sharad");
collection.AddItem("Shah");
foreach (var item in collection)
{
    Console.WriteLine($"{item}");
}

IEnumerable<T> GetValues<T>(params T[] values)
{
    foreach (T value in values)
    {
        yield return value;
    }
}

Console.WriteLine("\nUsing Polymorphic Iterators");
var polymorphicCollection = new PolymorphicCollection<string>();
polymorphicCollection.AddItem("Kavin");
polymorphicCollection.AddItem("Sharad");
polymorphicCollection.AddItem("Shah");
foreach (string item in polymorphicCollection)
{
    Console.WriteLine(item);
}