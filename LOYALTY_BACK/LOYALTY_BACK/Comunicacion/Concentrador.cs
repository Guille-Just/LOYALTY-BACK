using LOYALTY_BACK.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Comunicacion
{
    internal class Concentrador
    {
        
        private readonly HttpClient _httpClient;

        public Concentrador()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            _httpClient = new HttpClient(handler); // Inicializar HttpClient con el handler personalizado

        }

        

        public async Task<Ticket> GetTicketFromWebService(int ticketId)
        {
            Ticket ticket = null;

            try
            {
                // URL del servicio web - Actualizar con la URL real
                string url = $"http://" + Globales.vg_ip_concentrador + ":" + Globales.vg_puerto_concentrador + "/" + Globales.vg_ruta_concentrador_ticket + "?id=" + ticketId ;
                Globales.CrearLogDebug("Llamada al concentrador: " +url);
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                Byte [] byteResponseBody = await response.Content.ReadAsByteArrayAsync();
                Globales.CrearLogDebug("Respuesta: " + byteResponseBody);

                // Leer el contenido como byte array
                byte[] pdfData = await response.Content.ReadAsByteArrayAsync();

                // Guardar el PDF en el sistema de archivos para verificación
                //Globales.SavePdf(pdfData, $"C:\\loyalty\\file_{ticketId}.pdf");
                
                ticket = new Ticket(ticketId, pdfData);
            }
            catch (Exception ex)
            {
                Globales.CrearLog($"Error al llamar al servicio web: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Globales.CrearLog($"Excepción interna: {ex.InnerException.Message}");
                }
            }

            return ticket;
        }



        public async Task<Ticket> GetListadoTicketFromWebService(int ticketId)
        {
            Ticket ticket = null;

            try
            {
                // URL del servicio web - Actualizar con la URL real
                string url = $"http://" + Globales.vg_ip_concentrador + ":" + Globales.vg_puerto_concentrador + "/" + Globales.vg_ruta_concentrador_list_ticket + "?id=" + ticketId;
                Globales.CrearLogDebug("Llamada al concentrador: " + url);
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                Byte[] byteResponseBody = await response.Content.ReadAsByteArrayAsync();
                Globales.CrearLogDebug("Respuesta: " + byteResponseBody);

                // Leer el contenido como byte array
                //byte[] pdfData = await response.Content.ReadAsByteArrayAsync();

                // Guardar el PDF en el sistema de archivos para verificación
                //Globales.SavePdf(pdfData, $"C:\\loyalty\\file_{ticketId}.pdf");

                //ticket = new Ticket(ticketId, pdfData);
            }
            catch (Exception ex)
            {
                Globales.CrearLog($"Error al llamar al servicio web: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Globales.CrearLog($"Excepción interna: {ex.InnerException.Message}");
                }
            }

            return ticket;
        }




    }
}
