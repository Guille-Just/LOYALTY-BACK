using LOYALTY_BACK.Modelo;
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
            return null;
        }

        protected override Task<string> HandleGetRequest(string path, string idCliente, string idTicket)
        {
            if (path == "/ticket")
            {
                return Task.FromResult(HandleTicketRequest(path, idTicket));
            }
            else if (path == "/ult_tiket")
            {
                return Task.FromResult(HandleTicketRequest(path, idCliente));
            }
            else //listado de tickets
            {
                return Task.FromResult(HandleTicketRequest(path, idCliente));
            }
        }

        private string HandleTicketRequest(string path, string idTicket)
        {
            if (path == "/ticket")
            {
                if (!string.IsNullOrEmpty(idTicket))
                {
                    int ticketId;
                    if (int.TryParse(idTicket, out ticketId))
                    {
                        var ticket =  _ticketService.GetTicketById(ticketId);
                        return JsonSerializer.Serialize(ticket);
                    }
                    else
                    {
                        return JsonSerializer.Serialize(new { Error = "ID de ticket no válido." });
                    }
                }
                else
                {
                    return JsonSerializer.Serialize(new { Error = "Cliente no encontrado." });
                }
            }
            
            else
            {
                return JsonSerializer.Serialize(new { Error = "Ruta no soportada." });
            }
        }

        

    }
}
