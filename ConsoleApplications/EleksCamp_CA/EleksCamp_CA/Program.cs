using System;
using System.Collections.Generic;
using System.Linq;
using EleksCamp_CA.Domain;

namespace EleksCamp_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            //library.AddBook("Bodyan", "Science", "FirstBook", 516);
            //library.AddBook("Svyat", "Mathematics", "SecondBook", 1032);
            //library.AddBook("Vova", "Phisics", "ThirdBook", 2064);
            //library.AddBook("Maks", "Programming", "FourthBook", 1001);

            //Console.WriteLine("Books amount in the library: {0}", library.GetBooksCount());

            //library.PrintAllBooks();
            //var xmlwork = new XmlWork();
            //xmlwork.SortByPages("Library.xml");

            var richter = new Autor("Richter");
            richter.AddBook(52);
            richter.AddBook(53);
            richter.AddBook(54);
            richter.AddBook(55);
            Console.WriteLine(richter.GetBooksCount());

            IList<string> bookIds = richter.BooksIds.Select(bookId => bookId.ToString()).ToList();
            string booksResult = bookIds.Aggregate((previousValue, newValue) => previousValue + ", " + newValue);

            Console.WriteLine(booksResult);



            Console.WriteLine("Hello Extension method".ToString2());
            Console.ReadKey();
        }
    }

    static class StringExtensions
    {
        public static string ToString2(this string source)
        {
            return "Bodya sais: " + source;
        }
    }
}