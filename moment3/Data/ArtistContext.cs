using Microsoft.EntityFrameworkCore;
using moment3.Models; // Include model

namespace moment3.Data
{
    public class ArtistContext : DbContext // Inherit from class DbContext
    {
        // Contructor with settings. Save ArtistContext in variable options and send to base class
        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options) 
        { 
        }

        // Link Context to Artist model and add name to database table
        public DbSet<Artist> Artist { get; set; }
    }
}
