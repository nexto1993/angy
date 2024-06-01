using FlightAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books =
        [
            new Book { Id = 1, Name = "Book1", AuthorName = "Author1" },
            new Book { Id = 2, Name = "Book2", AuthorName = "Author2" },
            new Book { Id = 3, Name = "Book3", AuthorName = "Author3" }
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
