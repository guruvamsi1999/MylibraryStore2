using MylibraryStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MylibraryStore2.Repository
{
     public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);

        void Create(Book book);
        void Update(int? id, Book book);
        void Delete(int? id);

    }
}
