using backend.Servicios;
using Microsoft.Extensions.Configuration;

namespace Cotizaciones
{
    public partial class frmSistemaCotizaciones : Form
    {
        public static IServicios servicios = new Servicios();
        public static IServiciosCRUD serviciosCRUD = new ServiciosCRUD(InitConfiguration());
        public frmSistemaCotizaciones()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//enter
                BuscarCliente_Click(sender, e);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProyecto newMDIChild = new NuevoProyecto();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void frmSistemaCotizaciones_Load(object sender, EventArgs e)
        {


        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newMDIChild = new frmConsultaProyectos();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            StatusLabel.Text = "Para ver los detalles de un proyecto haz doble click!";
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();
            return config;
        }
    }
}