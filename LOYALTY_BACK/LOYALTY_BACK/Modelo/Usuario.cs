using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class Usuario
    {
        public int us_id {  get; set; }
        public int? tienda_id { get; set; }
        public int? dato_id { get; set; }
        public string? usuario { get; set; }
        public string? password { get; set; }
        public int? papel_0 {  get; set; }
        public string? token { get; set; }
        public int estado {  get; set; }
    }
}
