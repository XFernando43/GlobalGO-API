using data.repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using service;

namespace GlobalGO.Controllers
{
    public class BrandController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly BrandService _brandService;
        public BrandController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _brandService = new BrandService(_unitOfWork);
        }


        [HttpGet("Brands")]
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
                Console.WriteLine(ex.Message);
                return BadRequest(new
                {
                    ok = false,
                    message = ex.Message
                });
            }
        }
    }
}
