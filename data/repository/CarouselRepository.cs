using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace data.repository
{
    public class CarouselRepository : Repository<Carruseles>, ICarouselRepository
    {
        private ApplicationDbContext _db { get; set; }
        public CarouselRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void addCarrousel()
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void deleteCarousel(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Carruseles>> GetCarruseles()
        {
            return await _db.Carruseles.ToListAsync();
        }
    }
}
