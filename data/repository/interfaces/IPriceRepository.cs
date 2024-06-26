using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface IPriceRepository : IRepository<Precios>
    {
        void AddPrice();
        void Update();
        void Save();
        List<Precios> getPrices();
        void deletePrices(int id);
    }

}
