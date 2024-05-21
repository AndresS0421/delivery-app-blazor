using _3Parcial.Models;

namespace _3Parcial.Repositorio
{
    public interface IRepositorioStops
    {
        Task<List<Stops>> GetAll();
        Task<Stops?> Get(int id);
        Task<Stops> Add(Stops stop);
        Task Update(int id, Stops stop);
        Task Delete(int id);
    }
}
