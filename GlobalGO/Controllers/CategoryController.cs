using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using service;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CategoryService _categoryService;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _categoryService = new CategoryService(unitOfWork);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getCategories()
        {
            try
            {
                var listCategorias = _unitOfWork.categoryRepository.getCategories();
                return Ok(new
                {
                    Ok = true,
                    categorias = listCategorias
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    ok = false,
                    message = "Se produjo un error interno del servidor.",
                    error = ex.Message
                });
            }
        }

    }
}
