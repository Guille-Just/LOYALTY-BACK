using LOYALTY_BACK.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;

namespace LOYALTY_BACK.Controlador
{
    internal class FidelizacionController
    {

        private readonly FidelizacionService _fidelizacionService;

        public FidelizacionController(FidelizacionService fidelizacionService)
        {
            _fidelizacionService = fidelizacionService;
        }

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
                    Globales.CrearLog("Solicitud: " + context.Request.Url);
                    if (!string.IsNullOrEmpty(idCliente))
                    {
                        if (path == "/fidelizacion")
                        {
                            var fidelizacionInfo = _fidelizacionService.GetFidelizacionInfo(idCliente);
                            if (fidelizacionInfo != null)
                            {
                                responseString = JsonSerializer.Serialize(fidelizacionInfo);
                            }
                            else
                            {
                                responseString = JsonSerializer.Serialize(new { Error = "Cliente no encontrado." });
                            }
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
    }
}
