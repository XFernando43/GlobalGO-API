using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GaleryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet]
        async public Task<IActionResult> GetAll()
        {
            try
            {
                var listGalerys = _unitOfWork.galeryRepository.GetGalerias();
                return Ok(new
                {
                    Ok = true,
                    brands = listGalerys
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

        // GET api/<GaleryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GaleryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GaleryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GaleryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
