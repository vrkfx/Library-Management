using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management
{
    internal class Library
    {
        public List<Book> books;
        public Book results;
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
                if (books.Count <= 0) 
                {
                    Console.WriteLine("Library has no books");
                }

                book.GetAllBooksByName();
            }
        }

        public Book SearchBook(String title) 
        {
            results = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(results);
            return results;
        }

        public int TotalNumberOfBooks() 
        {
            return books.Count;
        }

    }
}
