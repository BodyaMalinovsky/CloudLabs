using EleksCamp_CA.Domain;

namespace EleksCamp_CA.Factories
{
    public class BookFromHouse : Book
    {
        public string HouseName { get; set; }

        public BookFromHouse(string name, int pages, string houseName)
            : base(name, pages, $"Bookhouse {houseName}")
        {
            this.HouseName = houseName;
        }
    }
}
