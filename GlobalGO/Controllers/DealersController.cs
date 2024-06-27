using data.repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using service;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DealerService _dealerService;
        public DealersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dealerService = new DealerService(unitOfWork);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listDealers = await _dealerService.getDealers();
                return Ok(new
                {
                    Ok = true,
                    dealers = listDealers
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
