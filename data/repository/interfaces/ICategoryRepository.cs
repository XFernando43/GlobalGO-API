using GlobalGO.models;
using models.request;

namespace data.repository.interfaces
{
    public interface ICategoryRepository: IRepository<Categorias>
    {
        void AddCategory(CategoryRequest request);
        void Update(int id, CategoryRequest product);
        void Save();
        //List<Categorias> getCategories();
        Task<IEnumerable<Categorias>> getCategories();  
        void deleteCategory(int id);
    }
}
