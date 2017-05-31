using System;
using System.Collections.Generic;
using System.Linq;
using EleksCamp_CA.Domain;
using EleksCamp_CA.Interfaces;

namespace EleksCamp_CA
{
    public class Library : ICountingBooks
    {
        public IList<Book> AllBooks { get; private set; }
        public IList<Department> Departments { get; private set; }
        public IList<Autor> Autors { get; private set; }

        public Library()
        {
            AllBooks = new List<Book>();
            Departments = new List<Department>();
            Autors = new List<Autor>();
        }
        
        public Library AddBook(string name, int pages, string author, string department)
        {
            var book = new Book(name, pages);
            this.AllBooks.Add(book);

            Department existingDepartment = this.Departments.FirstOrDefault(dep => dep.Name == department);

            if (existingDepartment == null)
            {
                existingDepartment = new Department(department);
                this.Departments.Add(existingDepartment);
            }

            existingDepartment.AddBookById(book.Id);
 
            Autor existAutor = this.Autors.FirstOrDefault(aut => aut.Name == author);

            if (existAutor == null)
            {
                existAutor = new Autor(author);
                this.Autors.Add(existAutor);
            }

            existAutor.AddBookById(book.Id);

            //var xml = new XmlWork();
            //xml.CreateXML(book.Id, autor, department, name, pages, "Library.xml");

            return this;
        }
        
        public int GetBooksCount()
        {
            return AllBooks.Count;
        }

        public void PrintAllBooks()
        {
            Console.WriteLine("\nAll library books:");
            foreach (Book book in this.AllBooks)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void PrintAllAuthors()
        {
            Console.WriteLine("\nAll library authors:");
            foreach (Autor autor in this.Autors)
            {
                Console.WriteLine(autor.Name);
            }
        }

        public void PrintAllDepartments()
        {
            Console.WriteLine("\nAll library departments:");
            foreach (Department department in this.Departments)
            {
                Console.WriteLine(department.Name);
            }
        }
    }   
}