using LOYALTY_BACK.Comunicacion;
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

        private readonly BD _conexionBD;
        private readonly Concentrador _conexionConcentrador;

        public TicketsService(BD conexionBD)
        {
            _conexionBD = conexionBD;
            _conexionConcentrador = new Concentrador();
        }

       

        public async Task<Ticket> GetTicketById(int ticketId)
        {
            Ticket ticket = await _conexionBD.GetTicketById(ticketId);

            if (ticket == null)
            {
                // El ticket no existe en la base de datos, llamamos al servicio web
                ticket = await _conexionConcentrador.GetTicketFromWebService(ticketId);

                if (ticket != null)
                {
                    // Guardar el ticket en la base de datos
                    await _conexionBD.SaveTicketToDatabase(ticket);
                }
            }

            return ticket;
        }


       


    }
}
