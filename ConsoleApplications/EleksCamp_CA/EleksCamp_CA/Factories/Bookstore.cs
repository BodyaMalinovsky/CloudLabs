using EleksCamp_CA.Domain;
using EleksCamp_CA.Interfaces;

namespace EleksCamp_CA.Factories
{
    public class Bookstore : IBookFactory
    {
        public Book GetBook()
        {
            return new BookFromStore("Book from bookstore", 382, 250);
        }
    }
}
