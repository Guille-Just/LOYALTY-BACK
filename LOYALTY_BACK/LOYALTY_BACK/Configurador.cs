using LOYALTY_BACK.Controlador;
using LOYALTY_BACK.Servicios;
using Npgsql;
using System.Net;

namespace LOYALTY_BACK
{
    public partial class Configurador : Form
    {
        public Configurador()
        {
            InitializeComponent();
            Globales.CrearLog("Se inicio loyalty v" + Globales.VERSION);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Globales.IP_SERVER = tb_ip_server.Text;
            Globales.PORT_SERVER = tb_port_server.Text;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string username = Environment.GetEnvironmentVariable("DB_USERNAME");
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string database = Environment.GetEnvironmentVariable("DB_NAME");

            string connectionString = $"Host={host};Username={username};Password={password};Database={database}";




            Task task = ServicioSegundoPlano(connectionString);

        }

        public static async Task ServicioSegundoPlano(string connectionString)
        {

            var fidelizacionService = new FidelizacionService(connectionString);
            var fidelizacionController = new FidelizacionController(fidelizacionService);
            var ticketService = new TicketsService(connectionString);
            var ticketController = new TicketsController(ticketService);

            HttpListener listener = new HttpListener();
            string url = "http://" + Globales.IP_SERVER + ":" + Globales.PORT_SERVER + "/";
            listener.Prefixes.Add(url);
            listener.Start();
            Globales.CrearLog("Escuchando peticiones en " + url);

            while (true)
            {
                //HttpListenerContext context = await listener.GetContextAsync();
                //_ = Task.Run(() => fidelizacionController.HandleRequest(context));
                HttpListenerContext context = await listener.GetContextAsync();

                if (context.Request.Url.AbsolutePath.StartsWith("/fidelizacion"))
                {
                    _ = Task.Run(() => fidelizacionController.HandleRequest(context));
                }
                else if (context.Request.Url.AbsolutePath.StartsWith("/ticket"))
                {
                    _ = Task.Run(() => ticketController.HandleRequest(context));
                }
                else
                {
                    context.Response.StatusCode = 404;
                    context.Response.Close();
                }
            }
        }




        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //TESTING
        //-----------------------------------------------------------------------------------------------------------------------------------------------------

        private void btn_test_subir_ticket_a_bd(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo a insertar
                string filePath = @"C:\reportdocumento.pdf";
                filePath = @""+tb_ruta_ticket.Text;
                int fidelizacion_id = Convert.ToInt32(tb_fid_id.Text);
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // Conexión a la base de datos
                string host = Environment.GetEnvironmentVariable("DB_HOST");
                string username = Environment.GetEnvironmentVariable("DB_USERNAME");
                string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
                string database = Environment.GetEnvironmentVariable("DB_NAME");
                string connectionString = $"Host={host};Username={username};Password={password};Database={database}";

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand("INSERT INTO public.ticket( fid_id, ticket) VALUES ( @fid_id, @ticket)", connection))
                    {
                        // Configurar los parámetros
                        command.Parameters.AddWithValue("fid_id", fidelizacion_id);
                        command.Parameters.AddWithValue("ticket", fileBytes);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Inserción realizada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
