using System;

namespace EleksCamp_CA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library()
                .AddBook("Book1", 123, "Author1", "Department1")
                .AddBook("Book2", 234, "Author2", "Department1")
                .AddBook("Book3", 345, "Author3", "Department1")
                .AddBook("Book4", 456, "Author1", "Department2")
                .AddBook("Book5", 567, "Author2", "Department2");
            
            Console.WriteLine("Books amount in the library: {0}", library.GetBooksCount());

            library.PrintAllBooks();
            library.PrintAllAuthors();
            library.PrintAllDepartments();

            //var xmlwork = new XmlWork();
            //xmlwork.SortByPages("Library.xml");

            //var richter = new Autor("Richter");
            //richter.AddBook(52);
            //richter.AddBook(53);
            //richter.AddBook(54);
            //richter.AddBook(55);
            //Console.WriteLine(richter.GetBooksCount());

            //IList<string> bookIds = richter.BooksIds.Select(bookId => bookId.ToString()).ToList();
            //string booksResult = bookIds.Aggregate((previousValue, newValue) => previousValue + ", " + newValue);

            //Console.WriteLine(booksResult);

            //Console.WriteLine("Hello Extension method".ToString2());
            Console.ReadKey();
        }
    }

    public static class StringExtensions
    {
        public static string ToString2(this string source)
        {
            return "Bodya sais: " + source;
        }
    }
}