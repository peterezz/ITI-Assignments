using HotelManagment_Day11.Configrations;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HotelManagment_Day11.Models
{
    public class HotelManagmentContext : DbContext
    {
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        => optionsBuilder.UseSqlServer( ConfigurationManager.ConnectionStrings[ "DefaultConnection" ].ConnectionString );

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfigurationsFromAssembly( typeof( UserEntityTypeConfigration ).Assembly );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Reserver> Reservers { get; set; }
        public DbSet<ResrverGender> ResrverGenders { get; set; }
        public DbSet<ReserverState> ReserverStates { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Reserver_Service> Reservers_Services { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
