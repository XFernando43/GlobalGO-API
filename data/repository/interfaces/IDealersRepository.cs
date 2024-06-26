using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface IDealersRepository: IRepository<Distribuidores>
    {
        void AddDealers();
        void update(int id);
        void save();
        List<Distribuidores> GetAll();
        List<Distribuidores> GetDealers();
        void deleteDealer(int id); 
    }
}
