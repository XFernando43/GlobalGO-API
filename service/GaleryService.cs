using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public class GaleryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GaleryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Galerias>> getGaleries()
        {
            try
            {
                var galerias = await _unitOfWork.galeryRepository.GetGalerias();
                return galerias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
