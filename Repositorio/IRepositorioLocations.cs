using _3Parcial.Models;

namespace _3Parcial.Repositorio
{
    public interface IRepositorioLocations
    {
        Task<List<Location>> GetAll();
        Task<Location?> Get(int id);
        Task<Location> Add(Location location);
        Task Update(int id, Location location);
        Task Delete(int id);
    }
}
