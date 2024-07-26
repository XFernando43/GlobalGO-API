using GlobalGO.models;

namespace GlobalGO.services
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Categorias>> GetCategories(string sqlconexion);

    }
}
