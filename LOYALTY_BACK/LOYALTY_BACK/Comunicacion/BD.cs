using LOYALTY_BACK.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Comunicacion
{
    internal class BD
    {
        private readonly string _connectionString;

        public BD(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<Ticket> GetTicketById(int ticketId)
        {
            Ticket ticket = null;

            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT ticket_id, fid_id, ticket FROM ticket WHERE ticket_id = @TicketId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketId", ticketId);

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                ticket = new Ticket
                                {
                                    ticket_id = reader.IsDBNull(reader.GetOrdinal("ticket_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("ticket_id")),
                                    fidelizacion_id = reader.IsDBNull(reader.GetOrdinal("fid_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("fid_id")),
                                    //doc_id = reader.IsDBNull(reader.GetOrdinal("doc_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("doc_id")),
                                    ticket = reader.IsDBNull(reader.GetOrdinal("ticket")) ? null : (byte[])reader["ticket"]
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

        public async Task SaveTicketToDatabase(Ticket ticket)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ticket (ticket_id, fid_id, doc_id, ticket) VALUES (@TicketId, @FidId, @DocId, @Ticket)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketId", ticket.ticket_id);
                        command.Parameters.AddWithValue("@FidId", ticket.fidelizacion_id);
                        //command.Parameters.AddWithValue("@DocId", ticket.doc_id);
                        command.Parameters.AddWithValue("@Ticket", ticket.ticket);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Globales.CrearLog($"Error al guardar el ticket en la base de datos: {ex.Message}");
            }
        }

        

    }
}
