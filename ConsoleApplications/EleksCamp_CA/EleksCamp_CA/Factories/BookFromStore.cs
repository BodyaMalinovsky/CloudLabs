using EleksCamp_CA.Domain;

namespace EleksCamp_CA.Factories
{
    public class BookFromStore : Book
    {
        public int Price { get; set; }

        public BookFromStore(string name, int pages, int price)
            : base(name, pages, $"Book price {price}")
        {
            this.Price = price;
        }
    }
}
