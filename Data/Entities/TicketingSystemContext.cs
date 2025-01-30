using Microsoft.EntityFrameworkCore;

namespace Data.Entities
{
    public class TicketingSystemContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
