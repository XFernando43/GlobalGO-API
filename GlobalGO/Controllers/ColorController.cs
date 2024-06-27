using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        async public Task<IActionResult> Get()
        {
            try
            {
                var listColors = _unitOfWork.colorsRepository.getColors();
                return Ok(new
                {
                    Ok = true,
                    brands = listColors
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

        // GET api/<ColorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ColorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ColorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ColorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
