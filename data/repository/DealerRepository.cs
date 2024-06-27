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
    public class DealerRepository : Repository<Distribuidores>, IDealersRepository
    {
        private ApplicationDbContext _db { get; set; }
        public DealerRepository(ApplicationDbContext db): base(db) {
            _db = db;
        }
        public void AddDealers()
        {
            throw new NotImplementedException();
        }

        public void deleteDealer(int id)
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }

        public void update(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Distribuidores>> GetDealers()
        {
            return await _db.Distribuidores.ToListAsync();
        }
    }
}
