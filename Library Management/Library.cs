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
        public List<User> users;
        public Book results;

        // Read books from the file

        public Library() 
        {
            books = new List<Book> ();
            users = new List<User>();
        }

        public void AddBook(Book book) 
        {
            books.Add(book);
            Console.WriteLine($" '{book.Title}' has been Added to Library ");
        }

        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine($" '{user.Name}' has been Added to Library ");
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($" '{book.Title}' has been removed from library");
        }

        public void DisplayAllBooks()
        {

            List<Book> books = Book.GetBookFromFile("C:\\Users\\virro\\Desktop\\Library Management\\Library Management\\Books.txt");
            //  Console.WriteLine("Books in the file:");
            if (books.Count == 0)
            {
                Console.WriteLine("No books found in the file.");
            }
            else
            {
                Console.WriteLine("Books in the file:");
                foreach (Book book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
                }
            }

        }

        public void DisplayAllUSers() 
        {
            User userObject = new User("");
            if (userObject == null) 
                {
                    Console.WriteLine("Library has no active Users");
                }
            userObject.GetAllUserName(users);
            
        }

        public Book SearchBook(String title) 
        {
            results = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(results);
            return results;
        }


        public bool BorrowBook(Book book, User user)
        {
            if (books.Contains(book) && !book.IsBorrowed && users.Contains(user))
            {
                book.BorrowBook();
                user.BorrowBook(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int TotalNumberOfBooks() 
        {
            return books.Count;
        }

        public bool BorrowBook(Book book)
        {
            if (books.Contains(book) && !book.IsBorrowed)
            {
                books.Remove(book);
                book.BorrowBook();
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}
