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
        public int tienda_id { get; set; }
        public int tipo_fid_id { get; set; }
        public string? CodigoFidelizacion { get; set; }
        public int PuntosAcumulados { get; set; }

        public int papel_0 { get; set; }
    }
}
