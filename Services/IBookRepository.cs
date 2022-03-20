using BookApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApi.Services
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> AddBook(Book book);
        public Task UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}
