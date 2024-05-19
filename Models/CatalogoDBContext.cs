using Microsoft.EntityFrameworkCore;

namespace _3Parcial.Models
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options):base(options)
        {
        }
        public DbSet<Vehiculo> Vehicles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<DeliveryRoute> Routes { get; set; }
    }
}
