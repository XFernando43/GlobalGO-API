using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
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

        public void Update(int id, CategoryRequest product)
        {
            throw new NotImplementedException();
        }

        public List<Categorias> getCategories()
        {
            List<Categorias> objList = _db.Categorias.ToList();
            return objList;
        }
    }
}
