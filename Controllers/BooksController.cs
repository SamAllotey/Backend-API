using BookApi.Models;
using BookApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepository.GetBooks();
        }

        [HttpGet("{id}", Name = "GetBook")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            return await _bookRepository.GetBookById(id);
        }

        [HttpPost]

        [HttpPut]

        [HttpDelete("{id}")]
        public ActionResult<Book> DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
            return Ok();
        }
    }
}
