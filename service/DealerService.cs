using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public class DealerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DealerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Distribuidores>> getDealers()
        {
            try
            {
                var distribuidores = await _unitOfWork.dealersRepository.GetDealers();
                return distribuidores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
