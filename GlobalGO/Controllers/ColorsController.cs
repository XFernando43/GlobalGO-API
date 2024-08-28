using GlobalGO.models;
using GlobalGO.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public readonly IColorRepository _colorRepository;
        public ColorsController(IConfiguration configuration, IColorRepository colorRepository)
        {
            this._configuration = configuration;
            this._colorRepository = colorRepository;
        }

        [HttpGet("getAll/{id}")]
        public async Task<IEnumerable<Colores>> GetBrands(int id)
        {
            try
            {
                var result = await _colorRepository.getModelColors(_configuration.GetConnectionString("DefaultConnection"), id);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
