using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Oferta
    {
        public int oferta_id {  get; set; }
        public int art_x_tienda_id {  get; set; }
        public string? nombre { get; set; }
        public int tipo { get; set; }
        public double valor { get; set; }
    }
}
