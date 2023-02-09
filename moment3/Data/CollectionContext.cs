using Microsoft.EntityFrameworkCore;
using moment3.Models; // Include model

namespace moment3.Data
{
    public class CollectionContext : DbContext // Inherit from class DbContext
    {
        // Contructor with settings. Save ArtistContext in variable options and send to base class
        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options) 
        { 
        }

        // Link Context to Collection model and add name to database tables
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}
