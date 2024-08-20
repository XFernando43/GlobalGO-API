using GlobalGO.models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace GlobalGO.services
{
    public class CarruselRepository : ICarruselRepository
    {
        public async Task<IEnumerable<Carruseles>> GetCarruselsByID(string sqlconnection, int idModelo)
        {
            try
            {
                var query = @"SELECT *
                              FROM dbo.Carruseles
                              WHERE IdModelo = @idModelo";

                using var connection = new SqlConnection(sqlconnection);
                var carrusel = await connection.QueryAsync<Carruseles>(query, new { idModelo });
                return carrusel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
