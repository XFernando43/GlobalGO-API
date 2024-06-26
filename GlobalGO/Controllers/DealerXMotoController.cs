using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerXMotoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DealerXMotoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        async public Task<IActionResult> Get()
        {
            try
            {
                List<DistribuidorMotos> listDealersXMoto = _unitOfWork.dealersXModelRepository.getDealersXMoto();
                return Ok(new
                {
                    Ok = true,
                    brands = listDealersXMoto
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
