using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CarouselController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        async public Task<IActionResult> GetAll()
        {
            try
            {
                var listCarusels = _unitOfWork.carouselRepository.GetCarruseles();
                return Ok(new
                {
                    Ok = true,
                        brands = listCarusels
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

        // GET api/<CarouselController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarouselController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarouselController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarouselController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
