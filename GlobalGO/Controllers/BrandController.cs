using Dapper;
using GlobalGO.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IConfiguration _configuration;

        public BrandController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet("getAll")]
        public async Task<IEnumerable<Marcas>> getBrands()
        {
            try
            {
                var query = @"SELECT* FROM Marcas";

                using var connection = new SqlConnection(_configuration.GetConnectionString("DafultConnection"));
                var motorcycles = await connection.QueryAsync<Marcas>(query);
                return motorcycles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
