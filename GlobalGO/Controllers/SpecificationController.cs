using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecificationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SpecificationsService _specificationsService;
        public SpecificationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _specificationsService = new SpecificationsService(unitOfWork);
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var listSpecifications = await _specificationsService.getSpecifications();
                return Ok(new
                {
                    Ok = true,
                    specifications = listSpecifications
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

        //// GET api/<SpecificationController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<SpecificationController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<SpecificationController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SpecificationController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
