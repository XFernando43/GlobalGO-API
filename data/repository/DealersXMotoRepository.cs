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
    internal class DealersXMotoRepository : Repository<DistribuidorMotos>, IDealersXModelRepository
    {
        private readonly ApplicationDbContext _db;
        public DealersXMotoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void AddDealerXMoto()
        {
            throw new NotImplementedException();
        }

        public void deleteDealerXMoto(int id)
        {
            throw new NotImplementedException();
        }

        public List<DistribuidorMotos> getDealersXMoto()
        {
            List<DistribuidorMotos> listDealersXMoto = _db.DistribuidoresMotos.ToList();
            return listDealersXMoto;
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
