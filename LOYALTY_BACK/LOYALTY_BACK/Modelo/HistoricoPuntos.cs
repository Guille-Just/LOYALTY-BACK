using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    internal class HistoricoPuntos
    {
        public int puntos_id { get; set; }
        public int fidelizacion_id { get; set; }
        public DateTime? fecha { get; set; }
        public int tipo { get; set; }
        public double valor { get; set; }
    }
}
