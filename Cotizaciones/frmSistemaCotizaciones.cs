using backend.Servicios;

namespace Cotizaciones
{
    public partial class frmSistemaCotizaciones : Form
	{
		IServicios servicios = new Servicios();
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
	}
}