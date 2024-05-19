using _3Parcial.Models;
using Microsoft.EntityFrameworkCore;

namespace _3Parcial.Repositorio
{
    public class RepositorioRoutes : IRepositorioRoutes
    {
        private readonly CatalogoDBContext _context;

        public RepositorioRoutes(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<List<DeliveryRoute>> GetAll()
        {
            return await _context.Routes.ToListAsync();
        }

        public async Task<DeliveryRoute> Add(DeliveryRoute route)
        {
            route.CreatedAt = DateTime.Now;
            route.UpdatedAt = DateTime.Now;
            await _context.Routes.AddAsync(route);
            await _context.SaveChangesAsync();
            return route;
        }

        public async Task Delete(int id)
        {
            var route = await _context.Routes.FindAsync(id);
            if (route != null)
            {
                _context.Routes.Remove(route);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DeliveryRoute> Get(int id)
        {
            return await _context.Routes.FindAsync(id);
        }

        public async Task Update(int id, DeliveryRoute route)
        {
            var route_actual = await _context.Routes.FindAsync(id);
            if (route_actual != null)
            {
                route_actual.Origin = route.Origin;
                route_actual.Destination = route.Destination;
                route_actual.Distance = route.Distance;
                route_actual.EstimatedDuration = route.EstimatedDuration;
                route_actual.StartAt = route.StartAt;
                route_actual.EndAt = route.EndAt;
                route_actual.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
