using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace bookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);
                books.Add(book);
            }

            DateTime filterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            List<Book> filterBooks = books
                .Where(b => b.ReleaseDate > filterDate)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title)
                .ToList();

            foreach (var book in filterBooks)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }
    }
}
