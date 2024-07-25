using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LOYALTY_BACK
{
    public class Globales
    {

        public static String VERSION = "1.0";
        public static Boolean DEBUG_MODE = true;
        public static string LOGS_DESTINATION_FOLDER = @"C:\loyalty\logs\loyalty.log";

        public static String IP_SERVER = "localhost";
        public static String PORT_SERVER = "3000";



        /*static (string Codigo, int Puntos) GetFidelizacionInfo(string idCliente)
        {
            string connectionString = "your_connection_string_here"; // Actualiza con tu cadena de conexión
            string codigoFidelizacion = string.Empty;
            int puntosAcumulados = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CodigoFidelizacion, Puntos FROM Clientes WHERE IdCliente = @IdCliente";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCliente", idCliente);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigoFidelizacion = reader["CodigoFidelizacion"].ToString();
                            puntosAcumulados = Convert.ToInt32(reader["Puntos"]);
                        }
                    }
                }
            }

            return (codigoFidelizacion, puntosAcumulados);
        }*/

        /**
         * Guarda el 'texto' en un fichero de log
         **/
        public static void CrearLog(String texto)
        {
            try
            {

                // Verificar si el archivo NO existe
                if (!File.Exists(LOGS_DESTINATION_FOLDER))
                {
                    // Si no existe, crear el archivo y escribir contenido inicial
                    using (StreamWriter writer = File.CreateText(LOGS_DESTINATION_FOLDER))
                    {
                        // Obtener la fecha actual
                        DateTime fechaActual = DateTime.Now;

                        // Agregar contenido al final del archivo
                        writer.WriteLine($"{fechaActual}: " + texto);
                    }
                }

                // Abrir el archivo en modo de escritura, agregando contenido al final
                using (StreamWriter writer = File.AppendText(LOGS_DESTINATION_FOLDER))
                {

                    // Obtener la fecha actual
                    DateTime fechaActual = DateTime.Now;

                    // Agregar contenido al final del archivo
                    writer.WriteLine($"{fechaActual}: " + texto);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error al abrir el log " + LOGS_DESTINATION_FOLDER + ": " + ex.Message);
                MessageBox.Show("Error al abrir el log " + LOGS_DESTINATION_FOLDER + ": " + ex.Message);
            }

        }

        /**
         * Guarda el 'texto' en un fichero de log si la variable debug_mode esta a true
         **/
        public static void CrearLogDebug(String texto)
        {
            if (DEBUG_MODE)
            {
                try
                {

                    // Verificar si el archivo NO existe
                    if (!File.Exists(LOGS_DESTINATION_FOLDER))
                    {
                        // Si no existe, crear el archivo y escribir contenido inicial
                        using (StreamWriter writer = File.CreateText(LOGS_DESTINATION_FOLDER))
                        {
                            // Obtener la fecha actual
                            DateTime fechaActual = DateTime.Now;

                            // Agregar contenido al final del archivo
                            writer.WriteLine($"{fechaActual}: " + texto);
                        }
                    }

                    // Abrir el archivo en modo de escritura, agregando contenido al final
                    using (StreamWriter writer = File.AppendText(LOGS_DESTINATION_FOLDER))
                    {

                        // Obtener la fecha actual
                        DateTime fechaActual = DateTime.Now;

                        // Agregar contenido al final del archivo
                        writer.WriteLine($"{fechaActual}: " + texto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el log " + LOGS_DESTINATION_FOLDER + ": " + ex.Message);
                }
            }

        }


    }
}
