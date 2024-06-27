using data.repository;
using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public class CarouselService
    {
        private readonly IUnitOfWork _uniOfWork;
        public CarouselService(IUnitOfWork uow)
        {
            _uniOfWork = uow;
        }
        public async Task<IEnumerable<Carruseles>> getCarouseles()
        {
            try
            {
                var carouseles = await _uniOfWork.carouselRepository.GetCarruseles();
                return carouseles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Carruseles>(); // Devolver una lista vacía en lugar de null
            }
        }
    }
}
