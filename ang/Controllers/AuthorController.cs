using ang.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorDataContext _context;

        public AuthorController(AuthorDataContext context)
        {
            _context = context;

        }

        [HttpGet("GetAuthors")]
        public async Task<ActionResult<List<Author>>> GetAuthors()
        {
            List < Author > aa = new List < Author >();
            aa = await _context.Author.ToListAsync();
            return Ok(aa);
        }


        [HttpPost("CreateAuthor")]
        public async Task<ActionResult<List<Author>>> CreateAuthor(Author author)
        {
            _context.Author.Add(author);
            await _context.SaveChangesAsync();
            return Ok(_context.Author.ToListAsync());
        }

        [HttpPut("UpdateAuthor")]
        public async Task<ActionResult<List<Author>>> UpdateAuthor(Author author)
        {
            var dbAuthor = await _context.Author.FindAsync(author.objectid);
            if (dbAuthor == null)
               return BadRequest("Author not Found.");
            

            dbAuthor.author_name = author.author_name;
            dbAuthor.author_surname = author.author_surname;
            await _context.SaveChangesAsync();
            return Ok(_context.Author.ToListAsync());
        }

        [HttpDelete("DeleteAuthor/{objectid}")]
        public async Task<ActionResult<List<Author>>> DeleteAuthor(int objectid)
        {
            var dbAuthor = await _context.Author.FindAsync(objectid);
            if (dbAuthor == null)
            {
                return BadRequest("Author not Found.");
            }

            _context.Author.Remove(dbAuthor);
            await _context.SaveChangesAsync();
            return Ok(_context.Author.ToListAsync());
        }
    }
}
