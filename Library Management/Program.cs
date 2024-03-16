using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Library_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an Instance of Book Class 
            Book book1 = new Book("The Great Gatsby", "F. Scott ", "23456789");
            Book book2 = new Book("The Great Ocean", "F. Fitzgerald", "8549234");
            Book book3 = new Book("ChatGPT 3.5", "F. Virroshan", "4567890");

            //Book Information
            book1.AbouBook();
            book2.AbouBook();
            book3.AbouBook();

            Console.WriteLine("-------------------------------------------------------------------------------------");

            // Library
            Library library = new Library();
            Console.WriteLine("This Library has " + library.totalNumberOfBooks() + " books");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Adding one book the library");
            library.AddBook(book1);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Books in the Library");
            library.DisplayAll();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Adding more books to the library");
            library.AddBook(book2);
            library.AddBook(book3);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Books in the Library");
            library.DisplayAll();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Removing one book in the Library");
            library.RemoveBook(book1);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Books in the Library");
            library.DisplayAll();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("This Library has " + library.totalNumberOfBooks() + " books");
           
            //search for Book
            Console.WriteLine("Enter the title of the book you want to search for:");
            string titleTosearch = Console.ReadLine();
            Console.WriteLine("Debug1");
            Book foundBook = library.SearchBook(titleTosearch);
            Console.WriteLine("Debug2");
            // Check if the book was found
            if (foundBook != null)
            {
                // Book found, display its details
                Console.WriteLine("Book found!");
            }
            else
            {
                // Book not found
                Console.WriteLine("Book not found!");
            }

            















            Console.ReadLine();
        }
    }
}
