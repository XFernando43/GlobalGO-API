using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public class DealersxMotoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DealersxMotoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DistribuidorMotos>> getDealersXMotos()
        {
            try
            {
                var dealersXMoto = await _unitOfWork.dealersXModelRepository.getAllDealersXMoto();
                return dealersXMoto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
