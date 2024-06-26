using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface IGaleryRepository: IRepository<Galerias>
    {
        void AddGalery();
        void Update();
        void Save();
        List<Galerias> getGaleries();
        void deleteGalery(int id);
    }
}
