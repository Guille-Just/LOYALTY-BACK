using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class DocumentoDetalle
    {
        public int detalle_id {  get; set; }
        public int doc_id { get; set; }
        public int articulo_id {  get; set; }
        public double cantidad { get; set; }
        public double precio {  get; set; }
    }
}
