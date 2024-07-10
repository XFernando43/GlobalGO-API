using data.repository.interfaces;
using GlobalGO.data;
using Microsoft.EntityFrameworkCore;
using models.models;

namespace data.repository
{
    public class MotorcycleRepository : Repository<Motorcycle>, IMotorcycleRepository
    {
        private readonly ApplicationDbContext _db;
        public MotorcycleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Motorcycle>> GetMotorcycles()
        {
            var query = @"SELECT* FROM Modelos";

            return await _db.Set<Motorcycle>().FromSqlRaw(query).ToListAsync();
        }
    }
}
