
using GlobalGO.models;

namespace GlobalGO.services
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Marcas>> GetBrands(string sqlconnection);
    }
}
