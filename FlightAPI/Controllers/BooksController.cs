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
            new Book { Id = 1, Title = "Book1", Author = "Author1" },
            new Book { Id = 2, Title = "Book2", Author = "Author2" },
            new Book { Id = 3, Title = "Book3", Author = "Author3" }
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
