using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Documento
    {
        public int doc_id { get; set; }
        public int fidelizacion_id { get; set; }
        public DateTime fecha { get; set; }
        public int tipo { get; set; }
        public decimal importe { get; set; }
        public string local { get; set; }
        public string num_documento_formateado { get; set; }
    }
}
