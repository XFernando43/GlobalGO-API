

using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;

namespace data.repository
{
    public class ModelsRepository : Repository<Modelos>, IModelRepository
    {
        private readonly ApplicationDbContext _db;
        public ModelsRepository(ApplicationDbContext db) : base(db)
        { 
            _db = db;
        }

        public void AddModels()
        {
            throw new NotImplementedException();
        }

        public void deleteModel(int id)
        {
            throw new NotImplementedException();
        }

        public List<Modelos> getModels()
        {
            List<Modelos> ListModels = _db.Modelos.ToList();
            return ListModels;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
