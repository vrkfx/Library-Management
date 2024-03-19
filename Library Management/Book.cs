using System;
using System.Collections.Generic;
using System.Linq;
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

        public Book(string title, string author, string isbn) 
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }

        public void AbouBook()
        {
            Console.WriteLine($" Book Title: {Title} \n Author: {Author} \n ISBN: {ISBN} \n");
        }

        public void GetAllBooksByName() 
        {
            Console.WriteLine($" Book Title: {Title}");
        }

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
    }
}
