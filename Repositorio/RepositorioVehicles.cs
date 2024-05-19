using _3Parcial.Models;
using Microsoft.EntityFrameworkCore;

namespace _3Parcial.Repositorio
{
    public class RepositorioVehicles : IRepositorioVehicles
    {
        private readonly CatalogoDBContext _context;

        public RepositorioVehicles(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<List<Vehiculo>> GetAll()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<Vehiculo> Add(Vehiculo vehicle)
        {
            vehicle.CreatedAt = DateTime.Now;
            vehicle.UpdatedAt = DateTime.Now;
            await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task Delete(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Vehiculo> Get(int id)
        {
            return await _context.Vehicles.FindAsync(id);
        }

        public async Task Update(int id, Vehiculo vehicle)
        {
            var vehicle_actual = await _context.Vehicles.FindAsync(id);
            if (vehicle_actual != null)
            {
                vehicle_actual.Model = vehicle.Model;
                vehicle_actual.Brand = vehicle.Brand;
                vehicle_actual.Year = vehicle.Year;
                vehicle_actual.Color = vehicle.Color;
                vehicle_actual.Status = vehicle.Status;
                vehicle_actual.Type = vehicle.Type;
                vehicle_actual.Kilometrage = vehicle.Kilometrage;
                vehicle_actual.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
