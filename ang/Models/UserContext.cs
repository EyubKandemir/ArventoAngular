using Microsoft.EntityFrameworkCore;

namespace ang.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) 
        { 
        
        }   
        
        public DbSet<Login> SystemUser { get; set; }


    }
}
