using GlobalGO.models;
using GlobalGO.services;
using Microsoft.AspNetCore.Mvc;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(IConfiguration configuration, ICategoryRepository categoryRepository)
        {
            _configuration = configuration;
            _categoryRepository = categoryRepository;
        }

        [HttpGet("getAll")]
        public async Task<IEnumerable<Categorias>> getCategories()
        {
            try
            {
                var result = await _categoryRepository.GetCategories(_configuration.GetConnectionString("DefaultConnection"));
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
