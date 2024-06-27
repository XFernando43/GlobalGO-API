using GlobalGO.models;
using models.request;

namespace data.repository.interfaces
{
    public partial interface IBrandRepository : IRepository<Marcas>
    {
        void AddBrand();
        void Update();
        void Save();
        //List<Marcas> getBrands();
        Task<IEnumerable<Marcas>> getBrands();
        void deleteBrand(int id);
    }
}
