using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Tienda
    {
        public int id_tienda {  get; set; }
        public int empresa_id { get; set; }
        public int dato_id { get; set; }
        public double coordenada_x { get; set; }
        public double coordenada_y { get; set; }
        public string? nombre_tienda { get; set; }
    }
}
