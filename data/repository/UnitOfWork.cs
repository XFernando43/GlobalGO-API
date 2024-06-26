using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;


namespace data.repository
{
    public class UnitOfWork: IUnitOfWork
    {
        ApplicationDbContext _db;
        //public ICategoryRepository categoryRepository { get; set; }
        public ICategoryRepository categoryRepository { get; set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            categoryRepository = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
