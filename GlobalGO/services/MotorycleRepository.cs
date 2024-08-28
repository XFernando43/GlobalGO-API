using Dapper;
using GlobalGO.models;
using Microsoft.Data.SqlClient;
using models.models;

namespace GlobalGO.services
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        public async Task<Motorcycle> GetMotorcycle(string sqlConexion, int id)
        {
            try
            {
                var query = @"
                    SELECT MO.IdModelo, MO.Modelo, MO.RGB, MO.Precio,
                           MA.Logo, MA.Marca, ESP.Imagen,
                           ESP.Cilindrada, ESP.Potencia, ESP.Torque, ESP.Combustible, ESP.Tanque, ESP.Rendimiento, ESP.Autonomia, 
                           ESP.Transmision, ESP.Velocidad, ESP.Suspension_delantero, ESP.Peso, ESP.Carga, ESP.Largo, ESP.Ancho,
                           ESP.Alto, MO.Texto, CA.Categoria, CA.Icono, ESP.Freno_delantero, ESP.Freno_posterior, 
                           ESP.Suspension_delantero, ESP.Suspension_posterior
                    FROM Modelos AS MO
                    INNER JOIN Marcas AS MA ON MO.IdMarca = MA.IdMarca
                    INNER JOIN Especificaciones AS ESP ON ESP.IdModelo = MO.IdModelo
                    INNER JOIN Categorias AS CA ON CA.IdCategoria = MO.IdCategoria
                    WHERE MO.IdModelo = @Id";
                
                var sqlColors = @"
                     SELECT M.Modelo, C.name_color,C.hex1,C.hex2
                     FROM dbo.Modelos AS M
                     INNER JOIN dbo.ModeloXColor AS MC ON MC.modelo_id = M.IdModelo
                     INNER JOIN dbo.Color AS C ON C.id = MC.color_id
                     WHERE M.IdModelo = @Id;
                ";


                using var connection = new SqlConnection(sqlConexion);
                var motorcycle = await connection.QueryFirstOrDefaultAsync<Motorcycle>(query, new { Id = id });
                var colors = await connection.QueryAsync<Colores>(sqlColors, new { Id = id });
                motorcycle.Colores = colors.ToList();


                return motorcycle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Motorcycle>> GetMotorcycles(string sqlConexion)
        {
            try
            {
                var query = @"
                    SELECT MO.IdModelo, MO.Modelo, MO.RGB, MO.Precio,
                           MA.Logo, MA.Marca, ESP.Imagen,
                           ESP.Cilindrada, ESP.Potencia, ESP.Torque, ESP.Combustible, ESP.Tanque, ESP.Rendimiento, ESP.Autonomia, 
                           ESP.Transmision, ESP.Velocidad, ESP.Suspension_delantero, ESP.Peso, ESP.Carga, ESP.Largo, ESP.Ancho,
                           ESP.Alto, MO.Texto, CA.Categoria, CA.Icono, ESP.Freno_delantero, ESP.Freno_posterior, 
                           ESP.Suspension_delantero, ESP.Suspension_posterior
                    FROM Modelos AS MO
                    INNER JOIN Marcas AS MA ON MO.IdMarca = MA.IdMarca
                    INNER JOIN Especificaciones AS ESP ON ESP.IdModelo = MO.IdModelo
                    INNER JOIN Categorias AS CA ON CA.IdCategoria = MO.IdCategoria
                    ORDER BY MO.Precio DESC";

                using var connection = new SqlConnection(sqlConexion);
                var motorcycles = await connection.QueryAsync<Motorcycle>(query);
                return motorcycles.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
