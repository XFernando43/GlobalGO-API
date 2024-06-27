using data.repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using service;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly BrandService _brandService;
        public BrandController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _brandService = new BrandService(_unitOfWork);
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> getBrands()
        {
            try
            {
                var listBrands = await _brandService.getMarcas();
                return Ok(new
                {
                    Ok = true,
                    brands = listBrands
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
