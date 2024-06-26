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

        public List<Distribuidores> GetAll()
        {
            List<Distribuidores> dealersList = _db.Distribuidores.ToList();
            return dealersList;
        }

        public List<Distribuidores> GetDealers()
        {
            List<Distribuidores> dealersList = _db.Distribuidores.ToList();
            return dealersList;
        }

        public void save()
        {
            throw new NotImplementedException();
        }

        public void update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
