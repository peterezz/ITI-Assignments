using Microsoft.EntityFrameworkCore;

namespace Api_Day01.Models
{
    public class CrsDbContext : DbContext
    {
        public CrsDbContext( DbContextOptions<CrsDbContext> options ) : base( options )
        {

        }
        public DbSet<Course> Courses { get; set; }
        // public int id { get; set; }
    }
}
