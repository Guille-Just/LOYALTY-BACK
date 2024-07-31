using LOYALTY_BACK.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Controlador
{
    internal class TicketsController : BaseController
    {

        private readonly TicketsService _ticketService;

        public TicketsController(TicketsService ticketService)
        {
            _ticketService = ticketService;
        }

        protected override Task<string> HandleGetRequest(string path, string idCliente)
        {
            return Task.FromResult(HandleTicketRequest(path, idCliente));
        }

        private string HandleTicketRequest(string path, string idCliente)
        {
            if (path == "/ticket")
            {
                var tiketInfo = _ticketService.GetTiketInfo(idCliente);
                if (tiketInfo != null)
                {
                    return JsonSerializer.Serialize(tiketInfo);
                }
                else
                {
                    return JsonSerializer.Serialize(new { Error = "Cliente no encontrado." });
                }
            }
            /*else if (path == "/tikets")
            {
                var externalInfo = await ServiciosConcentrador.GetExternalInfoTiketsAsync(idCliente);
                return JsonSerializer.Serialize(externalInfo);
            }*/
            else
            {
                return JsonSerializer.Serialize(new { Error = "Ruta no soportada." });
            }
        }

    }
}
