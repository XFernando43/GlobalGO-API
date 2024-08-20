using GlobalGO.models;

namespace GlobalGO.services
{
    public interface ICarruselRepository
    {
        Task<IEnumerable<Carruseles>> GetCarruselsByID(string sqlconnection, int idModelo);
    }
}
