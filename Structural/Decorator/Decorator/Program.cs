// See https://aka.ms/new-console-template for more information
using Decorator;
using static Decorator.Video;

Book book = new Book("Morhan Housel", "The Psychology of Money", 20);
book.Display();

Video video = new Video("Some exotic director name", "Good Will Hunting", 120, 10);
video.Display();

Console.WriteLine("Making video borrowable");

Borrowable borrowable = new Borrowable(video);
borrowable.Borrow("Customer 1");
borrowable.Borrow("Customer 2");
borrowable.Display();