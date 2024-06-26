using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository
{
    public partial class BrandRepository : Repository<Marcas>, IBrandRepository
    {
        private ApplicationDbContext _db { get; set; }
        public BrandRepository(ApplicationDbContext db): base(db) { 
            _db = db;
        }
        public void AddBrand()
        {
            throw new NotImplementedException();
        }

        public void deleteBrand(int id)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
        public List<Marcas> getBrands()
        {
            List<Marcas> brandsList = _db.Marcas.ToList();
            return brandsList;
        }
    }
}
