using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;

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

        public List<Colores> getColors()
        {
            List<Colores> ListColors = _db.Colores.ToList();
            return ListColors;
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
