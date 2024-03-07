using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management
{
    internal class Library
    {
        public List<Book> books;

        public Library() 
        {
            books = new List<Book> ();
        }

        public void AddBook(Book book) 
        {
            books.Add(book);
            Console.WriteLine($" '{book.Title}' has been Added to Library ");
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($" '{book.Title}' has been removed from library");
        }

        public void DisplayAll() 
        { 
            foreach (Book book in books)
            {
                book.GetAllBooksByName();
            }
        }

        public Book SearchBook(String title) {

            return books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
