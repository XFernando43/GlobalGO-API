using models.models;

namespace data.repository.interfaces
{
    public interface IMotorcycleRepository: IRepository<Motorcycle>
    {
        Task<IEnumerable<Motorcycle>> GetMotorcycles();
    }
}
