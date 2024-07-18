using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using models.models;
using Dapper;
using GlobalGO.models;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;
        public CategoryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("getAll")]
        public async Task<IEnumerable<Categorias>> getCategories()
        {
            try
            {
                var query = @"SELECT* FROM Categorias";

                using var connection = new SqlConnection(_configuration.GetConnectionString("DafultConnection"));
                var categories = await connection.QueryAsync<Categorias>(query);
                return categories;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
