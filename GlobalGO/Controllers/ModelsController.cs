using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _db;
        private readonly ModelServices _service;
        public ModelsController(IUnitOfWork db)
        {
            _db = db;
            _service = new ModelServices(_db);
        }

        [HttpGet]
        public async Task<IActionResult> getModels()
        {
            try
            {
                var modelos = await _service.getModelos();
                return Ok(new
                {
                    ok = true,
                    Modelos = modelos,
                });
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: aquí puedes registrar el error o tomar alguna acción adicional.
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
