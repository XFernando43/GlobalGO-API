using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    internal class ModelsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModelsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Modelos>> getModels()
        {
            try
            {
                var models = await _unitOfWork.modelRepository.getModels();
                return models;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
