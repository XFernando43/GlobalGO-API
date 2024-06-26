using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;

namespace GlobalGO.Controllers
{
    public class BrandController : Controller
    {
       private readonly IUnitOfWork _unitOfWork;
        public BrandController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("Brands")]
        public async Task<IActionResult> getBrands()
        {
            try
            {
                List<Marcas> listBrands = _unitOfWork.brandRepository.getBrands();
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
                    ok=false,
                    message=ex.Message
                });
            }
        }
    }
}
