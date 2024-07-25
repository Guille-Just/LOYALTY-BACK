namespace LOYALTY_BACK
{
    public partial class Configurador : Form
    {
        public Configurador()
        {
            InitializeComponent();
            Globales.CrearLog("Se inicio loyalty v" + Globales.VERSION);
            Task task = Servicios.ServicioSegundoPlano();
        }
    }
}
