using backend;

namespace Cotizaciones
{
    public partial class Form1 : Form
    {
        IServicios servicios = new Servicios();
        public Form1()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            var clientes=servicios.GetClientes(Busqueda.Text);
            Busqueda.DataSource= clientes;
        }

        private void Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = Busqueda.SelectedItem as Cliente;
            Empresa.Text= c.Empresa;
            Nombre.Text= c.Contacto.Nombre;
            Correo.Text=c.Contacto.Correo;
        }

        private void Busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)//enter
                BuscarCliente_Click(sender, e);
        }
    }
}