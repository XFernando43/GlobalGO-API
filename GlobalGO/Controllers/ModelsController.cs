using data.repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using service;

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

        [HttpPost("excel")]
        //public async Task<IActionResult> UploadByExcel([FromForm] IFormFile archivoExcel)
        public async Task UploadByExcel([FromForm] IFormFile archivoExcel)
        {
            try
            {
                await _service.SubmitDataByExcel(archivoExcel);
            }
            catch (Exception ex) { 
                throw new Exception("Algo ocurrio en el servidor");
            }
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
