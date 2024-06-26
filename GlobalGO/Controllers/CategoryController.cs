using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GlobalGO.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork) { 
            _unitOfWork = unitOfWork;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getCategories()
        {
            try
            {
                List<Categorias> listCategorias = _unitOfWork.categoryRepository.getCategories();
                return Ok(new
                {
                    Ok = true,
                    categorias = listCategorias
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(new
                {
                    ok = false,
                    message=ex.Message
                });
            }
        }

    }
}
