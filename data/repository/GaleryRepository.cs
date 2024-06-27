using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;

namespace data.repository
{
    public class GaleryRepository : Repository<Galerias>, IGaleryRepository
    {
        private readonly ApplicationDbContext _db;
        public GaleryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void AddGalery()
        {
            throw new NotImplementedException();
        }

        public void deleteGalery(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Galerias>> GetGalerias()
        {
            return await _db.Galerias.ToListAsync();
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
