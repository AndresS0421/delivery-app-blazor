using _3Parcial.Models;

namespace _3Parcial.Repositorio
{
    public interface IRepositorioVehicles
    {
        Task<List<Vehiculo>> GetAll();
        Task<Vehiculo?> Get(int id);
        Task<Vehiculo> Add(Vehiculo vehicle);
        Task Update(int id, Vehiculo vehicle);
        Task Delete(int id);
    }
}
