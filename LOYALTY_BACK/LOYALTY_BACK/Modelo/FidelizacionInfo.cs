using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class FidelizacionInfo
    {
        public int id_fidelizacion {  get; set; }
        public int id_usuario { get; set; }
        public int id_metodo { get; set; }
        public string? CodigoFidelizacion { get; set; }
        public int PuntosAcumulados { get; set; }
    }
}
