using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Marcas>> getBrands()
        {
            return await _db.Marcas.ToListAsync();
        }
    }
}
