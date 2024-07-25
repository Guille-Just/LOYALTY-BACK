namespace LOYALTY_BACK
{
    public partial class Configurador : Form
    {
        public Configurador()
        {
            InitializeComponent();
            Task task = Servicios.ServicioSegundoPlano();
        }
    }
}
