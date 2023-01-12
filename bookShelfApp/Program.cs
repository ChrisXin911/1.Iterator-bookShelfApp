// See https://aka.ms/new-console-template for more information
using bookShelfApp;
using System.Collections.Specialized;

BookShelf books = new BookShelf(4);
books.appendBook(new Book("abook"));
books.appendBook(new Book("bible"));
books.appendBook(new Book("cinderella"));
books.appendBook(new Book("dad"));

Itetator it= books.iterator();

while (it.hasNext())
{
Book book=(Book)it.next();
    Console.WriteLine(book.getName());
}


