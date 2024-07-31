using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class ArticulosXTienda
    {
        public int art_x_tienda_id {  get; set; }
        public int id_tienda {  get; set; }
        public int articulo_id { get; set; }
        public double precio { get; set; }
    }
}
