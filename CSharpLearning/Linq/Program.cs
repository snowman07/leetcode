// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// REFERENCE: https://www.youtube.com/watch?v=PHogstYNnew

using Linq;
using System.Linq;

//var myBooks = new List<Book>
//            {
//                new Book {Title = "Advanced C#", Price = 9.99},
//                new Book {Title = "OOP with C#", Price = 14.99},
//                new Book {Title = "C# For Beginners", Price = 19.99},
//                new Book {Title = "Complete ASP.NET Core", Price = 29.99}
//            };

////Without LINQ
//foreach (var book in myBooks)
//{
//    if (book.Title.Contains("C#"))
//    {
//        Console.WriteLine(book.Title);
//    }
//}

//With LINQ
List<Book> myBooks = ListOfBooks.bookSampleData();
//var myNewBooks = myBooks.Where(b => b.Title.Contains("C#")).Select(b => b.Title);
var myNewBooks = myBooks.Where(b => b.Title.Contains("C#"))
    .OrderBy(b => b.Title)
    .Select(b => b.Title);
foreach (var book in myNewBooks)
{
    Console.WriteLine(book);
}

Console.ReadLine();
