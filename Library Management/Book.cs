using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    internal class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        // Read books from the file


    public Book(string title, string author, string isbn) 
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            IsBorrowed =false;
        }

        public Book(string title)
        {
            this.Title = title;
        }

        public void AbouBook()
        {
            Console.WriteLine($" Book Title: {Title} \n Author: {Author} \n ISBN: {ISBN} \n");
        }

        //public void GetAllBooksByName() 
        //{
        //    Console.WriteLine($" Book Title: {Title}");
        //}

        public bool BorrowBook() {
           
                if (!IsBorrowed)
                {
                    IsBorrowed = true;
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public static List<Book> GetBookFromFile(string filePath)
        {
            List<Book> bookTitles = new List<Book>();

            try
            {
                // Read books from the file
                string[] books = File.ReadAllLines(filePath);
              //  Console.WriteLine("Books in the file:");
                foreach (string line in books)
                {
                    string[] parts = line.Split(',');
                    string bookTitle = parts[0].Trim();
                    string bookAuthor = parts[1].Trim();
                    string bookIsbn = parts[2].Trim();

                    Book book = new Book(bookTitle, bookAuthor, bookIsbn);
                    bookTitles.Add(book);

                    // Console.WriteLine(bookTitle);
                    //Console.WriteLine(bookAuthor);
                    //Console.WriteLine(bookIsbn);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return bookTitles;
        }

        public void GetAllBooksByName() { 
            Book.GetBookFromFile(this.Title);
        }

        public void ReturnBook()
        {
            IsBorrowed = false;
        }
    }
}
