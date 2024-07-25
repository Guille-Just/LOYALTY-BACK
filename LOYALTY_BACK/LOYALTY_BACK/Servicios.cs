using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using Npgsql;


namespace LOYALTY_BACK
{
    public class Servicios
    {
        public static async Task ServicioSegundoPlano()
        {


            HttpListener listener = new HttpListener();
            string url = "http://" + Globales.IP_SERVER + ":" + Globales.PORT_SERVER + "/";
            listener.Prefixes.Add(url);
            listener.Start();
            Globales.CrearLog("Escuchando peticiones en " + url );

            while (true)
            {
                HttpListenerContext context = await listener.GetContextAsync();
                _ = Task.Run(() => HandleRequest(context));
            }
        }

        static async Task HandleRequest(HttpListenerContext context)
        {
            string responseString = string.Empty;
            try
            {
                if (context.Request.HttpMethod == "GET")
                {
                    string path = context.Request.Url.AbsolutePath;
                    string idCliente = context.Request.QueryString["id_cliente"];
                    if (!string.IsNullOrEmpty(idCliente))
                    {
                        
                        if (path == "/fidelizacion")
                        {
                            var fidelizacionInfo = GetFidelizacionInfo(idCliente);
                            responseString = JsonSerializer.Serialize(new
                            {
                                CodigoFidelizacion = fidelizacionInfo.Codigo,
                                PuntosAcumulados = fidelizacionInfo.Puntos
                            });
                        }
                        else if (path == "/tikets")
                        {
                            var externalInfo = await ServiciosConcentrador.GetExternalInfoTiketsAsync(idCliente);
                            responseString = JsonSerializer.Serialize(externalInfo);
                        }
                        else
                        {
                            responseString = JsonSerializer.Serialize(new { Error = "Ruta no soportada." });
                        }
                    }
                    else
                    {
                        responseString = JsonSerializer.Serialize(new { Error = "Parametro id_cliente es requerido." });
                    }
                }
                else
                {
                    responseString = JsonSerializer.Serialize(new { Error = "Método no soportado. Utiliza GET." });
                }
            }
            catch (Exception ex)
            {
                responseString = JsonSerializer.Serialize(new { Error = $"Error: {ex.Message}" });
            }

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            context.Response.ContentLength64 = buffer.Length;
            await context.Response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();

            Globales.CrearLog("Respuesta: " + responseString);
        }



        static (string Codigo, int Puntos) GetFidelizacionInfo(string idCliente)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=asd;Database=postgres"; // Actualiza con tu cadena de conexión
            string codigoFidelizacion = string.Empty;
            int puntosAcumulados = 0;

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT codigo, puntos FROM fidelizacion WHERE id = @IdCliente";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", double.Parse(idCliente));

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                codigoFidelizacion = reader["codigo"].ToString();
                                puntosAcumulados = Convert.ToInt32(reader["puntos"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Globales.CrearLog($"Error al acceder a la base de datos: {ex.Message}");
            }

            return (codigoFidelizacion, puntosAcumulados);
        }
    }
}
