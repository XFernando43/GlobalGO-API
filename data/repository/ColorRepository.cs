using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;

namespace data.repository
{
    public class ColorRepository : Repository<Colores>, IColorsRepository
    {
        private readonly ApplicationDbContext _db;
        public ColorRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void AddColor()
        {
            throw new NotImplementedException();
        }

        public void deleteColor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Colores>> getColors()
        {
            return await _db.Colores.ToListAsync();
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
