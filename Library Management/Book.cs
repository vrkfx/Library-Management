using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    internal class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public String ISBN { get; set; }

        public Book(String title, String author, String isbn) 
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }

        public void AbouBook()
        {
            Console.WriteLine($" Book Title: {Title} \n Author: {Author} \n ISBN: {ISBN} \n Genre: {Genre}");
        }

        public void GetAllBooksByName() 
        {
            Console.WriteLine($" Book Title: {Title}");
        }
    }
}
