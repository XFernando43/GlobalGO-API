using GlobalGO.services;
using Microsoft.AspNetCore.Mvc;
using models.models;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IMotorcycleRepository _motorcycleRepository;

        public MotorcycleController(IConfiguration configuration, IMotorcycleRepository motorcycleRepo)
        {
            _configuration = configuration;
            _motorcycleRepository = motorcycleRepo;
        }

        [HttpGet("getMotorcycles")]
        public async Task<IEnumerable<Motorcycle>> GetMotorcycles()
        {
            try
            {
                var result = await _motorcycleRepository.GetMotorcycles(_configuration.GetConnectionString("DefaultConnection"));
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet("getMotorcycleByID/{id}")]
        public async Task<Motorcycle> GetMotorcycleByID(int id)
        {
            try
            {
                var result = await _motorcycleRepository.GetMotorcycle(_configuration.GetConnectionString("DefaultConnection"), id);
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
