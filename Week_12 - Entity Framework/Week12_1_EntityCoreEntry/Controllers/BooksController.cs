using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week12_1_EntityCoreEntry.Data;
using Week12_1_EntityCoreEntry.Data.Entity;

namespace Week12_1_EntityCoreEntry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BooksController(LibraryContext context)
        {
            _context = context;
        }


        [HttpPost]
        public ActionResult<Book> Post([FromBody] Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return Ok(book);
        }


        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] Book book)
        {
            var current = _context.Books.FirstOrDefault(book => book.Id == id);

            if (current == null)
            {
                return NotFound();
            }

            current.Title = book.Title;
            current.Price = book.Price;
            current.LastBarrowedDate = book.LastBarrowedDate;
            current.CategoryId = book.CategoryId;

            _context.SaveChanges();

            return NoContent();
        }


        [HttpGet]
        public ActionResult<Book> GetAll()
        {
            // LINQ
            var recentBooks = _context.Books
                .Where(x => x.PublicationYear > 2020)
                .OrderBy(x => x.PublicationYear)
                .Take(10)
                .ToList();

            // Raw SQL
            //var books = _context.Books.FromSqlRaw("SELECT * FROM Books WHERE PublicationYear > {0}", 2020);

            return Ok(recentBooks);
        }


        [HttpDelete("{id:int:min(1)}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return NotFound();  
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
