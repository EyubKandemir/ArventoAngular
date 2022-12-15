using Microsoft.EntityFrameworkCore;

namespace ang.Models
{
    public class AuthorDataContext : DbContext
    {
        public AuthorDataContext(DbContextOptions<AuthorDataContext> options) : base(options) { }

        public DbSet<Author> Author => Set<Author>();

    }
}
