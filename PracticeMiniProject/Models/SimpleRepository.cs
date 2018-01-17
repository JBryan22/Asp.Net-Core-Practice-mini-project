using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMiniProject.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialBooks = new[]
            {
                new Book { ID = 1, Title = "Pro Asp.NET Core MVC 2", Author = "Adam Freeman", Price = 40M },
                new Book { ID = 2, Title = "The Left Hand of Darkness", Author = "Ursula K. Le Guin", Price = 10M },
                new Book { ID = 3, Title = "Death Troopers", Author = "Joe Schreiber", Price = 9.5M },
                new Book { ID = 4, Title = "Ancillary Sword", Author = "Ann Leckie", Price = 12.99M }
            };

            foreach(Book b in initialBooks)
            {
                books.Add(b.Title, b);
            }
        }

        public IEnumerable<Book> Books => books.Values;

        public void AddBook(Book b) => books.Add(b.Title, b);
    }
}
