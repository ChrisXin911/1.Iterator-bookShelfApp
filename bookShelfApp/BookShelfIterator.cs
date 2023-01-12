using System.Runtime.Intrinsics.X86;

namespace bookShelfApp
{
    public class BookShelfIterator : Itetator
    {
        private BookShelf bookShelf;
        private int index;
        public BookShelfIterator(BookShelf bookShelf)
        {
           
                this.bookShelf = bookShelf;                                 
        }

        public bool hasNext()
        {
            if (index < bookShelf.getLength())
            {
                return true;
            }
            else return false;
        }

        public object next()
        {
            Book book = this.bookShelf.getBookAt(index);                       
            index++;
            return book;
        }
    }
}