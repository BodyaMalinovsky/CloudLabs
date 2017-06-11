using System;
using EleksCamp_CA.Factories;
using EleksCamp_CA.Interfaces;

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

            IBookFactory bookhouse = new Bookhouse();
            IBookFactory bookstore = new Bookstore();
            
            Console.WriteLine(bookhouse.GetBook().ToString());
            Console.WriteLine(bookstore.GetBook().ToString());

            Console.ReadKey();
        }
    }
}