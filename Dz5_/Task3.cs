using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz5_
{
    class BookList
    {
        private List<string> books = new List<string>();

        public void Add(string book)
        {
            books.Add(book);
        }

        public void Remove(string book)
        {
            books.Remove(book);
        }

        public bool Contains(string book)
        {
            return books.Contains(book);
        }

        public int Count
        {
            get { return books.Count; }
        }

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public static BookList operator +(BookList bookList, string book)
        {
            bookList.Add(book);
            return bookList;
        }

        public static BookList operator -(BookList bookList, string book)
        {
            bookList.Remove(book);
            return bookList;
        }
    }
}