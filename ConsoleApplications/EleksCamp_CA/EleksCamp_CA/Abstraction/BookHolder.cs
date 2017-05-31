using System.Collections.Generic;
using EleksCamp_CA.Interfaces;

namespace EleksCamp_CA.Abstraction
{
    public abstract class BookHolder : ICountingBooks
    {
        private readonly IList<int> _booksIds;
        public IList<int> BooksIds => this._booksIds;

        protected BookHolder() : this(new List<int>())
        { }

        protected BookHolder(IList<int> booksIds)
        {
            this._booksIds = booksIds;
        }

        public void AddBookById(int bookId)
        {
            this._booksIds.Add(bookId);
        }

        public int GetBooksCount()
        {
            return this._booksIds.Count;
        }
    }
}
