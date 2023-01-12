using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShelfApp
{
    public class BookShelf : Aggregate
    {
        private Book[] books;
        private int last = 0;
        public BookShelf(int maxsize)
        {
            this.books = new Book[maxsize];
        }
        public void appendBook(Book book)
        {
            this.books[last] = book;
            last++;
        }
        public Book getBookAt(int index)
        {
            return this.books[index];
        }
        public int getLength()
        {
            return this.last;
        }
        public Itetator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}

 
