using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Menu
    {
        static void Main()
        {
            //new Library
            Library library = new Library();

           

            while (true)
            {
                Console.WriteLine("Welcome to the Library System");
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Display available books");
                Console.WriteLine("5. Display active Users");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You selected option 1: Create a user");
                        Console.Write("Enter user name: ");

                        string userName = Console.ReadLine();
                        User newUser = new User(userName);
                        library.AddUser(newUser);

                        Console.WriteLine("New user created successfully.");

                        break;
                        
                    case "2":

                        Console.WriteLine("You selected option 2: Borrow a book");
                        library.DisplayAllBooks();
                        Console.Write("Enter the title of the book to borrow: ");
                        string bookName = Console.ReadLine();
                        Book bookToBorrow = library.books.Find(book => book.Title == bookName);
                        if (bookToBorrow != null)
                        {
                            Console.Write("Enter user name: ");
                            string borrowerName = Console.ReadLine();
                            User borrower = library.users.Find(user => user.Name == borrowerName);
                            if (borrower != null && library.BorrowBook(bookToBorrow, borrower))
                            {
                                Console.WriteLine($"{bookToBorrow.Title} borrowed successfully by {borrower.Name}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid user or book is already borrowed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("You selected option 3: Return a book");
              
                        break;
                    case "4":
                        Console.WriteLine("You selected option 4: Display available books");

                        library.DisplayAllBooks();
                        
                        break;
                    case "5":
                        Console.WriteLine("You selected option 5 : Display active Users");
                        library.DisplayAllUSers();

                        break;
                    case "6":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
    }
}
