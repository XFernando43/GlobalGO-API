using GlobalGO.models;
using GlobalGO.services;
using Microsoft.AspNetCore.Mvc;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarruselController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ICarruselRepository _carruselRepository;

        public CarruselController(IConfiguration configuration, ICarruselRepository carruselRepository)
        {
            _configuration = configuration;
            _carruselRepository = carruselRepository;
        }

        [HttpGet("getCarrusel/{id}")]
        public async Task<IEnumerable<Carruseles>> getCarrusel(int id)
        {
            try
            {
                var result = await _carruselRepository.GetCarruselsByID(_configuration.GetConnectionString("DefaultConnection"), id);
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
