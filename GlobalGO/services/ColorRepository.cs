using GlobalGO.models;
using Microsoft.Data.SqlClient;
using models.models;
using Dapper;

namespace GlobalGO.services
{
    public class ColorRepository : IColorRepository
    {
        public async Task<IEnumerable<Colores>> getModelColors(string conexion, int id)
        {
            try
            {
                var query = @"
                     SELECT M.Modelo, C.name_color,C.hex1,C.hex2
                     FROM dbo.Modelos AS M
                     INNER JOIN dbo.ModeloXColor AS MC ON MC.modelo_id = M.IdModelo
                     INNER JOIN dbo.Color AS C ON C.id = MC.color_id
                     WHERE M.IdModelo = @id;
                ";

                using var connection = new SqlConnection(conexion);
                var colors = await connection.QueryAsync<Colores>(query, new { id = id });
                return colors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
