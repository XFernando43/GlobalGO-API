using models.models;

namespace GlobalGO.services
{
    public interface IMotorcycleRepository
    {
        Task<IEnumerable<Motorcycle>> GetMotorcycles(string sqlConexion);

        Task<Motorcycle> GetMotorcycle(string sqlConexion, int id);
    }
}
