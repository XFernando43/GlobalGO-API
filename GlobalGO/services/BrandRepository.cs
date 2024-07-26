﻿using Dapper;
using GlobalGO.models;
using Microsoft.Data.SqlClient;
namespace GlobalGO.services
{
    public class BrandRepository : IBrandRepository
    {
        public async Task<IEnumerable<Marcas>> GetBrands(string sqlconnection)
        {
            if (string.IsNullOrEmpty(sqlconnection))
            {
                throw new ArgumentException("La cadena de conexión no puede estar vacía.", nameof(sqlconnection));
            }

            try
            {
                var query = @"SELECT * FROM Marcas";

                using var connection = new SqlConnection(sqlconnection);
                var brands = await connection.QueryAsync<Marcas>(query);
                return brands;
            }
            catch (Exception ex)
            {
                // Puedes usar un mecanismo de logging en lugar de Console.WriteLine
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                // O puedes lanzar la excepción para que sea manejada por el llamador
                throw;
            }
        }
    }
}