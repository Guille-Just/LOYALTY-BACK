using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Ticket
    {
        public int ticket_id {  get; set; }
        public int fidelizacion_id { get; set; }
        public byte[] ticket { get; set; }

        public Ticket()
        {
            
        }

        public Ticket(int ticket_id, byte[] ticket_pdf)
        {
            //byte[] bytes = Encoding.ASCII.GetBytes(ticket_pdf);
            this.ticket_id = ticket_id;
            this.ticket = ticket_pdf;
        }
    }

    
}
