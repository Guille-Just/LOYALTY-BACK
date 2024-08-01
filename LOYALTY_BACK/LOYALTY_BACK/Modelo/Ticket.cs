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
        public int doc_id { get; set; }
    }
}
