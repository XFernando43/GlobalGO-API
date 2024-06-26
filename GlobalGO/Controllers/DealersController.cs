using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DealersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        async public Task<IActionResult> Get(){
            try
            {
                List<Distribuidores> listDealers = _unitOfWork.dealersRepository.GetDealers();
                return Ok(new
                {
                    Ok = true,
                    brands = listDealers
                });
            }
            catch (Exception ex) {
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
