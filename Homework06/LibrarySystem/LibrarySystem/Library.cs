using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        // es gavxade public radgan program.cs-idan vegar vwvdebodi
        public int Count
        {
            get { return books.Count; }
        }
        public void PrintBook(string author)
        {
            foreach (var book in books)
            {
                if (book.Author == author)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
                }
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public bool RemoveBook(Book book)
        {
            return books.Remove(book);
        }
        public List<Book> FindBooks(string title)
        {
            return books.Where(book => book.Title == title).ToList();
        }
    }
}
