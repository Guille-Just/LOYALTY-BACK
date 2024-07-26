using LOYALTY_BACK.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Servicios
{
    internal class FidelizacionService
    {

        private readonly string _connectionString;

        public FidelizacionService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public FidelizacionInfo GetFidelizacionInfo(string idCliente)
        {
            FidelizacionInfo fidelizacionInfo = null;

            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT codigo, puntos FROM Clientes WHERE id = @IdCliente";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", double.Parse(idCliente));

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fidelizacionInfo = new FidelizacionInfo
                                {
                                    CodigoFidelizacion = reader["CodigoFidelizacion"].ToString(),
                                    PuntosAcumulados = Convert.ToInt32(reader["Puntos"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al acceder a la base de datos: {ex.Message}");
            }

            return fidelizacionInfo;
        }
    }
        
}
