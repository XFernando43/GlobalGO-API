using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;
using models.request;

namespace data.repository
{
    public class CategoryRepository : Repository<Categorias>, ICategoryRepository
    {
        private ApplicationDbContext _db {  get; set; }
        public CategoryRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }
        public void AddCategory(CategoryRequest request)
        {
            
        }

        public void deleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public async void Update(int id, CategoryRequest product)
        {
            throw new NotImplementedException();
        
        }

        public async Task<IEnumerable<Categorias>> getCategories()
        {
            return await _db.Categorias.ToListAsync();
        }
    }
}
