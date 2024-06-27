using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerXMotoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DealersxMotoService _dealersxMotoService;
        public DealerXMotoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dealersxMotoService = new DealersxMotoService(unitOfWork);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listDealersXMoto = await _dealersxMotoService.getDealersXMotos();
                return Ok(new
                {
                    Ok = true,
                    dealersXmoto = listDealersXMoto
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

        // POST api/<DealerXMotoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DealerXMotoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DealerXMotoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
