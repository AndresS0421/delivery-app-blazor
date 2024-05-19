using _3Parcial.Models;
using Microsoft.EntityFrameworkCore;

namespace _3Parcial.Repositorio
{
    public class RepositorioLocations : IRepositorioLocations
    {
        private readonly CatalogoDBContext _context;

        public RepositorioLocations(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<List<Location>> GetAll()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Location> Add(Location location)
        {
            location.CreatedAt = DateTime.Now;
            location.UpdatedAt = DateTime.Now;
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
            return location;
        }

        public async Task Delete(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location != null)
            {
                _context.Locations.Remove(location);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Location> Get(int id)
        {
            return await _context.Locations.FindAsync(id);
        }

        public async Task Update(int id, Location location)
        {
            var location_actual = await _context.Locations.FindAsync(id);
            if (location_actual != null)
            {
                location_actual.Street = location.Street;
                location_actual.ExtNumber = location.ExtNumber;
                location_actual.IntNumber = location.IntNumber;
                location_actual.City = location.City;
                location_actual.ZipCode = location.ZipCode;
                location_actual.City = location.City;
                location_actual.State = location.State;
                location_actual.Country = location.Country;
                location_actual.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
