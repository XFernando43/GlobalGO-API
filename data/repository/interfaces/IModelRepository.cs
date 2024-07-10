using GlobalGO.models;
using models.request;


namespace data.repository.interfaces
{
    public partial interface IModelRepository : IRepository<Modelos>
    {
        void AddModels(Modelos model);
        void Update();
        void Save();
        Task<IEnumerable<Modelos>> getModels();
        void deleteModel(int id);
    }
}
