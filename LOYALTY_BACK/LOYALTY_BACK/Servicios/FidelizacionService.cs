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
                    string query = "SELECT * FROM fidelizacion WHERE fid_id = @IdCliente";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", int.Parse(idCliente));

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fidelizacionInfo = new FidelizacionInfo
                                {
                                    tipo_fid_id = reader.IsDBNull(reader.GetOrdinal("tipo_fid_id")) ? 0 : Convert.ToInt32(reader["tipo_fid_id"]),
                                    id_fidelizacion = reader.IsDBNull(reader.GetOrdinal("fid_id")) ? 0 : Convert.ToInt32(reader["fid_id"]),
                                    tienda_id = reader.IsDBNull(reader.GetOrdinal("tienda_id")) ? 0 : Convert.ToInt32(reader["tienda_id"]),
                                    papel_0 = reader.IsDBNull(reader.GetOrdinal("papel_0")) ? 0 : Convert.ToInt32(reader["papel_0"]),
                                    CodigoFidelizacion = reader.IsDBNull(reader.GetOrdinal("codigo")) ? "" : reader["codigo"].ToString(),
                                    PuntosAcumulados = reader.IsDBNull(reader.GetOrdinal("puntos")) ? 0 : Convert.ToInt32(reader["puntos"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Globales.CrearLog($"Error al acceder a la base de datos: {ex.Message}");
            }

            return fidelizacionInfo;
        }
    }
        
}
