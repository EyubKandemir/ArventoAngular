using Microsoft.EntityFrameworkCore;

namespace ang.Models
{
    public class DashboardDataContext : DbContext
    {
        public DashboardDataContext(DbContextOptions<DashboardDataContext> options) : base(options) { }

    }
}
