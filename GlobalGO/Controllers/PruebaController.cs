using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalGO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PruebaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("getCateriass")]
        public async Task<IActionResult> getCategories()
        {
            try
            {
                List<Categorias> listCategorias = _unitOfWork.categoryRepository.getCategories();
                return Ok(listCategorias);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

    }
}
