using _3Parcial.Models;

namespace _3Parcial.Repositorio
{
    public interface IRepositorioRoutes
    {
        Task<List<DeliveryRoute>> GetAll();
        Task<DeliveryRoute?> Get(int id);
        Task<DeliveryRoute> Add(DeliveryRoute route);
        Task Update(int id, DeliveryRoute route);
        Task Delete(int id);
    }
}
