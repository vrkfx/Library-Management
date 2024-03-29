﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library_Management
{
    internal class User
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<Book> borrowedBooks;
    //    public List<Library> booksInLibrary;

        public User(string name)
        {
            Name = name;
            borrowedBooks = new List<Book>();
        }

        public void GetAllUserName(List<User> users)
        {

            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        public bool BorrowBook(Book book)
        {
            if (book.BorrowBook())
            {
                borrowedBooks.Add(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"{Name}'s Borrowed Books:");
            foreach (var book in borrowedBooks)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        public bool ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                book.ReturnBook();
                borrowedBooks.Remove(book);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
