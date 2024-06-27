using GlobalGO.models;


namespace data.repository.interfaces
{
    public interface ISpecificationRepository: IRepository<Especificaciones>
    {
        void AddSpecification();
        void Update();
        void Save();
        Task<IEnumerable<Especificaciones>> getSpecifications();
        void deleteSpecifications(int id);
    }
}
