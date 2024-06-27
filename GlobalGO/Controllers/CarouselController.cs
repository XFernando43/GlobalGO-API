using data.repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using service;


namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarouselService _carouselService;
        public CarouselController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _carouselService = new CarouselService(unitOfWork);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var _carouseles = await _carouselService.getCarouseles();
                return Ok(new
                {
                    ok = true,
                    carouseles = _carouseles
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


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
