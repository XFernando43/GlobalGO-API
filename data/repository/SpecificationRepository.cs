using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;

namespace data.repository
{
    public class SpecificationRepository : Repository<Especificaciones>, ISpecificationRepository
    {
        private readonly ApplicationDbContext _db;
        public SpecificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void AddSpecification()
        {
            throw new NotImplementedException();
        }

        public void deleteSpecifications(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Especificaciones>> getSpecifications()
        {
            return await _db.Especificaciones.ToListAsync();
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
