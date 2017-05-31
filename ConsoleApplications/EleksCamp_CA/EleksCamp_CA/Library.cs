using System;
using System.Collections.Generic;
using EleksCamp_CA.Domain;
using EleksCamp_CA.Interfaces;

namespace EleksCamp_CA
{
    public class Library : ICountingBooks
    {
        private readonly IList<Book> _allBooks;
        private readonly IList<Department> _departments;
        private readonly IList<Autor> _autors;

        public Library()
        {
            _allBooks = new List<Book>();
            _departments = new List<Department>();
            _autors = new List<Autor>();
        }

        public void AddBook(string autor, string department, string name, int pages)
        {
            var book = new Book(name, pages);
            
            _allBooks.Add(book);
            
            XmlWork xml = new XmlWork();
            xml.CreateXML(book.Id, autor, department, name, pages, "Library.xml");
        }

        public void AddBook(Book book)
        {
            _allBooks.Add(book);
        }

        public void PrintAllBooks()
        {
            foreach (var book in _allBooks)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public int GetBooksCount()
        {
            return _allBooks.Count;
        }
    }   
}