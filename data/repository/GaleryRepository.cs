using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;

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

        public List<Galerias> getGaleries()
        {
            List<Galerias> ListGalerias = _db.Galerias.ToList();
            return ListGalerias;
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
