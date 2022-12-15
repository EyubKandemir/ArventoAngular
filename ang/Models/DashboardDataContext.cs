using Microsoft.EntityFrameworkCore;

namespace ang.Models
{
    public class DashboardDataContext : DbContext
    {
        public DashboardDataContext(DbContextOptions<DashboardDataContext> options) : base(options) { }

        public int TotalBooks { get; set; }
        public int TotalAuthors { get; set; }

    }
}
