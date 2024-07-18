using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using models.models;

namespace GlobalGO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : Controller
    {
        private readonly IConfiguration _configuration;

        public MotorcycleController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("getMotorcycles")]
        public async Task<IEnumerable<Motorcycle>> GetMotorcycles()
        {
            try
            {
                var query = @"
                          Select MO.IdModelo,MO.Modelo,MO.RGB,MO.Precio,
                         MA.Logo,MA.Marca,ESP.Imagen,
                         ESP.Cilindrada,ESP.Potencia,ESP.Torque,ESP.Combustible,ESP.Tanque,ESP.Rendimiento,ESP.Autonomia, 
                         ESP.Transmision,ESP.Velocidad,ESP.Suspension_delantero,ESP.Peso,ESP.Carga,ESP.Largo,ESP.Ancho,
                         ESP.Alto, MO.Texto, CA.Categoria, CA.Icono, ESP.Freno_delantero,ESP.Freno_posterior, 
                         ESP.Suspension_delantero, ESP.Suspension_posterior
                         from Modelos AS MO
                         INNEr JOIN Marcas AS MA ON MO.IdMarca = MA.IdMarca
                         INNER JOIN Especificaciones AS ESP ON ESP.IdModelo = MO.IdModelo
                         --INNER JOIN Carruseles as CAR ON CAR.IdModelo = MO.IdModelo
                          INNER JOIN Categorias AS CA ON CA.IdCategoria = MO.IdCategoria
                          ORDER BY 4 DESC
                            ";

                using var connection = new SqlConnection(_configuration.GetConnectionString("DafultConnection"));
                var motorcycles = await connection.QueryAsync<Motorcycle>(query);
                return motorcycles;
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
                var query = @" 
                           Select MO.IdModelo,MO.Modelo,MO.RGB,MO.Precio,
	                       MA.Logo,MA.Marca,ESP.Imagen,
	                       ESP.Cilindrada,ESP.Potencia,ESP.Torque,ESP.Combustible,ESP.Tanque,ESP.Rendimiento,ESP.Autonomia, 
	                       ESP.Transmision,ESP.Velocidad,ESP.Suspension_delantero,ESP.Peso,ESP.Carga,ESP.Largo,ESP.Ancho,
	                       ESP.Alto, MO.Texto, CA.Categoria, CA.Icono, ESP.Freno_delantero,ESP.Freno_posterior, 
	                       ESP.Suspension_delantero, ESP.Suspension_posterior
                           from Modelos AS MO
                              INNER JOIN Marcas AS MA ON MO.IdMarca = MA.IdMarca
                              INNER JOIN Especificaciones AS ESP ON ESP.IdModelo = MO.IdModelo
                              --INNER JOIN Carruseles as CAR ON CAR.IdModelo = MO.IdModelo
                              INNER JOIN Categorias AS CA ON CA.IdCategoria = MO.IdCategoria
                              WHERE MO.IdModelo = @Id";

                using var connection = new SqlConnection(_configuration.GetConnectionString("DafultConnection"));
                var motorcycle = await connection.QueryFirstOrDefaultAsync<Motorcycle>(query, new { Id = id });
                return motorcycle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


    }
}
