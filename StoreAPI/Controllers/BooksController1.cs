using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using BookStore.Data.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController1 : ControllerBase
    {
        private IBookRepository books = new BookRepository();
        
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

    }
}
