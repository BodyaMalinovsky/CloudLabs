using EleksCamp_CA.Domain;
using EleksCamp_CA.Interfaces;

namespace EleksCamp_CA.Factories
{
    public class Bookhouse : IBookFactory
    {

        public Book GetBook()
        {
            return new BookFromHouse("Book from bookhouse", 223, "Valhalla");
        }
    }
}
