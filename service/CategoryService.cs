using data.repository.interfaces;
using GlobalGO.models;

namespace service
{
    public class CategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Categorias>> getCategorias()
        {
            try
            {
                var categorias = await _unitOfWork.categoryRepository.getCategories();
                return categorias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
