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

        //Datos de servidor propio
        public static String IP_SERVER          = "localhost";
        public static String PORT_SERVER        = "3000";

        //Datos de conexion a concentrador
        public static String vg_ip_concentrador               = "192.168.253.89";
        public static String vg_puerto_concentrador           = "8080";
        public static String vg_ruta_concentrador_ticket      = "webfidelizacion/reportdocumento";
        public static String vg_ruta_concentrador_list_ticket = "webfidelizacion/documentos";





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


        /**
         * Guardar un pdf en formato byte[] en un directorio
         * */
        public void SavePdf(byte[] pdfData, string filePath)
        {
            try
            {
                // Asegúrate de que el directorio existe
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Escribir los bytes en el archivo
                File.WriteAllBytes(filePath, pdfData);
                Console.WriteLine($"PDF guardado correctamente en {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el PDF: {ex.Message}");
            }
        }


    }


   
}
