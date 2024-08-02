using LOYALTY_BACK.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;

namespace LOYALTY_BACK.Controlador
{
    internal class FidelizacionController : BaseController
    {

        private readonly FidelizacionService _fidelizacionService;

        public FidelizacionController(FidelizacionService fidelizacionService)
        {
            _fidelizacionService = fidelizacionService;
        }

        protected override Task<string> HandleGetRequest(string path, string idCliente)
        {
            return Task.FromResult(HandleFidelizacionRequest(path, idCliente));
        }

        private string HandleFidelizacionRequest(string path, string idCliente)
        {
            if (path == "/fidelizacion")
            {
                var tiketInfo = _fidelizacionService.GetFidelizacionInfo(idCliente);
                if (tiketInfo != null)
                {
                    return JsonSerializer.Serialize(tiketInfo);
                }
                else
                {
                    return JsonSerializer.Serialize(new { Error = "Cliente no encontrado." });
                }
            }
            else
            {
                return JsonSerializer.Serialize(new { Error = "Ruta no soportada." });
            }
        }

        
    }
}
