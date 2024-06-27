using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GaleryService _galeryService;
        public GaleryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _galeryService = new GaleryService(unitOfWork);
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var listGalerys = await _galeryService.getGaleries();
                return Ok(new
                {
                    Ok = true,
                    galerys = listGalerys
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
