using Dapper;
using GlobalGO.models;
using GlobalGO.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IBrandRepository _brandRepository;

        public BrandController(IConfiguration configuration, IBrandRepository brandRepository)
        {
            _configuration = configuration;
            _brandRepository = brandRepository;
        }


        [HttpGet("getAll")]
        public async Task<IEnumerable<Marcas>> GetBrands()
        {
            try
            {
                var result = await _brandRepository.GetBrands(_configuration.GetConnectionString("DefaultConnection"));
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
