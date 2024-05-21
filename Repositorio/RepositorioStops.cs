using _3Parcial.Models;
using Microsoft.EntityFrameworkCore;

namespace _3Parcial.Repositorio
{
    public class RepositorioStops : IRepositorioStops
    {
        private readonly CatalogoDBContext _context;

        public RepositorioStops(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<List<Stops>> GetAll()
        {
            return await _context.Stops.ToListAsync();
        }

        public async Task<Stops> Add(Stops stop)
        {
            stop.CreatedAt = DateTime.Now;
            stop.UpdatedAt = DateTime.Now;
            await _context.Stops.AddAsync(stop);
            await _context.SaveChangesAsync();
            return stop;
        }

        public async Task Delete(int id)
        {
            var stop = await _context.Stops.FindAsync(id);
            if (stop != null)
            {
                _context.Stops.Remove(stop);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Stops> Get(int id)
        {
            return await _context.Stops.FindAsync(id);
        }

        public async Task Update(int id, Stops stop)
        {
            var stop_actual = await _context.Stops.FindAsync(id);
            if (stop_actual != null)
            {
                stop_actual.Location = stop.Location;
                stop_actual.Routes = stop.Routes;
                stop_actual.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
