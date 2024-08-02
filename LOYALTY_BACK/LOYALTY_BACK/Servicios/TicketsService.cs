using LOYALTY_BACK.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Servicios
{
    internal class TicketsService
    {

        private readonly string _connectionString;

        public TicketsService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Ticket GetTiketInfo(string idCliente)
        {
            Ticket ticket = null;

            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ticket WHERE fid_id = @IdCliente";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", int.Parse(idCliente));

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ticket = new Ticket
                                {
                                    fidelizacion_id = reader.IsDBNull(reader.GetOrdinal("fid_id")) ? 0 : Convert.ToInt32(reader["fid_id"]),
                                    ticket_id = reader.IsDBNull(reader.GetOrdinal("ticket_id")) ? 0 : Convert.ToInt32(reader["ticket_id"]),
                                    doc_id = reader.IsDBNull(reader.GetOrdinal("doc_id")) ? 0 : Convert.ToInt32(reader["doc_id"]),
                                    ticket = reader.IsDBNull(reader.GetOrdinal("ticket")) ? null : reader["ticket"] as byte[] // Leer el campo bytea como byte[]
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

            return ticket;
        }


    }
}
