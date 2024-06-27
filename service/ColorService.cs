using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public class ColorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Colores>> getColores()
        {
            try
            {
                var colores = await _unitOfWork.colorsRepository.getColors();
                return colores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
