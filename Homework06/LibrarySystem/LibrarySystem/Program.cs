using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book { Title = "Book 1", Author = "Author 1", Year = 2020 });
            library.AddBook(new Book { Title = "Book 2", Author = "Author 2", Year = 2015 });
            library.AddBook(new Book { Title = "Book 3", Author = "Author 1", Year = 2019 });

            Console.WriteLine("Library Contents:");
            Console.WriteLine("=================");

            // Yvela wignis dabewdva
            foreach (var book in library.books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }

            Console.WriteLine();

            // Wignis povna avtorit
            Console.WriteLine("Books by Author 1:");
            library.PrintBook("Author 1");
            Console.WriteLine();

            // Wignis modzebvna saxelwodebit
            Console.WriteLine("Books with Title 'Book 1':");
            var foundBooks = library.FindBooks("Book 1");
            foreach (var book in foundBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }

            Console.WriteLine();

            // Wignis washla
            Book bookToRemove = new Book { Title = "Book 2", Author = "Author 2", Year = 2015 };
            if (library.RemoveBook(bookToRemove))
            {
                Console.WriteLine($"Book '{bookToRemove.Title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{bookToRemove.Title}' not found in the library.");
            }

            Console.WriteLine("Updated Library Contents:");
            Console.WriteLine("=================");

            // ganaxlebuli siis dabewdva washlis shemdeg
            foreach (var book in library.books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
    }
}