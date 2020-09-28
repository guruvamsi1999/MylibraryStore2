using MylibraryStore2.Data;
using MylibraryStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MylibraryStore2.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _db = null;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Create(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        public void Delete(int? id)
        {
            var book = _db.Books.SingleOrDefault(m => m.id == id.Value);
            _db.Books.Remove(book);
            _db.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            return _db.Books.ToList().SingleOrDefault(x=>x.id==id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _db.Books.ToList();
        }

        public void Update(int? id, Book book)
        {
            var BookInDb = _db.Books.SingleOrDefault(m => m.id == id.Value);
            BookInDb.BookName = book.BookName;
            BookInDb.Author = book.Author;
            BookInDb.ISBN = book.ISBN;
            BookInDb.Genre = book.Genre;
            BookInDb.PublishedDate = book.PublishedDate;
            _db.SaveChanges();
        }
    }
}
