using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Articulo
    {
        public int articulo_id {  get; set; }
        public string? nombre { get; set; }
        public long codigo { get; set; }
        public int seccion { get; set; }
    }
}
