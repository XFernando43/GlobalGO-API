

using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;
using models.request;

namespace data.repository
{
    public class ModelsRepository : Repository<Modelos>, IModelRepository
    {
        private readonly ApplicationDbContext _db;
        public ModelsRepository(ApplicationDbContext db) : base(db)
        { 
            _db = db;
        }

        public void AddModels(Modelos model)
        {
            _db.Modelos.Add(model);
        }

        public void deleteModel(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Modelos>> getModels()
        {
            return await _db.Modelos.ToListAsync();
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
