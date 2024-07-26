using Dapper;
using GlobalGO.models;
using Microsoft.Data.SqlClient;

namespace GlobalGO.services
{
    public class CategoryRepository : ICategoryRepository
    {
        public async Task<IEnumerable<Categorias>> GetCategories(string sqlconexion)
        {
            try
            {
                var query = @"SELECT * FROM Categorias";

                using var connection = new SqlConnection(sqlconexion);
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
