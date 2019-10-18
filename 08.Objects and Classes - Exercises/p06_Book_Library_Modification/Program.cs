using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p05_Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author,
            string publisher, DateTime releaseDate,
            string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void addBook(Book book)
        {
            Books.Add(book);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int bookCount = int.Parse(Console.ReadLine());
            Library library = new Library("Sunglasie");

            while (bookCount-- > 0)
            {
                string[] bookInfo = Console.ReadLine().Split(' ');
                string title = bookInfo[0];
                string author = bookInfo[1];
                string publisher = bookInfo[2];
                DateTime releaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy",
                    CultureInfo.InstalledUICulture);
                string isbn = bookInfo[4];
                decimal price = decimal.Parse(bookInfo[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);
                library.addBook(book);
            }
            DateTime dateForCheck = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);

            library.Books.Where(d => d.ReleaseDate > dateForCheck)
                .OrderBy(d => d.ReleaseDate)
                .ThenBy(t => t.Title).ToList().ForEach(b =>
            {
                Console.WriteLine($"{b.Title} -> {b.ReleaseDate:dd.MM.yyyy}");
            });
        }
    }
}
