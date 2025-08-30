using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Join_Pratik
{
    public class Author
    {
        public int AuthorId { get; set; }
        public required string Name { get; set; } 
    }

    public class Book
    {
        public int BookId { get; set; }
        public required string Title { get; set; }
        public int AuthorId { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            var authors = new List<Author>
            {
                new() { AuthorId = 1, Name = "Orhan Pamuk" },
                new() { AuthorId = 2, Name = "Yaşar Kemal" },
                new() { AuthorId = 3, Name = "Elif Şafak" }
            };

            var books = new List<Book>
            {
                new() { BookId = 1, Title = "Kar", AuthorId = 1 },
                new() { BookId = 2, Title = "Benim Adım Kırmızı", AuthorId = 1 },
                new() { BookId = 3, Title = "İnce Memed", AuthorId = 2 },
                new() { BookId = 4, Title = "Aşk", AuthorId = 3 }
            };

            var query =
                from book in books
                join author in authors on book.AuthorId equals author.AuthorId
                select new { BookTitle = book.Title, AuthorName = author.Name };

            foreach (var item in query)
                Console.WriteLine($"Kitap: {item.BookTitle} - Yazar: {item.AuthorName}");
        }
    }
}
