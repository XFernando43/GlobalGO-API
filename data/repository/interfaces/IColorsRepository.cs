

using GlobalGO.models;

namespace data.repository.interfaces
{
    public interface IColorsRepository: IRepository<Colores>
    {
        void AddColor();
        void Update();
        void Save();
        //List<Colores> getColors();
        Task<IEnumerable<Colores>> getColors();
        void deleteColor(int id);
    }
}
