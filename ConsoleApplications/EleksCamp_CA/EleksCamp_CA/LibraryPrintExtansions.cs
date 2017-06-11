using System;
using EleksCamp_CA.Domain;

namespace EleksCamp_CA
{
    public static class LibraryPrintExtansions
    {
        public static void PrintAllBooks(this Library library)
        {
            Console.WriteLine("\nAll library books:");
            foreach (Book book in library.AllBooks)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public static void PrintAllAuthors(this Library library)
        {
            Console.WriteLine("\nAll library authors:");
            foreach (Autor autor in library.Autors)
            {
                Console.WriteLine(autor.Name);
            }
        }

        public static void PrintAllDepartments(this Library library)
        {
            Console.WriteLine("\nAll library departments:");
            foreach (Department department in library.Departments)
            {
                Console.WriteLine(department.Name);
            }
        }
    }
}
