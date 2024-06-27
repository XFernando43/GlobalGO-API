using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public partial interface IModelRepository: IRepository<Modelos>
    {
        void AddModels();
        void Update();
        void Save();
        Task<IEnumerable<Modelos>> getModels();
        void deleteModel(int id);
    }
}
