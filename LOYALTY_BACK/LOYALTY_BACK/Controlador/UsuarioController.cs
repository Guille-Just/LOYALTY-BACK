using LOYALTY_BACK.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK.Controlador
{
    public class UsuarioController
    {
        public bool InsertUsuario(Usuario usuario)
        {
            bool resultado = false;

            return resultado;
        }

        public bool DeleteUsuario(int id) 
        {
            bool resultado = false;

            return resultado;
        }

        public bool ModifyUsuario(int id)
        {
            bool resultado = false;

            return resultado;
        }
        public Usuario? GetUsuario(int id)
        {
            Usuario? usuario = null;

            return usuario;
        } 
        public  bool CheckLogin(string user, string pass)
        {
            bool resultado = false;

            if(user == "Guille" && pass == "123456")
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
