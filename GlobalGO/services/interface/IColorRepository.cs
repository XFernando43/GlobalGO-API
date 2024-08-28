using GlobalGO.models;

namespace GlobalGO.services
{
    public interface IColorRepository
    {
        Task<IEnumerable<Colores>> getModelColors(string conexion, int id);
    }
}
