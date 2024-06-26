using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface IDealersXModelRepository: IRepository<DistribuidorMotos>
    {
        void AddDealerXMoto();
        void Update();
        void Save();
        List<DistribuidorMotos> getDealersXMoto();
        void deleteDealerXMoto(int id);
    }
}
