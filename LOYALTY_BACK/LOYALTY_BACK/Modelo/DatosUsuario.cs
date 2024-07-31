using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class DatosUsuario
    {
        public int dato_id { get; set; }
        public string? nombre { get; set; }
        public string? apellidos { get; set; }
        public string? correo { get; set; }
        public string? documento { get; set; }
        public string? telefono_1 { get; set; }
        public string? telefono_2 { get; set; }
        public DateTime? nacimiento { get; set; }
        public string? web {  get; set; }
        public string? direccion { get; set; }
    }
}
