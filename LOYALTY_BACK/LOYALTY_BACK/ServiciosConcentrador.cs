using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LOYALTY_BACK
{
    internal class ServiciosConcentrador
    {

        public static async Task<object> GetExternalInfoTiketsAsync(string idCliente)
        {
            string status = "alive";
            if (Int128.Parse(idCliente) % 3 == 0)
            {
                status = "dead";
            }
            else if (Int128.Parse(idCliente) % 3 == 1) status = "unknown";

            //string externalServiceUrl = "https://rickandmortyapi.com/api/character/?status=" + status; // Actualiza con la URL del servicio externo

            //http://192.168.253.89:8080/webfidelizacion/documentos?codigo=21468706&dias=590
            string externalServiceUrl = "http://192.168.253.89:8080/webfidelizacion/documentos?codigo=" + idCliente + "&dias=590";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(externalServiceUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var externalInfo = JsonSerializer.Deserialize<object>(responseBody); // Actualiza el tipo según el esquema del JSON devuelto por el servicio externo
                return externalInfo;
            }
        }

    }
}
