using GlobalGO.models;


namespace data.repository.interfaces
{
    public partial interface IModelRepository : IRepository<Modelos>
    {
        void AddModels();
        void Update();
        void Save();
        Task<IEnumerable<Modelos>> getModels();
        void deleteModel(int id);
    }
}
