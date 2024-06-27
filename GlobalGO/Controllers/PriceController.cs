using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using service;


namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PriceService _priceService;
        public PriceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _priceService = new PriceService(unitOfWork);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listBrands = await _priceService.getPrecios();
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

        // GET api/<PriceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PriceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PriceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PriceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
