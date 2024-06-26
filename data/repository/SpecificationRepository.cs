using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;


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

        public List<Especificaciones> getSpecifications()
        {
            List<Especificaciones> SpecificationsList = _db.Especificaciones.ToList();
            return SpecificationsList;
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
