using Microsoft.EntityFrameworkCore;

namespace ang.Models
{
    public class BookDataContext : DbContext
    {
        public BookDataContext(DbContextOptions<BookDataContext> options) : base(options) { }

        public DbSet<Books> Books => Set<Books>();
    }
}
