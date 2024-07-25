using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Modelo
{
    public partial class Usuario
    {
        public int ID {  get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Token {  get; set; }
        public int? Confirmado { get; set;}
        public int? Tipo_Cod_Fidelizacion { get; set;}
        public int? ID_Local_Fav { get; set; }
        public string? Nombre_Local_Fav { get;set; }
        public string? CIF { get; set; }
        public double? Puntos { get; set; }
        public string? Cod_Fidelizacion { get; set;}
        public int? Papel_Cero {  get; set; }
        public string? CPostal {  get; set; }
    }
}
