using BookApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApi.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context )
        {
            _context = context;
        }

        public async Task<Book> AddBook(Book book)
        {
           _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book;

        }

        public async Task DeleteBook(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task UpdateBook(Book book)
        {
           _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        void IBookRepository.DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
