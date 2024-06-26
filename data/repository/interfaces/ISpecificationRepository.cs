using GlobalGO.models;


namespace data.repository.interfaces
{
    public interface ISpecificationRepository: IRepository<Especificaciones>
    {
        void AddSpecification();
        void Update();
        void Save();
        List<Especificaciones> getSpecifications();
        void deleteSpecifications(int id);
    }
}
