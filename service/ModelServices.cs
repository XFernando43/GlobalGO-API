using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public partial class ModelServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModelServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Modelos>> getModelos()
        {
            try
            {
                var modelos = await _unitOfWork.modelRepository.getModels();
                return modelos;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        
    }
}
