using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Cupon
    {
        public int cupon_id {  get; set; }
        public int fidelizacion_id { get; set; }
        public string? nombre { get; set; }
        public int tipo { get; set; }
        public double valor {  get; set; }
    }
}
