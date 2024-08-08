using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Controlador
{
    internal abstract class BaseController
    {

        public async Task HandleRequest(HttpListenerContext context)
        {
            string responseString = string.Empty;
            context.Response.ContentType = "application/json";

            try
            {
                if (context.Request.HttpMethod == "GET")
                {
                    string path = context.Request.Url.AbsolutePath;
                    string idCliente = context.Request.QueryString["id_cliente"];
                    string idTicket = context.Request.QueryString["id_ticket"];
                    Globales.CrearLog("Solicitud: " + context.Request.Url);
                    if (!string.IsNullOrEmpty(idCliente) || !string.IsNullOrEmpty(idTicket))
                    {
                        responseString = await HandleGetRequest(path, idCliente, idTicket);
                    }
                    else
                    {
                        responseString = JsonSerializer.Serialize(new { Error = "Parámetro id_cliente es requerido." });
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

        protected abstract Task<string> HandleGetRequest(string path, string idCliente, string idTicket);

        protected abstract Task<string> HandleGetRequest(string path, string idCliente);


    }
}
