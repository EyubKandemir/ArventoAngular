using ang.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookDataContext _context;

        public BookController(BookDataContext context)
        {
            _context= context;
        }

        [HttpGet("GetBooks")]
        public async Task<ActionResult<List<Books>>> GetBooks()
        {
            List<Books> aa = new List<Books>();
            aa = await _context.Books.ToListAsync();
            return Ok(aa);
        }


        [HttpPost("CreateBook")]
        public async Task<ActionResult<List<Books>>> CreateBook(Books book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Ok(_context.Books.ToListAsync());
        }

        [HttpPut("UpdateBook")]
        public async Task<ActionResult<List<Books>>> UpdateBook(Books book)
        {
            var dbBook = await _context.Books.FindAsync(book.objectid);
            if (dbBook == null)
                return BadRequest("Book not Found.");

            dbBook.book_name = book.book_name;
            dbBook.isbn_number = book.isbn_number;
            dbBook.author_id = book.author_id;
            await _context.SaveChangesAsync();
            return Ok(_context.Books.ToListAsync());
        }

        [HttpDelete("DeleteBook/{objectid}")]
        public async Task<ActionResult<List<Books>>> DeleteBook(int objectid)
        {
            var dbBook = await _context.Books.FindAsync(objectid);
            if (dbBook == null)
            {
                return BadRequest("Book not Found.");
            }

            _context.Books.Remove(dbBook);
            await _context.SaveChangesAsync();
            return Ok(_context.Books.ToListAsync());
        }
    }
}
