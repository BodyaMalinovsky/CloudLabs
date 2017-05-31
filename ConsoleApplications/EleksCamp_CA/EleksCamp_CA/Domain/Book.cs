using System;

namespace EleksCamp_CA.Domain
{
    public class Book : IComparable
    {
        private static int _counter = 0;

        private readonly int _id;
        public int Id => this._id; 

        private readonly string _name;
        public string Name => this._name;

        private readonly int _pages;
        public int Pages => this._pages;

        public Book(string name, int pages)
        {
            this._name = name;
            this._pages = pages;
            this._id = _counter++;
        }

        public override string ToString()
        {
            return $"Book name: '{_name}', Pages={_pages}. Internal book id={_id} (remove)";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book otherBook = obj as Book;

            if (otherBook != null)
            {
                throw new NotImplementedException("CompareTo method not implemented yet");
            }

            throw new ArgumentException("Object is not a Book");
        }
    }
}